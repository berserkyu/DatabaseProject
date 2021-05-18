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
    public partial class MainJudgeForm : Form
    {
        MainForm mainFormRef;
        public MainJudgeForm()
        {
            InitializeComponent();
        }
        public MainJudgeForm(MainForm mainForm)
        {
            this.ControlBox = false;
            mainFormRef = mainForm as MainForm;
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            mainFormRef.enableComponents();
            this.Close();
        }
    }
}
