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
            conn = new NpgsqlConnection("server=localhost;Port=5432;User Id=postgres;Password=kzs3178042333;Database=sport_competition");
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool getNonAthleteGender()
        {
            return nonAthleteGenderUpDown.SelectedIndex == 0;
        }
        private void addNonAthleteInfo_Click(object sender, EventArgs e)
        {
            noticeLabel.Text = "non athlete clicked";
            noticeLabel1.Text = "non athlete clicked";
            if (nonAthleteIdNo.Text.Length != 5)
            {
                noticeLabel.Text = nonAthleteIdNo.Text.Length.ToString() ;
                noticeLabel1.Text = nonAthleteIdNo.Text.Length.ToString();
                return;
            }
            else
            {
                noticeLabel.Text = "non athlete clicked";
                noticeLabel1.Text = "non athlete clicked";
            }
            string lookUpExistingMember = String.Format(" SELECT * FROM teamNonAthleteMembers" +
                                                        " WHERE identityNo='{0}'", nonAthleteIdNo.Text.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand(lookUpExistingMember);
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                noticeLabel1.Text = "该人员已存在";
                noticeLabel.Text = "该人员已存在";
                return;
            }
            reader.Close();

            string insertSql = String.Format(" INSERT INTO teamNonAthleteMembers(name,identityNo,teamAccNo,tel,gender)" +
                                            " VALUES('{0}','{1}','{2}','{3}',{4})",nonAthleteName.Text,nonAthleteIdNo.Text,teamAccNo,nonAthletePhone.Text,getNonAthleteGender());
            cmd = new NpgsqlCommand(insertSql);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            noticeLabel.Text = "添加非运动员人员成功";
            noticeLabel1.Text = "添加非运动员人员成功";
        }
    }
}
