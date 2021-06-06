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
    public partial class TeamForm : Form
    {
        MainForm mainFormRef;
        NpgsqlConnection conn;
        NpgsqlDataReader reader;
        string teamAccNo;
        public TeamForm()
        {


        }
        public TeamForm(MainForm mainForm, string accNo)
        {
            teamAccNo = accNo;
            InitializeComponent();
            button1.BringToFront();
            conn = new NpgsqlConnection("server=localhost;Port=5432;User Id=TestAcc;Password=Zhen0102;Database=Test");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from athlete";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            }
            comm.Dispose();
            this.ControlBox = false;
            mainFormRef = mainForm as MainForm;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            mainFormRef.enableComponents();
            this.Close();
        }
        private void TeamForm_Load(object sender, EventArgs e) { }


        //非运动员
        private bool getNonAthleteGender()
        {
            return nonAthleteGenderUpDown.SelectedIndex == 0;
        }
        private void addNonAthleteInfo_Click(object sender, EventArgs e)
        {
            noticeLabel.Text = "non athlete clicked";
            if (nonAthleteIdNo.Text.Length != 5)
            {
                noticeLabel.Text = nonAthleteIdNo.Text.Length.ToString();
                return;
            }
            else
            {
                noticeLabel.Text = "non athlete clicked";
            }
            string lookUpExistingMember = String.Format(" SELECT * FROM teamNonAthleteMembers" +
                                                        " WHERE identityNo='{0}'", nonAthleteIdNo.Text.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand(lookUpExistingMember);
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                noticeLabel.Text = "该人员已存在";
                return;
            }
            reader.Close();

            string insertSql = String.Format(" INSERT INTO teamNonAthleteMembers(name,identityNo,teamAccNo,tel,gender)" +
                                            " VALUES('{0}','{1}','{2}','{3}','{4}')", nonAthleteName.Text, nonAthleteIdNo.Text, teamAccNo, nonAthletePhone.Text, getNonAthleteGender());
            cmd = new NpgsqlCommand(insertSql);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            noticeLabel.Text = "添加非运动员人员成功";
        }
        //运动员
        private bool getAthleteGender()
        {
            return AthleteGenderUpDown.SelectedIndex == 0;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            noticelabel2.Text = "athlete clicked";
            if (AthleteIdNo.Text.Length != 5)
            {
                noticelabel2.Text = AthleteIdNo.Text.Length.ToString();
                return;
            }
            else
            {
                noticelabel2.Text = "athlete clicked";
            }
            string lookUpExistingMember = String.Format(" SELECT * FROM teamAthleteMembers" +
                                                        " WHERE identityNo='{0}'", AthleteIdNo.Text.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand(lookUpExistingMember);
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                noticelabel2.Text = "该运动员已存在";
                return;
            }
            reader.Close();

            string insertSql = String.Format(" INSERT INTO teamAthleteMembers(name,identityNo,teamAccNo,age,gender)" +
                                            " VALUES('{0}','{1}','{2}','{3}','{4}')", AthleteName.Text, AthleteIdNo.Text, teamAccNo, AthleteAge.Text, getAthleteGender());
            cmd = new NpgsqlCommand(insertSql);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            noticelabel2.Text = "运动员添加成功";
        }

        //报名

    }
}
