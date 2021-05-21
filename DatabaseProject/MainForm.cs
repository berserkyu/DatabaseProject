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
            noticeLabel.Text = "enabled";
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

        private string ageGroup(int i)
        {
            switch (i)
            {
                case 1:
                    return "7-8";
                case 2:
                    return "9-10";
                case 3:
                    return "11-12";
                default:
                    return "其他";
            }
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
                dt.Columns.Add("排名", typeof(string));
                dt.Columns.Add("名字", typeof(string));
                dt.Columns.Add("队伍", typeof(string));
                dt.Columns.Add("积分", typeof(int));
                
                int rank = 1;
                DataRow row;
                while (reader.Read())
                {
                    row = dt.NewRow();
                    object[] objs = new object[3];
                    reader.GetValues(objs);
                    row["排名"] = rank++;
                    
                    row["名字"] = objs[0].ToString();
                    row["积分"] = objs[2].ToString();
                    row["队伍"] = objs[1].ToString();
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
                    " FROM teamCompetitionRank, teams";
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
                dt.Columns.Add("积分", typeof(int));
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    object[] objs = new object[5];
                    reader.GetValues(objs);

                    row["队伍"] = objs[0]?.ToString();
                    row["项目"] = objs[1]?.ToString();
                    row["性别"] = objs[2]?.ToString();
                    row["年龄组"] = ageGroup(int.Parse(objs[3]?.ToString()));
                    row["积分"] = int.Parse(objs[4]?.ToString());
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
                dt.Columns.Add("总积分", typeof(int));
                int rank = 1;
                while (reader.Read())
                {
                    object[] objs = new object[2];
                    reader.GetValues(objs);
                    DataRow row;
                    row = dt.NewRow();
                    row["排名"] = rank++;
                    row["队伍名字"] = objs[0]?.ToString();
                    row["总积分"] = int.Parse(objs[1]?.ToString()) ;
                    dt.Rows.Add(row);
                }
                teamOverallRank.DataSource = dt;
            }

            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (accType.Text.ToString())
            {
                case "系统管理员":
                    adminForm = new AdminForm(this);
                    adminForm.Show();
                    break;
                case "代表队":
                    teamForm = new TeamForm(this);
                    teamForm.Show();
                    break;
                case "小组裁判":
                    judgeForm = new JudgeForm(this);
                    judgeForm.Show();
                    break;
                case "小组总裁判":
                    mainJudgeForm = new MainJudgeForm(this);
                    mainJudgeForm.Show();
                    break;
                default:
                    noticeLabel.Text = "请选择账号类型";
                    return;  
            }
            disableComponents();
        }

        
    }
}
