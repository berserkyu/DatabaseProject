
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
            this.scoreBoard = new System.Windows.Forms.DataGridView();
            this.pass_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.D_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.P_textBox = new System.Windows.Forms.TextBox();
            this.finalScoreBoard = new System.Windows.Forms.DataGridView();
            this.not_pass_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.judgeAccNo_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gameLabel = new System.Windows.Forms.Label();
            this.isFinal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalScoreBoard)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.logOut.Location = new System.Drawing.Point(19, 468);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(94, 38);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "登出";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreBoard
            // 
            this.scoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreBoard.Location = new System.Drawing.Point(503, 12);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.RowHeadersWidth = 51;
            this.scoreBoard.RowTemplate.Height = 24;
            this.scoreBoard.Size = new System.Drawing.Size(606, 240);
            this.scoreBoard.TabIndex = 3;
            // 
            // pass_Button
            // 
            this.pass_Button.Location = new System.Drawing.Point(223, 196);
            this.pass_Button.Name = "pass_Button";
            this.pass_Button.Size = new System.Drawing.Size(124, 37);
            this.pass_Button.TabIndex = 4;
            this.pass_Button.Text = "通过";
            this.pass_Button.UseVisualStyleBackColor = true;
            this.pass_Button.Click += new System.EventHandler(this.pass_Button_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "奖励分(D)：";
            // 
            // D_textBox
            // 
            this.D_textBox.Location = new System.Drawing.Point(341, 61);
            this.D_textBox.Name = "D_textBox";
            this.D_textBox.Size = new System.Drawing.Size(86, 30);
            this.D_textBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "惩罚分(P)：";
            // 
            // P_textBox
            // 
            this.P_textBox.Location = new System.Drawing.Point(342, 107);
            this.P_textBox.Name = "P_textBox";
            this.P_textBox.Size = new System.Drawing.Size(85, 30);
            this.P_textBox.TabIndex = 14;
            // 
            // finalScoreBoard
            // 
            this.finalScoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finalScoreBoard.Location = new System.Drawing.Point(503, 267);
            this.finalScoreBoard.Name = "finalScoreBoard";
            this.finalScoreBoard.RowHeadersWidth = 51;
            this.finalScoreBoard.RowTemplate.Height = 24;
            this.finalScoreBoard.Size = new System.Drawing.Size(606, 231);
            this.finalScoreBoard.TabIndex = 17;
            // 
            // not_pass_button
            // 
            this.not_pass_button.Location = new System.Drawing.Point(223, 239);
            this.not_pass_button.Name = "not_pass_button";
            this.not_pass_button.Size = new System.Drawing.Size(124, 37);
            this.not_pass_button.TabIndex = 20;
            this.not_pass_button.Text = "重新打分";
            this.not_pass_button.UseVisualStyleBackColor = true;
            this.not_pass_button.Click += new System.EventHandler(this.not_pass_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "需重新打分的裁判账号：";
            // 
            // judgeAccNo_textBox
            // 
            this.judgeAccNo_textBox.Location = new System.Drawing.Point(20, 61);
            this.judgeAccNo_textBox.Multiline = true;
            this.judgeAccNo_textBox.Name = "judgeAccNo_textBox";
            this.judgeAccNo_textBox.Size = new System.Drawing.Size(192, 280);
            this.judgeAccNo_textBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isFinal);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.gameLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.judgeAccNo_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pass_Button);
            this.groupBox1.Controls.Add(this.P_textBox);
            this.groupBox1.Controls.Add(this.not_pass_button);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.D_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 368);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分数裁决";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(218, 152);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(17, 25);
            this.gameLabel.TabIndex = 23;
            this.gameLabel.Text = ".";
            // 
            // isFinal
            // 
            this.isFinal.AutoSize = true;
            this.isFinal.Location = new System.Drawing.Point(223, 325);
            this.isFinal.Name = "isFinal";
            this.isFinal.Size = new System.Drawing.Size(74, 29);
            this.isFinal.TabIndex = 25;
            this.isFinal.Text = "决赛";
            this.isFinal.UseVisualStyleBackColor = true;
            // 
            // MainJudgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1121, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.finalScoreBoard);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label1);
            this.Name = "MainJudgeForm";
            this.Text = "MainJudgeForm";
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalScoreBoard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView scoreBoard;
        private System.Windows.Forms.Button pass_Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox D_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox P_textBox;
        private System.Windows.Forms.DataGridView finalScoreBoard;
        private System.Windows.Forms.Button not_pass_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox judgeAccNo_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox isFinal;
    }
}