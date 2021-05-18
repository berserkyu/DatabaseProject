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
    public partial class TeamForm : Form
    {
        MainForm mainFormRef;
        public TeamForm()
        {
            InitializeComponent();
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
    }
}
