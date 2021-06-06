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
        int curAthleteNoMale=2 ,curAthleteNoFemale = 1;
        public TeamForm()
        {
            

        }
        public TeamForm(MainForm mainForm, string accNo)
        {
            //initialize variables & open connection
            this.ControlBox = false;
            mainFormRef = mainForm as MainForm;
            teamAccNo = accNo;
            InitializeComponent();
            button1.BringToFront();
            conn = new NpgsqlConnection("server=localhost;Port=5432;User Id=postgres;Password=JunYu1110@;Database=sport_competition");
            conn.Open();
            refreshAthleteInfo();
            refreshNonAthleteInfo();
            refreshParticipateInfo();
            this.Width = 1600;
            //get current maximum athleteNO
            string getAthNo = String.Format("SELECT max(athleteNo)" +
                                            " FROM athlete" +
                                            " GROUP BY gender");
            NpgsqlCommand cmd = new NpgsqlCommand(getAthNo);
            cmd.Connection = conn;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                r.Read();
                int a = int.Parse(r.GetValue(0).ToString());
                r.Read();
                int b = int.Parse(r.GetValue(0).ToString());
                if (a%2==0)
                {
                    curAthleteNoMale = a;
                    curAthleteNoFemale = b;
                }
                else
                {
                    curAthleteNoMale = b;
                    curAthleteNoFemale = a;
                }
            }
            r.Close();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            mainFormRef.enableComponents();
            this.Close();
        }
        private void TeamForm_Load(object sender, EventArgs e) { }

        private bool getNonAthleteGender()
        {
            return nonAthleteGenderUpDown.SelectedIndex == 0;
        }
        private void addNonAthleteInfo_Click(object sender, EventArgs e)
        {
            //check input info validity
            if(nonAthleteAccType.SelectedIndex==-1 || nonAthleteGenderUpDown.SelectedIndex == -1)
            {
                noticeLabelNonAthlete.Text = "请选择性别,职位";
                return;
            }
            if (nonAthletePhone.Text.Length > 10)
            {
                noticeLabelNonAthlete.Text = "电话号码过长(最大长度:10)";
                return;
            }
            if (nonAthleteName.Text.Length > 10)
            {
                noticeLabelNonAthlete.Text = "姓名过长(最大长度:10)";
                return;
            }
            if (nonAthleteIdNo.Text.Length != 5)
            {
                noticeLabelNonAthlete.Text = "身份证号长度必须为5";
                return;
            }

            string lookUpExistingMember = String.Format(" SELECT * FROM teamNonAthleteMembers" +
                                                        " WHERE identityNo='{0}'", nonAthleteIdNo.Text.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand(lookUpExistingMember);
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                noticeLabelNonAthlete.Text = "该身份证已存在";
                return;
            }
            reader.Close();

            string insertSql = String.Format(" INSERT INTO teamNonAthleteMembers(name,identityNo,teamAccNo,tel,gender,memberType)" +
                                            " VALUES('{0}','{1}','{2}','{3}','{4}','{5}')" +
                                            "ON CONFLICT DO NOTHING", nonAthleteName.Text,
                                            nonAthleteIdNo.Text,teamAccNo,nonAthletePhone.Text,
                                            getNonAthleteGender(),nonAthleteAccType.Text);
            cmd = new NpgsqlCommand(insertSql);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            noticeLabelNonAthlete.Text = "添加成功";
            refreshNonAthleteInfo();
        }

        private void addAthlete_Click(object sender, EventArgs e)
        {
            if (athleteGenderUpDown.SelectedIndex == -1)
            {
                noticeLabelAthlete.Text = "请选择性别";
                return;
            }
            if (athleteName.Text.Length > 10)
            {
                noticeLabelAthlete.Text = "姓名过长";
                return;
            }
            if(athleteId.Text.Length != 5)
            {
                noticeLabelAthlete.Text = "身份证号长度必须为5";
                return;
            }
            string lookUpExistingMember = String.Format("SELECT * FROM athlete" +
                                                        " WHERE identityNo='{0}'",
                                                        athleteId.Text);
            NpgsqlCommand cmd = new NpgsqlCommand(lookUpExistingMember);
            cmd.Connection = conn;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                noticeLabelAthlete.Text = "身份证号已存在";
                return;
            }
            r.Close();
            int newAthleteNo = 0;
            if (athleteGenderUpDown.SelectedIndex == 0)
            {
                newAthleteNo = curAthleteNoMale++;
            }
            else
            {
                newAthleteNo = curAthleteNoFemale++;
            }
            string insertAthlete = String.Format("INSERT INTO athlete(athleteNo,identityNo," +
                                                 "name,age,gender,culturalAchievement,teamAccNo)" +
                                                 " VALUES({0},'{1}','{2}',{3},{4},'{5}','{6}')" +
                                                 " ON CONFLICT DO NOTHING",
                                                 //athleteNo,identityNo,name
                                                 newAthleteNo, athleteId.Text,athleteName.Text,
                                                 //age,gender
                                                 athleteAge.Value,athleteGenderUpDown.SelectedIndex==0,
                                                 "x",teamAccNo);
            cmd = new NpgsqlCommand(insertAthlete);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            noticeLabelAthlete.Text = "添加成功,分配运动员号:"+newAthleteNo;
            refreshAthleteInfo();
        }
        
        private void participates_Click(object sender, EventArgs e)
        {
            string lookUpAthlete = String.Format("SELECT age,gender FROM athlete" +
                                                " WHERE athleteNo={0}" +
                                                "   AND teamAccNo='{1}'",
                                                participatesAthleteNo.Text, teamAccNo);
            NpgsqlCommand cmd = new NpgsqlCommand(lookUpAthlete);
            cmd.Connection = conn;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (!r.HasRows)
            {
                noticeLabelParticipate.Text = "此运动员未登记";
                r.Close();
                return;
            }
            r.Read();
            string ageG = ProgramCore.ageGroup(r.GetValue(0).ToString());
            bool gender = (r.GetValue(1).ToString() == "True");
            noticeLabelParticipate.Text = ageG +":"+ r.GetValue(0).ToString();
            r.Close();
            string validate = String.Format("SELECT * FROM competitions" +
                                            " WHERE gameType='{0}'" +
                                            "   AND ageGroup={1}" +
                                            "   AND gender={2}",
                                            gameTypeUpDown.SelectedItem.ToString(),
                                            ageG,gender);
            cmd = new NpgsqlCommand(validate);
            cmd.Connection = conn;
            r = cmd.ExecuteReader();
            if (!r.HasRows)
            {
                r.Close();
                noticeLabelParticipate.Text += " 该运动员不具有资格参加此项目";
                return;
            }
            r.Close();
            string insertParticipates = String.Format("INSERT INTO participates(athleteNo,tournamentId,finalScore)" +
                                                      " SELECT {0},gameId,0" +
                                                      " FROM competitions,games" +
                                                      " WHERE games.compId=competitions.compId" +
                                                      "   AND gameType='{1}'" +
                                                      "   AND ageGroup={2}" +
                                                      "   AND gender={3}" +
                                                      " ON CONFLICT DO NOTHING",
                                                      participatesAthleteNo.Text,
                                                      gameTypeUpDown.Text,
                                                      ageG,gender);
            cmd = new NpgsqlCommand(insertParticipates);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            refreshParticipateInfo();
        }

        private void refreshParticipateInfo()
        {
            string query = String.Format("SELECT athlete.athleteNo,gameType,time" +
                            " FROM athlete,participates,games,competitions" +
                            " WHERE participates.tournamentId=games.gameId" +
                            " AND games.compId=competitions.compId" +
                            " AND athlete.athleteNo=participates.athleteNo" +
                            " AND teamAccNo='{0}'", teamAccNo);
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = conn;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("运动员号");
                dt.Columns.Add("项目");
                dt.Columns.Add("场次");
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    row["运动员号"] = reader.GetValue(0).ToString();
                    row["项目"] = reader.GetString(1);
                    row["场次"] = reader.GetValue(2).ToString();
                    dt.Rows.Add(row);
                }
                participatesInfoGrid.DataSource = dt;
            }
            reader.Close();
            
        }
        private void refreshAthleteInfo()
        {
            string query = String.Format("SELECT athleteNo,identityNo,name,age,gender" +
                                        " FROM athlete" +
                                        " WHERE teamAccNo='{0}'",
                                        teamAccNo);
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = conn;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("运动员号", typeof(string));
                dt.Columns.Add("身份证号", typeof(string));
                dt.Columns.Add("姓名", typeof(string));
                dt.Columns.Add("年龄", typeof(string));
                dt.Columns.Add("性别", typeof(string));
                while (r.Read())
                {
                    DataRow row = dt.NewRow();
                    row["运动员号"] = r.GetValue(0)?.ToString();
                    row["身份证号"] = r.GetString(1);
                    row["姓名"] = r.GetString(2);
                    row["年龄"] = r.GetValue(3)?.ToString();
                    row["性别"] = (r.GetValue(4).ToString()=="True"?"男":"女");
                    dt.Rows.Add(row);
                }
                athleteInfoGrid.DataSource = dt;
            }
            r.Close();
        }

        private void refreshNonAthleteInfo()
        {
            string query = String.Format("SELECT memberType,identityNo,name,gender,tel" +
                                        " FROM teamNonAthleteMembers" +
                                        " WHERE teamAccNo='{0}'", teamAccNo);
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = conn;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("职位",typeof(string));
                dt.Columns.Add("身份证号", typeof(string));
                dt.Columns.Add("姓名", typeof(string));
                dt.Columns.Add("性别", typeof(string));
                dt.Columns.Add("电话号码", typeof(string));
                while (r.Read())
                {
                    DataRow row = dt.NewRow();
                    row["职位"] = r.GetString(0);
                    row["身份证号"] = r.GetString(1);
                    row["姓名"] = r.GetString(2);
                    row["性别"] = (r.GetValue(3).ToString()=="True"?"男":"女");
                    row["电话号码"] = r.GetString(4);
                    dt.Rows.Add(row);
                }
                nonAthleteInfoGrid.DataSource = dt;
            }
            r.Close();        
        }
    }
}
