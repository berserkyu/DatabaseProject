
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
            this.button1 = new System.Windows.Forms.Button();
            this.scoreBoard = new System.Windows.Forms.DataGridView();
            this.curGameLabel = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.isFinal = new System.Windows.Forms.CheckBox();
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
            this.logOut.Location = new System.Drawing.Point(271, 547);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(84, 49);
            this.logOut.TabIndex = 1;
            this.logOut.Text = "登出";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreBoard
            // 
            this.scoreBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreBoard.Location = new System.Drawing.Point(19, 92);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.RowHeadersWidth = 51;
            this.scoreBoard.RowTemplate.Height = 24;
            this.scoreBoard.Size = new System.Drawing.Size(336, 356);
            this.scoreBoard.TabIndex = 27;
            // 
            // curGameLabel
            // 
            this.curGameLabel.AutoSize = true;
            this.curGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curGameLabel.Location = new System.Drawing.Point(15, 69);
            this.curGameLabel.Name = "curGameLabel";
            this.curGameLabel.Size = new System.Drawing.Size(13, 20);
            this.curGameLabel.TabIndex = 28;
            this.curGameLabel.Text = ".";
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(19, 509);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(167, 49);
            this.refresh.TabIndex = 29;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // isFinal
            // 
            this.isFinal.AutoSize = true;
            this.isFinal.Location = new System.Drawing.Point(19, 565);
            this.isFinal.Name = "isFinal";
            this.isFinal.Size = new System.Drawing.Size(58, 21);
            this.isFinal.TabIndex = 30;
            this.isFinal.Text = "决赛";
            this.isFinal.UseVisualStyleBackColor = true;
            // 
            // JudgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 608);
            this.Controls.Add(this.isFinal);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.curGameLabel);
            this.Controls.Add(this.scoreBoard);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView scoreBoard;
        private System.Windows.Forms.Label curGameLabel;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.CheckBox isFinal;
    }
}