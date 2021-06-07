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
    public partial class JudgeForm : Form
    {
        MainForm mainFormRef;
        NpgsqlConnection npgSqlCon1;
        NpgsqlConnection npgSqlCon2;
        NpgsqlDataReader readerAthleteInfo, reader;
        private string judgeAccNo, curGameId;
        private List<string> gamesAssigned;
        int i = 0;
        int score;
        bool curGame = false;
        public JudgeForm()
        {
            InitializeComponent();
        }
        public JudgeForm(MainForm mainForm,string accNo)
        {
            judgeAccNo = accNo;
            
            this.ControlBox = false;
            mainFormRef = mainForm as MainForm;
            InitializeComponent();

            string connStr = String.Format("server={0};Port={1};User Id={2};Password={3};Database={4}",
                 "localhost", "5432", "postgres", "JunYu1110@", "sport_competition");
            npgSqlCon1 = new NpgsqlConnection(connStr);
            npgSqlCon1.Open();
            npgSqlCon2 = new NpgsqlConnection(connStr);
            npgSqlCon2.Open();

            init();
           // showAthleteInfo();
        }


        private void logOut_Click(object sender, EventArgs e)
        {
            mainFormRef.enableComponents();
            this.Close();
        }
        //save button
        private void button1_Click(object sender, EventArgs e)
        {
            int t = i;
            
            int n = scoreBoard.Rows.Count;
            int[] scores = new int[n];
            NpgsqlCommand cmd;
            for (int j = 0; j < n-1; j++)
            {
                int score = 0;
                try { 
                    string val = scoreBoard.Rows[j].Cells[1].Value.ToString(); 
                    score = int.Parse(val); 
                }
                catch (Exception e1)
                {
                    MessageBox.Show("分数值错误1");
                    return;
                }
                if (score < 0 || score > 100)
                {
                    MessageBox.Show("分数值错误2");
                    return;
                }
                string athNo = scoreBoard.Rows[j].Cells[0].Value.ToString();
                string updateScore = String.Format("INSERT INTO scoreGiven(athleteNo,gameId,judgeNo,score)" +
                                                    " VALUES({0},{1},{2},{3})" +
                                                    " ON CONFLICT DO NOTHING",
                                                    athNo,gamesAssigned[i],judgeAccNo, score);
                System.Diagnostics.Debug.WriteLine(j+" : "+athNo + " " + gamesAssigned[i] + " " + judgeAccNo + " " + score);
                cmd = new NpgsqlCommand(updateScore);
                cmd.Connection = npgSqlCon1;
                cmd.ExecuteNonQuery();
            }
            System.Diagnostics.Debug.WriteLine("button1 clicked :" + t + " - >"+i++);
            renewScoreBoard();
            /*
            string updateScore = string.Format("UPDATE participates" +
                                               " SET score='{0}'" +
                                               " WHERE athleteNo = '{1}' " +
                                               " AND tournamentId = '{2}'", score_textBox.Text,
                                                                            athleteNo_label.Text,
                                                                            tournamentId_label.Text);
            NpgsqlCommand updateScore_cmd = new NpgsqlCommand(updateScore);
            updateScore_cmd.Connection = npgSqlCon2;
            updateScore_cmd.ExecuteNonQuery();

            showAthleteInfo();
            */
        }
        private void showAthleteInfo()
        {/*

            if (readerAthleteInfo.IsClosed)
            {
                MessageBox.Show("运动员打分已完成。");
                return;
            }
            if (readerAthleteInfo.Read())
            {
                object[] objs = new object[4];
                readerAthleteInfo.GetValues(objs);

                name_label.Text = objs[0].ToString();
                athleteNo_label.Text = objs[1].ToString();
                tournamentId_label.Text = objs[2].ToString();
                
                if(score_textBox.Text!="")
                    score = Int16.Parse(score_textBox.Text);
            }
            else readerAthleteInfo.Close();
            */
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (curGame != isFinal.Checked)
            {
                curGame = isFinal.Checked;
                init();
            }
        }

        private void renewScoreBoard()
        {
            System.Diagnostics.Debug.WriteLine("renew score board");
            if (i >= gamesAssigned.Count)
            {
                curGameLabel.Text = "已无可评分项目1" + i + ">=" + gamesAssigned.Count;
                button1.Enabled = false;
                return;
            }
            string curGameId = gamesAssigned[i];
            string compQuery = String.Format("SELECT gameType,gender,ageGroup" +
                                " FROM competitions,games" +
                                " WHERE competitions.compId=games.compId" +
                                "   AND games.gameId = '{0}'", gamesAssigned[i]);
            NpgsqlCommand cmd = new NpgsqlCommand(compQuery);
            cmd.Connection = npgSqlCon1;
            reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                curGameLabel.Text = "已无可评分项目2 " + i + ">=" + gamesAssigned.Count;
                button1.Enabled = false;
                reader.Close();
                return;
            }
            reader.Read();
            curGameLabel.Text = "当前项目:" + reader.GetString(0) + "   性别:" + (reader.GetValue(1)?.ToString() == "True" ? "男" : "女") +
                                   "   年龄组:" + ProgramCore.ageRange(reader.GetValue(2)?.ToString());
            reader.Close();
            
            
            DataTable dt = new DataTable();
            dt.Columns.Add("运动员号", typeof(string));
            dt.Columns.Add("成绩", typeof(int));
            curGameId = gamesAssigned[i];
            string query = "SELECT athleteNo FROM participates WHERE tournamentId='" + curGameId+"'";
            cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon1;
            reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                reader.Close();
                i++;
                renewScoreBoard();
                return;
            }
            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["运动员号"] = reader.GetValue(0).ToString();
                row["成绩"] = 0;
                dt.Rows.Add(row);
            }
            reader.Close();
            scoreBoard.DataSource = dt;
        }
        private void init()
        {
            gamesAssigned = new List<string>();
            string gameIdQuery = String.Format("SELECT judges.gameId FROM judges,games" +
                                               " WHERE judgeNo='{0}'" +
                                               " AND judges.gameId=games.gameId" +
                                               " AND games.stage={1}",judgeAccNo,curGame);
            NpgsqlCommand cmd = new NpgsqlCommand(gameIdQuery);
            cmd.Connection = npgSqlCon1;
            
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                System.Diagnostics.Debug.WriteLine(reader.GetValue(0)?.ToString());
                gamesAssigned.Add(reader.GetValue(0)?.ToString());
            }
            reader.Close();
            

            renewScoreBoard();

            /*
             string queryAthleteInfo = "SELECT name,athleteNo,tournamentId,\"Score\"" +
                                      " FROM athlete NATURAL JOIN participates";
            NpgsqlCommand cmd = new NpgsqlCommand(queryAthleteInfo);
            cmd.Connection = npgSqlCon1;
            readerAthleteInfo = cmd.ExecuteReader();
             */

        }
    }
}
