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
    public partial class JudgeForm : Form
    {
        MainForm mainFormRef;
        public JudgeForm()
        {
            InitializeComponent();
        }
        public JudgeForm(MainForm mainForm)
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
