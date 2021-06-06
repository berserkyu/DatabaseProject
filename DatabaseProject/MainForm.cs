using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DatabaseProject
{
    public partial class MainForm : Form
    {
        NpgsqlConnection npgSqlCon;
        NpgsqlDataReader reader;

        public void enableComponents()
        {
            button1.Enabled = true;
        }
        
        public void disableComponents()
        {
            button1.Enabled = false;
        }
        public MainForm()
        {
            InitializeComponent();
            string connStr = String.Format("server={0};Port={1};User Id={2};Password={3};Database={4}",
                             "localhost", "5432", "postgres", "JunYu1110@", "sport_competition");
            npgSqlCon = new NpgsqlConnection(connStr);
            npgSqlCon.Open();
        }
        public void setNotice(string notice)
        {
            globalNoticeLabel.Text = notice;
        }
        //refresh results
        private void tempButton_Click(object sender, EventArgs e)
        {
            // get rank from participates
            //personal overall rank
            string query = " WITH t AS(SELECT athleteNo, avg(finalScore) as score" +
                                    " FROM participates" +
                                    " GROUP BY athleteNo)" +
                            " SELECT t.athleteNo,athlete.name,teamName,t.score" +
                            "  FROM t,athlete,teams" +
                            " WHERE t.athleteNo = athlete.athleteNo" +
                            " AND athlete.identityNo = teams.memberIdentityNo";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("排名", typeof(int));
                dt.Columns.Add("名字", typeof(string));
                dt.Columns.Add("队伍", typeof(string));
                dt.Columns.Add("积分", typeof(string));
                
                int rank = 1;
                DataRow row;
                while (reader.Read())
                {
                    row = dt.NewRow();
                    object[] objs = new object[3];
                    reader.GetValues(objs);
                    row["排名"] = rank++;
                    row["名字"] = objs[0]?.ToString();
                    row["积分"] = objs[2]?.ToString();
                    row["队伍"] = objs[1]?.ToString();
                    dt.Rows.Add(row);
                }
                personalRank.DataSource = dt;
            }
            reader.Close();
            //team games rank
            query =  "WITH t AS(SELECT teamAccNo, gameId, compId, sum(finalScore) teamTotalScore"+
                                    " FROM teams, athlete, participates, games"+
                                    " WHERE teams.memberIdentityNo= athlete.identityNo"+
                                    " AND athlete.athleteNo= participates.athleteNo"+
                                    " AND participates.tournamentId= games.gameId"+
                                    " GROUP BY teamAccNo, gameId),"+
	                            " tName AS(SELECT accNo, teamName FROM teams GROUP BY accNo, teamName)"+
                            " SELECT teamName, gameType, gender, ageGroup, teamTotalScore"+
                            " FROM tName, t, competitions"+
                            " WHERE tName.accNo = t.teamAccNo"+
                            " AND t.compId = competitions.compId" +
                            " ORDER BY teamTotalScore DESC";

            cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("队伍", typeof(string));
                dt.Columns.Add("项目", typeof(string));
                dt.Columns.Add("性别", typeof(string));
                dt.Columns.Add("年龄组", typeof(string));
                dt.Columns.Add("积分", typeof(string));
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    object[] objs = new object[5];
                    reader.GetValues(objs);

                    row["队伍"] = objs[0]?.ToString();
                    row["项目"] = objs[1]?.ToString();
                    row["性别"] = ((objs[2]?.ToString()=="True")?"男":"女");
                    row["年龄组"] = ProgramCore.ageRange(objs[3]?.ToString());
                    row["积分"] = objs[4]?.ToString();
                    dt.Rows.Add(row);
                }
                teamGamesRank.DataSource = dt ;
            }
            reader.Close();
            //team overall rank
            string query1 = " SELECT teamName,sum(finalScore) as s,teamAccNo" +
                            " FROM teams, athlete, participates" +
                            " WHERE teams.memberIdentityNo = athlete.identityNo" +
                            " AND athlete.athleteNo = participates.athleteNo" +
                            " GROUP BY teamAccNo,teamName" +
                            " ORDER BY s DESC";
            NpgsqlCommand cmd1 = new NpgsqlCommand(query1);
            cmd1.Connection = npgSqlCon;
            reader = cmd1.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("排名", typeof(int));
                dt.Columns.Add("队伍名字", typeof(string));
                dt.Columns.Add("总积分", typeof(string));
                int rank = 1;
                while (reader.Read())
                {
                    object[] objs = new object[2];
                    reader.GetValues(objs);
                    DataRow row;
                    row = dt.NewRow();
                    row["排名"] = rank++;
                    row["队伍名字"] = objs[0]?.ToString();
                    row["总积分"] = objs[1]?.ToString();
                    dt.Rows.Add(row);
                }
                teamOverallRank.DataSource = dt;
            }

            reader.Close();
        }
        private bool isValidAcc(int i,string accNo,string password)
        {
            string query = String.Format(" SELECT accNo,accPassword" +
                                         " FROM loginInfo" +
                                         " WHERE accType={0}",i);
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object[] objs = new object[2];
                    reader.GetValues(objs);
                    if (objs[0].ToString() == accNo)
                    {
                        if (objs[1].ToString() == password)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("密码错误", "错误",
MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }
                MessageBox.Show("账号不存在", "错误",
MessageBoxButtons.OK);
            return false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form toShow;
            int type = -1;
            switch (accType.Text.ToString())
            {
                case "系统管理员":
                    toShow = new AdminForm(this);
                    type = 1;
                    break;
                case "代表队":
                    toShow = new TeamForm(this,accNoTextBox.Text);
                    type = 2;
                    break;
                case "小组裁判":
                    toShow = new JudgeForm(this,accNoTextBox.Text);
                    type = 3;
                    break;
                case "小组总裁判":
                    toShow = new MainJudgeForm(this);
                    type = 4;
                    break;
                default:
                    noticeLabel.Text = "请选择账号类型";
                    return;  
            }
            if (isValidAcc(type, accNoTextBox.Text, accPasswordTextBox.Text))
            {
                toShow.Show();
                disableComponents();
            }
            reader.Close();
            
        }

        private void getFinalsSchedule_Click(object sender, EventArgs e)
        {
            finalsInformation finalForm = new finalsInformation();
            finalForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //generate games schedule entirely same as pre game
            string insertGames = "INSERT INTO games(compId,stage,time)" +
                                " SELECT compId,false,time" +
                                " FROM games";
            NpgsqlCommand cmd = new NpgsqlCommand(insertGames);
            cmd.Connection = npgSqlCon;
            cmd.ExecuteNonQuery();
            //generate athletes participation same as pre game
            string athleteParticipates = "INSERT INTO participates(tournamentId, athleteNo, finalScore)"+
                                        "WITH finals AS(SELECT * FROM games WHERE stage = false)"+
                                        "SELECT finals.gameId,athleteNo,0"+
                                        "FROM participates, games, finals"+
                                        "WHERE games.stage = true"+
                                        "AND games.compId = finals.compId"+
                                        "AND participates.tournamentId = games.gameId";
            cmd = new NpgsqlCommand(athleteParticipates);
            cmd.Connection = npgSqlCon;
            cmd.ExecuteNonQuery();
            //assigne same judges as pre game
            string assignJudges = "INSERT INTO judges(gameId, judgeNo)"+
                                    " WITH finals AS(SELECT * FROM games WHERE stage = false)"+
                                    " SELECT finals.gameId,judgeNo"+
                                    " FROM judges,games,finals"+
                                    " WHERE games.stage = true"+
                                    " AND games.compId = finals.compId"+
                                    " AND judges.gameId = games.gameId";
            cmd = new NpgsqlCommand(assignJudges);
            cmd.Connection = npgSqlCon;
            cmd.ExecuteNonQuery();
        }
    }
}
