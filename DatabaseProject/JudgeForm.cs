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
        NpgsqlDataReader readerAthleteInfo;
        int score;
        public JudgeForm()
        {
            InitializeComponent();
        }
        public JudgeForm(MainForm mainForm)
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

            init();
            showAthleteInfo();
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
        private void showAthleteInfo()
        {

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
        }

        private void init()
        {
            string queryAthleteInfo = "SELECT name,athleteNo,tournamentId,score" +
                                      " FROM athlete NATURAL JOIN participates";
            NpgsqlCommand cmd = new NpgsqlCommand(queryAthleteInfo);
            cmd.Connection = npgSqlCon1;
            readerAthleteInfo = cmd.ExecuteReader();
        }
    }
}
