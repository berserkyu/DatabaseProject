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
        private void tempButton_Click(object sender, EventArgs e)
        {

            //loginInfo
            /*
             for (int i = 1; i <= 4; i++)
            {
                string insertCmd = String.Format("INSERT INTO loginInfo(accNo,accType,accPassword) VALUES({0},{1},{2})",
                                            "100000000" + i, 2, "100" + i);
                NpgsqlCommand cmd = new NpgsqlCommand(insertCmd);
                cmd.Connection = npgSqlCon;
                cmd.ExecuteNonQuery();
            }

            //teams and athletes
            for (int i = 1; i <= 4; i++)
            {
                //every member in the team is an athlete
                for (int j = 1; j <= 12; j++)
                {
                    int age = (j <= 4 ? 7 : (j <= 8 ? 9 : (j <= 12 ? 11 : 14)));
                    string insertCmd = String.Format("INSERT INTO teams(accNo,memberIdentityNo,teamName) VALUES({0},{1},{2})",
                                            "'100000000" + i+'\'', '\''+(i + (j > 9 ? "00" : "000") + j)+'\'', "'team" + i+'\'');
                    string insertCmd1 = String.Format("INSERT INTO athlete(athleteNo,identityNo,teamAccNo,age,name,gender,culturalAchievement) " +
                                                    " VALUES({0},{1},{2},{3},{4},{5},{6})", (i - 1) * 12 + j, '\'' + (i + (j > 9 ? "00" : "000") + j) + '\'', "'100000000" + i + '\'', age, '\''+(i + "Ath" + j)+'\'', j % 2 == 0, "'x'");
                    NpgsqlCommand cmd = new NpgsqlCommand(insertCmd);
                    cmd.Connection = npgSqlCon;
                    cmd.ExecuteNonQuery();
                    cmd = new NpgsqlCommand(insertCmd1);
                    cmd.Connection = npgSqlCon;
                    cmd.ExecuteNonQuery();
                }

            }
            //compeition
            string[] gameTypes = { "'单杠'","'双杠'","'吊环'","'跳马'","'自由体操'","'鞍马'","'蹦床'", "'高低杠'","'平衡木'" };
            foreach(string gameType in gameTypes)
            {
                //3 age groups
                for(int i = 1; i < 4; i++)
                {
                    //2 genders
                    string insertCmd = String.Format("INSERT INTO competitions(gameType,gender,ageGroup) VALUES({0},{1},{2})",
                                            gameType,true,i);
                    string insertCmd1 = String.Format("INSERT INTO competitions(gameType,gender,ageGroup) VALUES({0},{1},{2})",
                                            gameType, false, i);
                    NpgsqlCommand cmd = new NpgsqlCommand(insertCmd);
                    cmd.Connection = npgSqlCon;
                    cmd.ExecuteNonQuery();
                    cmd = new NpgsqlCommand(insertCmd1);
                    cmd.Connection = npgSqlCon;
                    cmd.ExecuteNonQuery();
                }
            }

            for (int j = 0; j < 1; j++)
            {
                string cmd = String.Format("INSERT INTO groupJudge(accNo,identityNo) VALUES({0},{1})",
                                            "3000000000","30000");
                NpgsqlCommand cmd2 = new NpgsqlCommand(cmd);
                cmd2.Connection = npgSqlCon;
                cmd2.ExecuteNonQuery();
            }
            //games
            string query = "SELECT * FROM competitions";
            NpgsqlCommand cmd1 = new NpgsqlCommand(query);
            cmd1.Connection = npgSqlCon;
            reader = cmd1.ExecuteReader();
            
            List<List<object>> lo = new List<List<object>>();
            while (reader.Read())
            {
                object[] vals = new object[4];
                var en = reader.GetValues(vals);
                List<object> t = new List<object>(vals);
                lo.Add(t);
            }
            reader.Close();
            int i = 1;
            foreach (List<object> l in lo)
            {
                string cmd = String.Format("INSERT INTO games(compId,judgeAccNo,stage,time) VALUES({0},{1},{2},{3})",
                                            l[0].ToString(), "3000000000", true, i++);
                NpgsqlCommand cmd2 = new NpgsqlCommand(cmd);
                cmd2.Connection = npgSqlCon;
                cmd2.ExecuteNonQuery();
            }

            // *** needs to create participates from athlete and games **
            string query = "SELECT athleteNo ,  gameId" +
                            " FROM athlete ,games,competitions" +
                            " WHERE athlete.gender =competitions.gender" +
                            " AND games.compId=competitions.compId" +
                            " AND athlete.age=7" +
                            " AND competitions.ageGroup=1";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            reader = cmd.ExecuteReader();
            Random rand = new Random();
            List<List<object>> lo = new List<List<object>>();
            while (reader.Read())
            {
                textBox1.Text += "a";
                
                object[] objs = new object[2];
                
                reader.GetValues(objs);
                List<object> os = new List<object>(objs);
                lo.Add(os);
                
            }
            reader.Close();
            foreach(List<object> objs in lo)
            {
                int t = rand.Next(9);
                string command = String.Format("INSERT INTO participates VALUES({0},{1},{2})",
                                               objs[0].ToString(), objs[1].ToString(), 10 - t);
                NpgsqlCommand cmd1 = new NpgsqlCommand(command);
                cmd1.Connection = npgSqlCon;
                cmd1.ExecuteNonQuery();
            }
            */


            // *** and get rank from participates
            
            string query = "SELECT * FROM participates " +
                            "ORDER BY \"tournamentid\" ASC, " +
                            "\"Score\" ASC";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                object[] objs = new object[3];
                reader.GetValues(objs);
                personalRankDisplay.Text += (objs[0].ToString() + "  " + objs[1].ToString() + "  "
                                    + objs[2].ToString() + "\r\n");
            }
            reader.Close();
            
            string query1 = "SELECT teamAccNo,sum(\"Score\") as totalScore" +
                            " FROM participates,athlete" +
                            " WHERE participates.athleteNo=athlete.athleteNo" +
                            " GROUP BY teamAccNo" +
                            " ORDER BY totalScore DESC";
            NpgsqlCommand cmd1 = new NpgsqlCommand(query1);
            cmd1.Connection = npgSqlCon;
            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                object[] objs = new object[2];
                reader.GetValues(objs);
                teamRankDisplay.Text += (objs[0].ToString() + "  " + objs[1].ToString() +"\r\n");
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
