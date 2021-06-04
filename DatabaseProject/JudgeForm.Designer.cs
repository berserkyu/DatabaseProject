
namespace DatabaseProject
{
    partial class JudgeForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.athleteNo_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tournamentId_label = new System.Windows.Forms.Label();
            this.scoreBoard = new System.Windows.Forms.DataGridView();
            this.curGameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "小组裁判页面";
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(244, 9);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(84, 38);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "登出";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(897, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "给分：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(896, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "编号：";
            // 
            // athleteNo_label
            // 
            this.athleteNo_label.AutoSize = true;
            this.athleteNo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athleteNo_label.Location = new System.Drawing.Point(994, 177);
            this.athleteNo_label.Name = "athleteNo_label";
            this.athleteNo_label.Size = new System.Drawing.Size(0, 20);
            this.athleteNo_label.TabIndex = 21;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(994, 138);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(0, 20);
            this.name_label.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(896, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "运动员信息";
            // 
            // score_textBox
            // 
            this.score_textBox.Location = new System.Drawing.Point(982, 252);
            this.score_textBox.Name = "score_textBox";
            this.score_textBox.Size = new System.Drawing.Size(100, 22);
            this.score_textBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(897, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "场次：";
            // 
            // tournamentId_label
            // 
            this.tournamentId_label.AutoSize = true;
            this.tournamentId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentId_label.Location = new System.Drawing.Point(994, 214);
            this.tournamentId_label.Name = "tournamentId_label";
            this.tournamentId_label.Size = new System.Drawing.Size(0, 20);
            this.tournamentId_label.TabIndex = 25;
            // 
            // scoreBoard
            // 
            this.scoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreBoard.Location = new System.Drawing.Point(19, 110);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.RowHeadersWidth = 51;
            this.scoreBoard.RowTemplate.Height = 24;
            this.scoreBoard.Size = new System.Drawing.Size(801, 178);
            this.scoreBoard.TabIndex = 27;
            // 
            // curGameLabel
            // 
            this.curGameLabel.AutoSize = true;
            this.curGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curGameLabel.Location = new System.Drawing.Point(19, 60);
            this.curGameLabel.Name = "curGameLabel";
            this.curGameLabel.Size = new System.Drawing.Size(64, 25);
            this.curGameLabel.TabIndex = 28;
            this.curGameLabel.Text = "label4";
            // 
            // JudgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 407);
            this.Controls.Add(this.curGameLabel);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tournamentId_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.athleteNo_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.score_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.label1);
            this.Name = "JudgeForm";
            this.Text = "JudgeForm";
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label athleteNo_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox score_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label tournamentId_label;
        private System.Windows.Forms.DataGridView scoreBoard;
        private System.Windows.Forms.Label curGameLabel;
    }
}