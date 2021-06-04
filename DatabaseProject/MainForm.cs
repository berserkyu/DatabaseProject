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
        AdminForm adminForm;
        TeamForm teamForm;
        JudgeForm judgeForm;
        MainJudgeForm mainJudgeForm;
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

        
        private void tempButton_Click(object sender, EventArgs e)
        {
            // get rank from participates
            //personal overall rank
            string query = "WITH personalOverallRank as ("+
                                " WITH personalRank as (SELECT* FROM participates"+
                                    " ORDER BY \"tournamentid\" ASC,"+
                                    " \"Score\" ASC )"+
                                " SELECT name, athlete.teamAccNo,sum(\"Score\") as total_score" +
                                " FROM personalRank, games, competitions, athlete" +
                                " WHERE tournamentId = gameId" +
                                " AND personalRank.athleteNo = athlete.athleteNo" +
                                " AND games.compId = competitions.compId" +
                                " GROUP BY athlete.athleteNo)" +
                          " SELECT name, teamName, total_score" +
                          " FROM personalOverallRank, teams" +
                          " WHERE personalOverallRank.teamAccNo = teams.accNo" +
                          " GROUP BY name,teamName,total_score" +
                          " ORDER BY total_score DESC";
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
            query = " WITH teamCompetitionRank as ("+
                        " WITH teamTourRank as (SELECT teamAccNo, tournamentId, sum(\"Score\") as teamScore" +
                            " FROM athlete, participates" +
                            " WHERE athlete.athleteNo = participates.athleteNo" +
                            " GROUP BY teamAccNo,tournamentId)" +
                        " SELECT teamAccNo, teamScore, gameType, gender, ageGroup" +
                        " FROM teamTourRank, games, competitions" +
                        " WHERE tournamentId = gameID" +
                        " AND games.compId = competitions.compId)" +
                    " SELECT teamName, gameType, gender, ageGroup, teamScore" +
                    " FROM teamCompetitionRank, teams" +
                    " ORDER BY (gameType,gender,ageGroup) ASC," +
                            " teamScore DESC";
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
                    row["年龄组"] = ProgramCore.ageGroup(objs[3]?.ToString());
                    row["积分"] = objs[4]?.ToString();
                    dt.Rows.Add(row);
                }
                teamGamesRank.DataSource = dt ;
            }
            reader.Close();
            //team overall rank
            string query1 = "WITH teamNoRank as (" +
                                " SELECT teamAccNo, sum(\"Score\") as totalScore" +
                                " FROM participates, athlete" +
                                " WHERE participates.athleteNo = athlete.athleteNo" +
                                " GROUP BY teamAccNo" +
                                " ORDER BY totalScore DESC)" +
                            " SELECT teamName, totalScore" +
                            " FROM teamNoRank, teams" +
                            " WHERE teamNoRank.teamAccNo = teams.accNo" +
                            " GROUP BY teamAccNo,teamName,totalScore";
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
                    toShow = new JudgeForm(this);
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
            string query = " INSERT INTO participates(athleteNo, tournamentId,\"Score\")" +
                            " WITH athletesToAdvance as (" +
                                " WITH top4team as" +
                                    " (SELECT teamAccNo" +
                                    " FROM participates, athlete" +
                                    " WHERE participates.athleteNo = athlete.athleteNo" +
                                    " GROUP BY teamAccNo" +
                                    " LIMIT 4)" +
                                " SELECT athleteNo" +
                                " FROM top4team, teams, athlete" +
                                " WHERE top4team.teamAccNo = teams.accNo" +
                                " AND teams.memberIdentityNo = athlete.identityNo)" +
                            " SELECT athletesToAdvance.athleteNo,g2.gameId as finalsGameId,0" +
                            " FROM athletesToAdvance, participates, games as g1,competitions,games as g2" +
                            " WHERE athletesToAdvance.athleteNo = participates.athleteNo" +
                            " AND participates.tournamentId = g1.gameId" +
                            " AND g1.compId = competitions.compId" +
                            " AND g1.compId = g2.compId" +
                            " AND g2.stage = false";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            cmd.ExecuteNonQuery();
        }
    }
}
