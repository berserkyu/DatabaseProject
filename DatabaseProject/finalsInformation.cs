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
    public partial class finalsInformation : Form
    {
        NpgsqlConnection npgSqlCon;
        NpgsqlDataReader reader;
        public finalsInformation()
        {
            string connStr = String.Format("server={0};Port={1};User Id={2};Password={3};Database={4}",
                             "localhost", "5432", "postgres", "JunYu1110@", "sport_competition");
            npgSqlCon = new NpgsqlConnection(connStr);
            npgSqlCon.Open();
            InitializeComponent();
        }

        private void finalsInformation_Load(object sender, EventArgs e)
        {
            //得出决赛赛程
            string query = "SELECT gameType,gender,ageGroup,time" +
                            " FROM games,competitions" +
                            " WHERE games.compId = competitions.compId" +
                            " AND games.stage = false";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("项目", typeof(string));
                dt.Columns.Add("性别", typeof(string));
                dt.Columns.Add("年龄组", typeof(string));
                dt.Columns.Add("场次", typeof(int));
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    object[] objs = new object[4];
                    reader.GetValues(objs);
                    row["项目"] = objs[0]?.ToString();
                    row["性别"] = (objs[1]?.ToString() == "true" ? "男" : "女");
                    row["年龄组"] = ProgramCore.ageRange(objs[2]?.ToString());
                    row["场次"] = objs[3].ToString();
                    dt.Rows.Add(row);
                }
                reader.Close();
                finalsSchedule.DataSource = dt;
            }
            reader.Close();
            //得出决赛运动员参赛信息
            query = "SELECT athlete.name,teams.teamName gameType, competitions.gender,ageGroup,time"+
                    " FROM athlete,teams,participates,games,competitions"+
                    " WHERE athlete.athleteNo = participates.athleteNo"+
                    " AND athlete.teamAccNo = teams.accNo"+
                    " AND participates.tournamentId = games.gameId"+
                    " AND games.compId = competitions.compId"+
                    " AND games.stage = false"+
                    " ORDER BY time ASC,"+
                    " teamName DESC";
            cmd = new NpgsqlCommand(query);
            cmd.Connection = npgSqlCon;
            reader = cmd.ExecuteReader();
            
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("姓名", typeof(string));
                dt.Columns.Add("队伍", typeof(string));
                dt.Columns.Add("项目", typeof(string));
                dt.Columns.Add("性别", typeof(string));
                dt.Columns.Add("年龄组", typeof(string));
                dt.Columns.Add("场次", typeof(string));
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    object[] objs = new object[6];
                    reader.GetValues(objs);
                    row["姓名"] = objs[0]?.ToString();
                    row["队伍"] = objs[1]?.ToString();
                    row["项目"] = objs[2]?.ToString();
                    row["性别"] = (objs[3]?.ToString()=="true"?"男":"女");
                    row["年龄组"] = ProgramCore.ageRange(objs[4]?.ToString());
                    row["场次"] = objs[5]?.ToString();
                    dt.Rows.Add(row);
                }
                finalsParticipation.DataSource = dt;
            }
            else
            {
                noticeLab.Text = "决赛参赛信息暂未公布";
            }
        }
    }
}
