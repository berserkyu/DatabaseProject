
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
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tempButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.personalRank = new System.Windows.Forms.DataGridView();
            this.teamOverallRank = new System.Windows.Forms.DataGridView();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teamGamesRank = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noticeLabel = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "运动比赛管理系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
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
            this.accType.Location = new System.Drawing.Point(122, 128);
            this.accType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accType.Name = "accType";
            this.accType.Size = new System.Drawing.Size(161, 28);
            this.accType.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "密码";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(122, 92);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(162, 32);
            this.password.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "账号";
            // 
            // tempButton
            // 
            this.tempButton.Location = new System.Drawing.Point(653, 472);
            this.tempButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tempButton.Name = "tempButton";
            this.tempButton.Size = new System.Drawing.Size(204, 43);
            this.tempButton.TabIndex = 12;
            this.tempButton.Text = "刷新";
            this.tempButton.UseVisualStyleBackColor = true;
            this.tempButton.Click += new System.EventHandler(this.tempButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 32);
            this.textBox1.TabIndex = 5;
            // 
            // personalRank
            // 
            this.personalRank.BackgroundColor = System.Drawing.SystemColors.Window;
            this.personalRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalRank.Location = new System.Drawing.Point(13, 74);
            this.personalRank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personalRank.Name = "personalRank";
            this.personalRank.ReadOnly = true;
            this.personalRank.RowHeadersWidth = 51;
            this.personalRank.RowTemplate.Height = 24;
            this.personalRank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.personalRank.Size = new System.Drawing.Size(474, 201);
            this.personalRank.TabIndex = 13;
            // 
            // teamOverallRank
            // 
            this.teamOverallRank.BackgroundColor = System.Drawing.SystemColors.Window;
            this.teamOverallRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamOverallRank.Location = new System.Drawing.Point(502, 74);
            this.teamOverallRank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamOverallRank.Name = "teamOverallRank";
            this.teamOverallRank.ReadOnly = true;
            this.teamOverallRank.RowHeadersWidth = 51;
            this.teamOverallRank.RowTemplate.Height = 24;
            this.teamOverallRank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teamOverallRank.Size = new System.Drawing.Size(355, 201);
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
            this.label6.Location = new System.Drawing.Point(497, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "队伍整体排名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "个人全能排名";
            // 
            // teamGamesRank
            // 
            this.teamGamesRank.BackgroundColor = System.Drawing.SystemColors.Window;
            this.teamGamesRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGamesRank.Location = new System.Drawing.Point(12, 317);
            this.teamGamesRank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamGamesRank.Name = "teamGamesRank";
            this.teamGamesRank.ReadOnly = true;
            this.teamGamesRank.RowHeadersWidth = 51;
            this.teamGamesRank.RowTemplate.Height = 24;
            this.teamGamesRank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teamGamesRank.Size = new System.Drawing.Size(575, 198);
            this.teamGamesRank.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "队伍项目排名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noticeLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.accType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 285);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登入";
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
            this.groupBox2.Location = new System.Drawing.Point(330, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 525);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "积分榜";
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.Location = new System.Drawing.Point(16, 231);
            this.noticeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(0, 29);
            this.noticeLabel.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 581);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

