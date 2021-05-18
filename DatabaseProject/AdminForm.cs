using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class AdminForm : Form
    {
        //MainForm mainForm;
        MainForm mainFormRef;
        public AdminForm()
        {
            //mainForm = new MainForm();
            InitializeComponent();
        }

        public AdminForm(MainForm mainForm)
        {
            mainFormRef = mainForm as MainForm;
            this.ControlBox = false;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainFormRef.enableComponents();
            this.Close();
        }
        void OnFormClosing(object sender, FormClosedEventArgs e)
        {
            mainFormRef.enableComponents();
        }

    }
}
