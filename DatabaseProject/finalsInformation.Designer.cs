
namespace DatabaseProject
{
    partial class finalsInformation
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
            this.finalsSchedule = new System.Windows.Forms.DataGridView();
            this.noticeLab = new System.Windows.Forms.Label();
            this.finalsParticipation = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.showFinals = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finalsSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalsParticipation)).BeginInit();
            this.SuspendLayout();
            // 
            // finalsSchedule
            // 
            this.finalsSchedule.BackgroundColor = System.Drawing.SystemColors.Window;
            this.finalsSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finalsSchedule.Location = new System.Drawing.Point(13, 98);
            this.finalsSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finalsSchedule.Name = "finalsSchedule";
            this.finalsSchedule.ReadOnly = true;
            this.finalsSchedule.RowHeadersWidth = 51;
            this.finalsSchedule.RowTemplate.Height = 24;
            this.finalsSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finalsSchedule.Size = new System.Drawing.Size(780, 244);
            this.finalsSchedule.TabIndex = 19;
            // 
            // noticeLab
            // 
            this.noticeLab.AutoSize = true;
            this.noticeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLab.Location = new System.Drawing.Point(212, 693);
            this.noticeLab.Name = "noticeLab";
            this.noticeLab.Size = new System.Drawing.Size(19, 29);
            this.noticeLab.TabIndex = 20;
            this.noticeLab.Text = ".";
            // 
            // finalsParticipation
            // 
            this.finalsParticipation.BackgroundColor = System.Drawing.SystemColors.Window;
            this.finalsParticipation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finalsParticipation.Location = new System.Drawing.Point(12, 393);
            this.finalsParticipation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finalsParticipation.Name = "finalsParticipation";
            this.finalsParticipation.ReadOnly = true;
            this.finalsParticipation.RowHeadersWidth = 51;
            this.finalsParticipation.RowTemplate.Height = 24;
            this.finalsParticipation.Size = new System.Drawing.Size(780, 244);
            this.finalsParticipation.TabIndex = 21;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 663);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(102, 59);
            this.refresh.TabIndex = 22;
            this.refresh.Text = "刷新";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // showFinals
            // 
            this.showFinals.AutoSize = true;
            this.showFinals.Location = new System.Drawing.Point(120, 701);
            this.showFinals.Name = "showFinals";
            this.showFinals.Size = new System.Drawing.Size(86, 21);
            this.showFinals.TabIndex = 23;
            this.showFinals.Text = "显示决赛";
            this.showFinals.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "赛程页面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "赛程：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "选手参赛信息：";
            // 
            // finalsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showFinals);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.finalsParticipation);
            this.Controls.Add(this.noticeLab);
            this.Controls.Add(this.finalsSchedule);
            this.Name = "finalsInformation";
            this.Text = "finalsInformation";
            this.Load += new System.EventHandler(this.finalsInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalsSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalsParticipation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView finalsSchedule;
        private System.Windows.Forms.Label noticeLab;
        private System.Windows.Forms.DataGridView finalsParticipation;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.CheckBox showFinals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}