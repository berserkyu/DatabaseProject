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
        NpgsqlDataReader readerAthleteInfo;
        object[] objs;
        int score, D, P;
        int finalScore;
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
                 "localhost", "5432", "postgres", "kzs3178042333", "sport_competition");
            npgSqlCon1 = new NpgsqlConnection(connStr);
            npgSqlCon1.Open();
            npgSqlCon2 = new NpgsqlConnection(connStr);
            npgSqlCon2.Open();

            string queryAthleteInfo = "SELECT name AS 名称,athleteNo AS 编号,tournamentId AS 场次,score AS 小组裁判给分,judgeAccNo AS 小组裁判账号" +
                                      " FROM athlete NATURAL JOIN participates NATURAL JOIN games" +
                                      " WHERE participates.tournamentId = games.gameId";
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(queryAthleteInfo, connStr);
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            init();
            showAthleteInfo();
        }
        private void init()
        {
            string queryAthleteInfo = "SELECT name,athleteNo,tournamentId,score" +
                                      " FROM athlete NATURAL JOIN participates";
            NpgsqlCommand cmd = new NpgsqlCommand(queryAthleteInfo);
            cmd.Connection = npgSqlCon1;
            readerAthleteInfo = cmd.ExecuteReader();
        }
        private void logOut_Click(object sender, EventArgs e)
        {
            mainFormRef.enableComponents();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }

        private void pass_Button_Click(object sender, EventArgs e)
        {
            if (judgeAccNo_textBox.Text == "") 
                MessageBox.Show("通过！请总裁判继续进行给分！");
        }

        private void not_pass_button_Click(object sender, EventArgs e)
        {
            if (judgeAccNo_textBox.Text != "")
            {
                string message = string.Format("不通过！请账号为{0}的小组裁判重新打分！", judgeAccNo_textBox.Text);
                MessageBox.Show(message);
            }
            else MessageBox.Show("请输入需重新打分的小组裁判账号！");
        }

        private void showAthleteInfo()
        {
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
        }

        private void countFinalScore()
        {
            //总成绩=去掉最高分和最低分的平均分*裁判数+D-P        
        }

       
    }
}
