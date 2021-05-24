
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
            ((System.ComponentModel.ISupportInitialize)(this.finalsSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalsParticipation)).BeginInit();
            this.SuspendLayout();
            // 
            // finalsSchedule
            // 
            this.finalsSchedule.BackgroundColor = System.Drawing.SystemColors.Window;
            this.finalsSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finalsSchedule.Location = new System.Drawing.Point(12, 145);
            this.finalsSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finalsSchedule.Name = "finalsSchedule";
            this.finalsSchedule.ReadOnly = true;
            this.finalsSchedule.RowHeadersWidth = 51;
            this.finalsSchedule.RowTemplate.Height = 24;
            this.finalsSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finalsSchedule.Size = new System.Drawing.Size(376, 244);
            this.finalsSchedule.TabIndex = 19;
            // 
            // noticeLab
            // 
            this.noticeLab.AutoSize = true;
            this.noticeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLab.Location = new System.Drawing.Point(299, 35);
            this.noticeLab.Name = "noticeLab";
            this.noticeLab.Size = new System.Drawing.Size(79, 29);
            this.noticeLab.TabIndex = 20;
            this.noticeLab.Text = "label1";
            // 
            // finalsParticipation
            // 
            this.finalsParticipation.BackgroundColor = System.Drawing.SystemColors.Window;
            this.finalsParticipation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finalsParticipation.Location = new System.Drawing.Point(394, 145);
            this.finalsParticipation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finalsParticipation.Name = "finalsParticipation";
            this.finalsParticipation.ReadOnly = true;
            this.finalsParticipation.RowHeadersWidth = 51;
            this.finalsParticipation.RowTemplate.Height = 24;
            this.finalsParticipation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finalsParticipation.Size = new System.Drawing.Size(376, 244);
            this.finalsParticipation.TabIndex = 21;
            // 
            // finalsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}