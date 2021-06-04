
namespace DatabaseProject
{
    partial class MainJudgeForm
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
            this.logOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pass_Button = new System.Windows.Forms.Button();
            this.score_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.athleteNo_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.D_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.P_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tournamentId_label = new System.Windows.Forms.Label();
            this.not_pass_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.judgeAccNo_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "小组总裁判页面";
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(278, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(94, 38);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "登出";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(503, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // pass_Button
            // 
            this.pass_Button.Location = new System.Drawing.Point(260, 144);
            this.pass_Button.Name = "pass_Button";
            this.pass_Button.Size = new System.Drawing.Size(92, 37);
            this.pass_Button.TabIndex = 4;
            this.pass_Button.Text = "通过";
            this.pass_Button.UseVisualStyleBackColor = true;
            this.pass_Button.Click += new System.EventHandler(this.pass_Button_Click);
            // 
            // score_textBox
            // 
            this.score_textBox.Location = new System.Drawing.Point(126, 263);
            this.score_textBox.Name = "score_textBox";
            this.score_textBox.Size = new System.Drawing.Size(85, 22);
            this.score_textBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "运动员信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "名称：";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(123, 144);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(0, 20);
            this.name_label.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "编号：";
            // 
            // athleteNo_label
            // 
            this.athleteNo_label.AutoSize = true;
            this.athleteNo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athleteNo_label.Location = new System.Drawing.Point(123, 185);
            this.athleteNo_label.Name = "athleteNo_label";
            this.athleteNo_label.Size = new System.Drawing.Size(0, 20);
            this.athleteNo_label.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "给分：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "奖励分(D)：";
            // 
            // D_textBox
            // 
            this.D_textBox.Location = new System.Drawing.Point(126, 309);
            this.D_textBox.Name = "D_textBox";
            this.D_textBox.Size = new System.Drawing.Size(86, 22);
            this.D_textBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "惩罚分(P)：";
            // 
            // P_textBox
            // 
            this.P_textBox.Location = new System.Drawing.Point(126, 355);
            this.P_textBox.Name = "P_textBox";
            this.P_textBox.Size = new System.Drawing.Size(85, 22);
            this.P_textBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "是否需要重新打分";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(503, 267);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(606, 231);
            this.dataGridView2.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "场次：";
            // 
            // tournamentId_label
            // 
            this.tournamentId_label.AutoSize = true;
            this.tournamentId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentId_label.Location = new System.Drawing.Point(123, 220);
            this.tournamentId_label.Name = "tournamentId_label";
            this.tournamentId_label.Size = new System.Drawing.Size(0, 20);
            this.tournamentId_label.TabIndex = 18;
            // 
            // not_pass_button
            // 
            this.not_pass_button.Location = new System.Drawing.Point(358, 144);
            this.not_pass_button.Name = "not_pass_button";
            this.not_pass_button.Size = new System.Drawing.Size(94, 37);
            this.not_pass_button.TabIndex = 20;
            this.not_pass_button.Text = "重新打分";
            this.not_pass_button.UseVisualStyleBackColor = true;
            this.not_pass_button.Click += new System.EventHandler(this.not_pass_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "裁判账号：";
            // 
            // judgeAccNo_textBox
            // 
            this.judgeAccNo_textBox.Location = new System.Drawing.Point(260, 251);
            this.judgeAccNo_textBox.Multiline = true;
            this.judgeAccNo_textBox.Name = "judgeAccNo_textBox";
            this.judgeAccNo_textBox.Size = new System.Drawing.Size(192, 32);
            this.judgeAccNo_textBox.TabIndex = 22;
            // 
            // MainJudgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 519);
            this.Controls.Add(this.judgeAccNo_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.not_pass_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tournamentId_label);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.P_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.D_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.athleteNo_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.score_textBox);
            this.Controls.Add(this.pass_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label1);
            this.Name = "MainJudgeForm";
            this.Text = "MainJudgeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pass_Button;
        private System.Windows.Forms.TextBox score_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label athleteNo_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox D_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox P_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tournamentId_label;
        private System.Windows.Forms.Button not_pass_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox judgeAccNo_textBox;
    }
}