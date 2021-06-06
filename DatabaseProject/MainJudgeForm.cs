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
    public partial class MainJudgeForm : Form
    {
        MainForm mainFormRef;
        NpgsqlConnection npgSqlCon1;
        NpgsqlConnection npgSqlCon2;
        NpgsqlConnection npgSqlCon;
        List<string> gamesToReview, athNo;
        NpgsqlDataReader readerAthleteInfo, reader;
        object[] objs;
        int score, D, P;
        int finalScore;
        int i = 0;
        public MainJudgeForm()
        {
            InitializeComponent();

        }
        public MainJudgeForm(MainForm mainForm)
        {
            this.ControlBox = false;
            mainFormRef = mainForm as MainForm;
            InitializeComponent();

            string connStr = String.Format("server={0};Port={1};User Id={2};Password={3};Database={4}",
                 "localhost", "5432", "postgres", "JunYu1110@", "sport_competition");
            npgSqlCon1 = new NpgsqlConnection(connStr);
            npgSqlCon1.Open();
            npgSqlCon2 = new NpgsqlConnection(connStr);
            npgSqlCon2.Open();
            npgSqlCon = new NpgsqlConnection(connStr);
            npgSqlCon.Open();
            init();
            renewScoreBoard();
            /*
            string queryAthleteInfo = "SELECT name AS 名称,athleteNo AS 编号,tournamentId AS 场次,score AS 小组裁判给分,judgeAccNo AS 小组裁判账号" +
                                      " FROM athlete NATURAL JOIN participates NATURAL JOIN games" +
                                      " WHERE participates.tournamentId = games.gameId";
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(queryAthleteInfo, connStr);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            init();
            showAthleteInfo();
            */
        }
        private void init()
        {
            /*
            string queryAthleteInfo = "SELECT name,athleteNo,tournamentId,score" +
                                      " FROM athlete NATURAL JOIN participates";
            NpgsqlCommand cmd = new NpgsqlCommand(queryAthleteInfo);
            cmd.Connection = npgSqlCon1;
            readerAthleteInfo = cmd.ExecuteReader();
            */
            gamesToReview = new List<string>();
            string gamesToReviewQuery = "SELECT gameId FROM games";
            NpgsqlCommand cmd = new NpgsqlCommand(gamesToReviewQuery);
            cmd.Connection = npgSqlCon;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                System.Diagnostics.Debug.WriteLine(reader.GetValue(0).ToString());
                gamesToReview.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
        }
        private void logOut_Click(object sender, EventArgs e)
        {
            mainFormRef.enableComponents();
            this.Close();
        }
        //save
        private void button1_Click(object sender, EventArgs e)
        {
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

        private void pass_Button_Click(object sender, EventArgs e)
        {
            //calculate average score for each athletes and update them in the database
            try
            {
                D = int.Parse(D_textBox.Text);
                P = int.Parse(P_textBox.Text);
            }catch(Exception ee)
            {
                MessageBox.Show("请输入合法的D与P值");
                return;
            }
            calPersonalScore();
            renewFinalScoreBoard();
            //move on
            i++;
            renewScoreBoard();
        }

        private void not_pass_button_Click(object sender, EventArgs e)
        {
            if (judgeAccNo_textBox.Text != "")
            {
                //notify the judges
                string message = "不通过！请以下账号的小组裁判重新打分！\r\n";
                string[] invalidJudges = judgeAccNo_textBox.Lines;
                foreach(string s in invalidJudges)
                {
                    message += s + "\r\n";
                    //delete the invalid scores from database so that no score is given twice
                    string delRecord = String.Format("DELETE FROM scoreGiven" +
                                                    " WHERE judgeNo={0}" +
                                                    "   AND gameId={1}", s, gamesToReview[i]);
                    NpgsqlCommand cmd = new NpgsqlCommand(delRecord);
                    cmd.Connection = npgSqlCon;
                    cmd.ExecuteNonQuery();
                }
                mainFormRef.setNotice(message);
                

            }
            else MessageBox.Show("请输入需重新打分的小组裁判账号！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //refresh
            renewScoreBoard();
        }

        private void showAthleteInfo()
        {
            /*
            if (readerAthleteInfo.IsClosed)
            {
                MessageBox.Show("运动员打分已完成。");
                return;
            }
            if (readerAthleteInfo.Read())
            {
                objs= new object[4];
                readerAthleteInfo.GetValues(objs);

                name_label.Text = objs[0].ToString();
                athleteNo_label.Text = objs[1].ToString();
                tournamentId_label.Text = objs[2].ToString();

                if (score_textBox.Text != "" && score_textBox.Text != "" && score_textBox.Text != "")
                {
                    score = Int16.Parse(score_textBox.Text);
                    D = Int16.Parse(D_textBox.Text);
                    P = Int16.Parse(P_textBox.Text);
                }
            }
            else readerAthleteInfo.Close();  
            */
        }
        //calculate personal score on current game and update it to the database
        private void calPersonalScore()
        {
            //总成绩=去掉最高分和最低分的平均分*裁判数+D-P
            foreach(string athleteNo in athNo)
            {
                string calAvg = String.Format("WITH allScores as (" +
                                                    " SELECT score" +
                                                    " FROM scoreGiven" +
                                                    " WHERE athleteNo = 2)" +
                                            " SELECT avg(score)" +
                                            " FROM scoreGiven" +
                                            " WHERE athleteNo = {0}" +
                                            " AND gameId = {1}" +
                                            " AND score<>(SELECT max(score) FROM allScores)" +
                                            " AND score<>(SELECT min(score) FROM allScores)",
                                            athleteNo,gamesToReview[i]);

                string judgeCnt = String.Format("SELECT count(judgeNo)" +
                                                " FROM scoreGiven" +
                                                " WHERE athleteNo={0}" +
                                                "   AND gameId={1}",
                                                athleteNo,gamesToReview[i]);
                NpgsqlCommand cmd = new NpgsqlCommand(calAvg);
                cmd.Connection = npgSqlCon;
                reader = cmd.ExecuteReader();
                if (!reader.HasRows) continue;
                reader.Read();
                System.Diagnostics.Debug.WriteLine(athleteNo+ " average : "+reader.GetValue(0).ToString());
                int average = (int)float.Parse(reader.GetValue(0).ToString());
                reader.Close();
                cmd = new NpgsqlCommand(judgeCnt);
                cmd.Connection = npgSqlCon;
                reader = cmd.ExecuteReader();
                reader.Read();
                average *= int.Parse(reader.GetValue(0).ToString());
                average += (D - P);
                reader.Close();
                string updateFinalScore = String.Format("UPDATE participates" +
                                                        " SET finalScore={0}" +
                                                        " WHERE athleteNo={1}" +
                                                        "   AND tournamentId={2}",
                                                        average, athleteNo, gamesToReview[i]);
                cmd = new NpgsqlCommand(updateFinalScore);
                cmd.Connection = npgSqlCon;
                cmd.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine(athleteNo + "  " + gamesToReview[i] + " " + average);
                
            }
            
        }
        private void renewFinalScoreBoard()
        {
            string query = String.Format("SELECT athleteNo,finalScore" +
                                        " FROM participates" +
                                        " WHERE tournamentId={0}",
                                        gamesToReview[i]);
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("运动员号", typeof(string));
                dt.Columns.Add("总分", typeof(string));
                while (r.Read())
                {
                    DataRow row = dt.NewRow();
                    row["运动员号"] = r.GetValue(0).ToString();
                    row["总分"] = r.GetValue(1).ToString();
                    dt.Rows.Add(row);
                }
                finalScoreBoard.DataSource = dt;
            }
            r.Close();
        }
        private void renewScoreBoard()
        {
            if(i>= gamesToReview.Count)
            {
                button1.Enabled = false;
                gameLabel.Text = "已完成所有评估";
                return;
            }
            string curGameId = gamesToReview[i];
            string getAthNo = String.Format("SELECT athleteNo FROM participates" +
                                             " WHERE tournamentId={0}", curGameId);
            NpgsqlCommand cmd = new NpgsqlCommand(getAthNo);
            cmd.Connection = npgSqlCon;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (!r.HasRows)
            {
                r.Close();
                i++;
                renewScoreBoard();
                return;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("运动员号", typeof(string));
            dt.Columns.Add("裁判号", typeof(string));
            dt.Columns.Add("给分", typeof(string));
            athNo = new List<string>();
            while (r.Read())
            {
                athNo.Add(r.GetValue(0).ToString());
            }
            r.Close();
            int n = athNo.Count - 1;
            for(int j = 0; j < n; j++)
            {
               
                string queryScoreBoard = String.Format("SELECT judgeNo,score" +
                                                        " FROM scoreGiven" +
                                                        " WHERE gameId={0}" +
                                                        " AND athleteNo={1}",
                                                        curGameId,athNo[j]);
                cmd = new NpgsqlCommand(queryScoreBoard);
                cmd.Connection = npgSqlCon;
                r = cmd.ExecuteReader();
                if (!r.HasRows)
                {
                    r.Close();
                    continue;
                }
                r.Read();
                DataRow row = dt.NewRow();
                row["运动员号"] = athNo[j];
                row["裁判号"] = r.GetValue(0).ToString();
                row["给分"] = r.GetValue(1).ToString();
                dt.Rows.Add(row);
                while (r.Read())
                {
                    row = dt.NewRow();
                    row["运动员号"] = "   ";
                    row["裁判号"] = r.GetValue(0).ToString();
                    row["给分"] = r.GetValue(1).ToString();
                    dt.Rows.Add(row);
                }
                scoreBoard.DataSource = dt;
                r.Close();
            }

        }
        private void countFinalScore()
        {
            //总成绩=去掉最高分和最低分的平均分*裁判数+D-P        
        }

       
    }
}
