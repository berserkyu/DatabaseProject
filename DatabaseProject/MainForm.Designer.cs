
namespace DatabaseProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accType = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.accPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tempButton = new System.Windows.Forms.Button();
            this.accNoTextBox = new System.Windows.Forms.TextBox();
            this.personalRank = new System.Windows.Forms.DataGridView();
            this.teamOverallRank = new System.Windows.Forms.DataGridView();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teamGamesRank = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noticeLab = new System.Windows.Forms.Label();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getFinalsSchedule = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personalRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOverallRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamGamesRank)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "运动比赛管理系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "账号类型";
            // 
            // accType
            // 
            this.accType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accType.Items.Add("系统管理员");
            this.accType.Items.Add("代表队");
            this.accType.Items.Add("小组裁判");
            this.accType.Items.Add("小组总裁判");
            this.accType.Location = new System.Drawing.Point(163, 158);
            this.accType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accType.Name = "accType";
            this.accType.Size = new System.Drawing.Size(215, 34);
            this.accType.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码";
            // 
            // accPasswordTextBox
            // 
            this.accPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accPasswordTextBox.Location = new System.Drawing.Point(163, 113);
            this.accPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accPasswordTextBox.Name = "accPasswordTextBox";
            this.accPasswordTextBox.PasswordChar = '*';
            this.accPasswordTextBox.Size = new System.Drawing.Size(215, 38);
            this.accPasswordTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "账号";
            // 
            // tempButton
            // 
            this.tempButton.Location = new System.Drawing.Point(871, 581);
            this.tempButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tempButton.Name = "tempButton";
            this.tempButton.Size = new System.Drawing.Size(272, 53);
            this.tempButton.TabIndex = 12;
            this.tempButton.Text = "刷新";
            this.tempButton.UseVisualStyleBackColor = true;
            this.tempButton.Click += new System.EventHandler(this.tempButton_Click);
            // 
            // accNoTextBox
            // 
            this.accNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNoTextBox.Location = new System.Drawing.Point(163, 70);
            this.accNoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accNoTextBox.Name = "accNoTextBox";
            this.accNoTextBox.Size = new System.Drawing.Size(215, 38);
            this.accNoTextBox.TabIndex = 5;
            // 
            // personalRank
            // 
            this.personalRank.BackgroundColor = System.Drawing.SystemColors.Window;
            this.personalRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalRank.Location = new System.Drawing.Point(17, 91);
            this.personalRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personalRank.Name = "personalRank";
            this.personalRank.ReadOnly = true;
            this.personalRank.RowHeadersWidth = 51;
            this.personalRank.RowTemplate.Height = 24;
            this.personalRank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.personalRank.Size = new System.Drawing.Size(632, 247);
            this.personalRank.TabIndex = 13;
            // 
            // teamOverallRank
            // 
            this.teamOverallRank.BackgroundColor = System.Drawing.SystemColors.Window;
            this.teamOverallRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamOverallRank.Location = new System.Drawing.Point(669, 91);
            this.teamOverallRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamOverallRank.Name = "teamOverallRank";
            this.teamOverallRank.ReadOnly = true;
            this.teamOverallRank.RowHeadersWidth = 51;
            this.teamOverallRank.RowTemplate.Height = 24;
            this.teamOverallRank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teamOverallRank.Size = new System.Drawing.Size(473, 247);
            this.teamOverallRank.TabIndex = 14;
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(663, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "队伍整体排名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "个人全能排名";
            // 
            // teamGamesRank
            // 
            this.teamGamesRank.BackgroundColor = System.Drawing.SystemColors.Window;
            this.teamGamesRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGamesRank.Location = new System.Drawing.Point(16, 390);
            this.teamGamesRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamGamesRank.Name = "teamGamesRank";
            this.teamGamesRank.ReadOnly = true;
            this.teamGamesRank.RowHeadersWidth = 51;
            this.teamGamesRank.RowTemplate.Height = 24;
            this.teamGamesRank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teamGamesRank.Size = new System.Drawing.Size(767, 244);
            this.teamGamesRank.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "队伍项目排名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noticeLab);
            this.groupBox1.Controls.Add(this.noticeLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.accType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.accNoTextBox);
            this.groupBox1.Controls.Add(this.accPasswordTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(416, 351);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登入";
            // 
            // noticeLab
            // 
            this.noticeLab.AutoSize = true;
            this.noticeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLab.Location = new System.Drawing.Point(27, 284);
            this.noticeLab.Name = "noticeLab";
            this.noticeLab.Size = new System.Drawing.Size(75, 36);
            this.noticeLab.TabIndex = 19;
            this.noticeLab.Text = "账号";
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.Location = new System.Drawing.Point(21, 284);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(0, 36);
            this.noticeLabel.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tempButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.teamOverallRank);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.teamGamesRank);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.personalRank);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(440, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1196, 646);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "积分榜";
            // 
            // getFinalsSchedule
            // 
            this.getFinalsSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFinalsSchedule.Location = new System.Drawing.Point(16, 420);
            this.getFinalsSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getFinalsSchedule.Name = "getFinalsSchedule";
            this.getFinalsSchedule.Size = new System.Drawing.Size(140, 53);
            this.getFinalsSchedule.TabIndex = 19;
            this.getFinalsSchedule.Text = "获取决赛赛程";
            this.getFinalsSchedule.UseVisualStyleBackColor = true;
            this.getFinalsSchedule.Click += new System.EventHandler(this.getFinalsSchedule_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(225, 420);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 53);
            this.button2.TabIndex = 20;
            this.button2.Text = "生成决赛赛程";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 704);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getFinalsSchedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personalRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamOverallRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamGamesRank)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown accType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accNoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tempButton;
        private System.Windows.Forms.DataGridView personalRank;
        private System.Windows.Forms.DataGridView teamOverallRank;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView teamGamesRank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.Button getFinalsSchedule;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label noticeLab;
    }
}

