﻿using System;
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
        NpgsqlConnection npgSqlCon;
        NpgsqlDataReader reader;
        public TeamForm()
        {
            InitializeComponent();
            NpgsqlConnection conn = new NpgsqlConnection ("server=localhost;Port=5432;User Id=TestAcc;Password=Zhen0102;Database=Test");
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
                dataGridView1.DataSourse = dt;
            }
            comm.Dispose();
            conn.Close();

        }

        public TeamForm(MainForm mainForm )
        {
            this.ControlBox = false;
            mainFormRef = mainForm as MainForm;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

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
        public void Leader()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
            }
        }
        public void Athlete()
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
            }
        }
        public void Coach()
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
            }
        }
        public void Referee()
        {
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
