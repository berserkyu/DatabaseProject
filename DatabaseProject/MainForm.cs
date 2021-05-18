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
    public partial class MainForm : Form
    {
        AdminForm adminForm;
        TeamForm teamForm;
        JudgeForm judgeForm;
        MainJudgeForm mainJudgeForm;
        public void enableComponents()
        {
            noticeLabel.Text = "enabled";
            button1.Enabled = true;
        }
        
        public void disableComponents()
        {
            button1.Enabled = false;
        }
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (accType.Text.ToString())
            {
                case "系统管理员":
                    adminForm = new AdminForm(this);
                    adminForm.Show();
                    break;
                case "代表队":
                    teamForm = new TeamForm(this);
                    teamForm.Show();
                    break;
                case "小组裁判":
                    judgeForm = new JudgeForm(this);
                    judgeForm.Show();
                    break;
                case "小组总裁判":
                    mainJudgeForm = new MainJudgeForm(this);
                    mainJudgeForm.Show();
                    break;
                default:
                    noticeLabel.Text = "请选择账号类型";
                    return;  
            }
            disableComponents();
        }
    }
}
