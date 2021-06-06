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
    public partial class AdminForm : Form
    {
        //MainForm mainForm;
        MainForm mainFormRef;
        NpgsqlConnection npgsqlcon;
        NpgsqlDataReader reader;
        Dictionary<string, string> curAcc;
        int[] occupied;
        bool showsPassword = false;
        public AdminForm()
        {
            //mainForm = new MainForm();
            InitializeComponent();
            
        }

        public AdminForm(MainForm mainForm)
        {
            occupied = new int[58];
            mainFormRef = mainForm as MainForm;
            curAcc = new Dictionary<string, string>();
            string connStr = String.Format("server={0};Port={1};User Id={2};Password={3};Database={4}",
                             "localhost", "5432", "postgres", "JunYu1110@", "sport_competition");
            npgsqlcon = new NpgsqlConnection(connStr);
            npgsqlcon.Open();
            this.ControlBox = false;
            InitializeComponent();
            refreshSchedule_Click(this,EventArgs.Empty);
            button2_Click(this, EventArgs.Empty);
            refreshJudgingInfo();
        }
        private bool getCurGender()
        {
            return (genderUpDown.SelectedIndex == 0);
        }
        private int getCurAgeGroup()
        {
            noticeLabelSchedule.Text = (ageGroupUpDown.SelectedIndex + 1).ToString();
            return ageGroupUpDown.SelectedIndex + 1;
        }
        private string accTypes(string accTypeNo)
        {
            switch (accTypeNo)
            {
                case "1":
                    return "管理员";
                case "2":
                    return "代表队";
                case "3":
                    return "小组裁判";
                case "4":
                    return "总裁判";
                default:
                    return "未知";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            npgsqlcon.Close();
            mainFormRef.enableComponents();
            this.Close();
        }
        void OnFormClosing(object sender, FormClosedEventArgs e)
        {
            mainFormRef.enableComponents();
        }
        //refresh acc info
        private void button2_Click(object sender, EventArgs e)
        {
            showsPassword = checkBoxShowPW.Checked;
            string query =  " SELECT accNo,accType,accPassword" +
                            " FROM loginInfo" +
                            " ORDER BY accType";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgsqlcon;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("账号", typeof(string));
                dt.Columns.Add("账号类型", typeof(string));
                if(showsPassword) dt.Columns.Add("密码", typeof(string));
                while (reader.Read()){
                    object[] objs = new object[3];
                    reader.GetValues(objs);
                    DataRow row = dt.NewRow();
                    if (!curAcc.ContainsKey(objs[0].ToString()))
                    {
                        curAcc.Add(objs[0].ToString(), objs[1].ToString());
                    }
                    row["账号"] = objs[0].ToString();
                    row["账号类型"] = accTypes(objs[1].ToString());
                    if (showsPassword) row["密码"] = objs[2].ToString();
                    dt.Rows.Add(row);
                }
                reader.Close();
                accInfoGridView.DataSource = dt;
            }
            else
            {
                noticeLabel.Text = "未发现任何账号信息";
            }
        }

        private void addAcc_Click(object sender, EventArgs e)
        {
            string command = String.Format("INSERT INTO loginInfo(accNo,accType,accPassword)" +
                                            " VALUES({0},{1},{2})" +
                                            " ON CONFLICT DO NOTHING", accNo.Text, accType.SelectedIndex + 2,passWord.Text);
            NpgsqlCommand cmd = new NpgsqlCommand(command);
            cmd.Connection = npgsqlcon;
            cmd.ExecuteNonQuery();
            button2_Click(this,EventArgs.Empty);
            noticeLabel.Text = "账号已创建";
        }

        private void delAcc_Click(object sender, EventArgs e)
        {
            string command = String.Format("DELETE FROM loginInfo " +
                                            " WHERE accNo ='{0}'" +
                                            " AND accType <> 1",accNo.Text);
            NpgsqlCommand cmd = new NpgsqlCommand(command);
            cmd.Connection = npgsqlcon;
            //groupJudge table references judge's accNo
            cmd.ExecuteNonQuery();
            button2_Click(this, EventArgs.Empty);
            noticeLabel.Text = "账号已删除";
        }

        private void refreshSchedule_Click(object sender, EventArgs e)
        {
            string query =  "SELECT gameType,gender,ageGroup,time,gameId" +
                            " FROM games,competitions" +
                            " WHERE games.compId = competitions.compId" +
                            "   AND stage=true" +
                            " ORDER BY time ASC";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgsqlcon;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("场次编号", typeof(string));
                dt.Columns.Add("场次", typeof(string));
                dt.Columns.Add("项目", typeof(string));
                dt.Columns.Add("性别", typeof(string));
                dt.Columns.Add("年龄组", typeof(string));
                for (int i = 0; i < 55; i++) occupied[i] = 0;
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    object[] objs = new object[5];
                    reader.GetValues(objs);
                    row["场次编号"] = objs[4]?.ToString();
                    row["项目"] = objs[0]?.ToString();
                    row["性别"] = (objs[1]?.ToString() == "True" ? "男" : "女");
                    row["年龄组"] = ProgramCore.ageRange(objs[2]?.ToString());
                    row["场次"] = objs[3].ToString();
                    occupied[int.Parse(objs[3].ToString())] = 1;
                    dt.Rows.Add(row);
                }
                scheduleGridView.DataSource = dt;
            }
            reader.Close();
        }
        private bool checkAddInfo()
        {
            return true;
        }
        private void addToSchedule_Click(object sender, EventArgs e)
        {
            refreshSchedule_Click(this,EventArgs.Empty);
            int arrange = int.Parse(arrangementUpDown.Value.ToString());
            //check if the arrangement has been occupied
            if (occupied[arrange] == 1)
            {
                noticeLabel1.Text = "该场次已被占用";
                return;
            }
            occupied[arrange] = 1;
            //check if the competition exists
            string getCompId = String.Format("SELECT compId FROM competitions" +
                                                " WHERE gameType ='{0}'" +
                                                " AND gender={1}" +
                                                " AND ageGroup='{2}'",
                                                gameTypeUpDown.Text,getCurGender(),getCurAgeGroup());
            
            NpgsqlCommand cmd = new NpgsqlCommand(getCompId);
            cmd.Connection = npgsqlcon;
            reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                noticeLabelSchedule.Text = "此比赛不合法";
                reader.Close();
            }
            reader.Read();
            string compId = reader.GetValue(0)?.ToString();
            reader.Close();
            string checkQuery = String.Format("SELECT gameId FROM games" +
                                                " WHERE compId={0}", compId);
            cmd = new NpgsqlCommand(checkQuery);
            cmd.Connection = npgsqlcon;
            reader = cmd.ExecuteReader();
            //if the game has already in games
            if (reader.HasRows)
            {
                string gameId = reader.GetValue(0).ToString();
                reader.Close();
                string update = String.Format(  "UPDATE games" +
                                                " SET time={0}" +
                                                " WHERE compId='{1}'" 
                                                , arrange,compId);
                cmd = new NpgsqlCommand(update);
                cmd.Connection = npgsqlcon;
                cmd.ExecuteNonQuery();
                noticeLabel1.Text = "当前比赛已存在安排,已更新其场次";
            }
            //if it is not yet in the game ie.not yet arranged to the schedule
            else
            {
                reader.Close();
                string insert = String.Format(" INSERT INTO games(compId,stage,time)" +
                                                " VALUES('{0}',{1},{2})" +
                                                " ON CONFLICT DO NOTHING",
                                                compId,true,arrange);
                cmd = new NpgsqlCommand(insert);
                cmd.Connection = npgsqlcon;
                cmd.ExecuteNonQuery();
                noticeLabel1.Text = "已添加比赛场次";
            }
            refreshSchedule_Click(this, EventArgs.Empty);
            
        }

        private void delSchedule_Click(object sender, EventArgs e)
        {
            refreshSchedule_Click(this, EventArgs.Empty);
            int arrange = int.Parse(arrangementUpDown.Value.ToString());
            if (occupied[arrange] == 0)
            {
                noticeLabel.Text = "该场次并未安排比赛";
            }
            occupied[arrange]=0;
            string getCompInfo = String.Format(" SELECT gameType,gender,ageGroup FROM competitions,games" +
                                                   " WHERE competitions.compId=games.compId" +
                                                   "   AND time = {0}",arrange);

            NpgsqlCommand cmd1 = new NpgsqlCommand(getCompInfo);
            cmd1.Connection = npgsqlcon;
            reader = cmd1.ExecuteReader();
            if (reader.HasRows) reader.Read();
            else return;
            object[] objs = new object[3];
            reader.GetValues(objs);
            reader.Close();

            string delete = String.Format("   DELETE FROM games" +
                                            " WHERE time={0}",arrange);
            NpgsqlCommand cmd = new NpgsqlCommand(delete);
            cmd.Connection = npgsqlcon;
            cmd.ExecuteNonQuery();
            noticeLabel1.Text = "场次已删除 : (" +objs[0].ToString()+" , "+objs[1].ToString()+" , "
                                + objs[2].ToString()+")";
        }

        private void addJudgeToGame_Click(object sender, EventArgs e)
        {
            string lookUpJudge = String.Format("SELECT * FROM loginInfo" +
                                                " WHERE accNo='{0}'" +
                                                "   AND accType=3",judgeAccNo.Text);
            NpgsqlCommand cmd = new NpgsqlCommand(lookUpJudge);
            cmd.Connection = npgsqlcon;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (!r.HasRows)
            {
                r.Close();
                noticeLabelAddJudge.Text = "裁判不存在";
                return;
            }
            r.Close();
            lookUpJudge = String.Format("SELECT * FROM games" +
                                        " WHERE gameId={0}", gameToJudge.Text);
            cmd = new NpgsqlCommand(lookUpJudge);
            cmd.Connection = npgsqlcon;
            r = cmd.ExecuteReader();
            if (!r.HasRows)
            {
                r.Close();
                noticeLabelAddJudge.Text = "场次不存在";
                return;
            }
            r.Close();
            string lookUpJuding = String.Format("SELECT * FROM judges" +
                                                " WHERE judgeNo='{0}'" +
                                                "   AND gameId={1}",
                                                judgeAccNo.Text, gameToJudge.Text);
            cmd = new NpgsqlCommand(lookUpJuding);
            cmd.Connection = npgsqlcon;
            r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                r.Close();
                return;
            }
            r.Close();
            string addJudging = String.Format("INSERT INTO judges(judgeNo,gameId)" +
                                                " VALUES('{0}',{1})" +
                                                " ON CONFLICT DO NOTHING",
                                                judgeAccNo.Text, gameToJudge.Text);
            cmd = new NpgsqlCommand(addJudging);
            cmd.Connection = npgsqlcon;
            cmd.ExecuteNonQuery();
            noticeLabelAddJudge.Text = "添加成功";
            refreshJudgingInfo();
        }

        private void refreshJudgingInfo()
        {
            string query = "SELECT judgeNo,gameId FROM judges ORDER BY judgeNo";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgsqlcon;
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows) {
                DataTable dt = new DataTable();
                dt.Columns.Add("裁判账号", typeof(string));
                dt.Columns.Add("场次编号", typeof(string));
                while (r.Read())
                {
                    DataRow row = dt.NewRow();
                    row["裁判账号"] = r.GetValue(0).ToString();
                    row["场次编号"] = r.GetValue(1).ToString();
                    dt.Rows.Add(row);
                }
                judgesInfoGrid.DataSource = dt;
            }
            r.Close();
        }
    }
}
