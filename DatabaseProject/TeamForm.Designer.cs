﻿
namespace DatabaseProject
{
    partial class TeamForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1700, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "代表队页面";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1532, 1789);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 149);
            this.button1.TabIndex = 1;
            this.button1.Text = "登出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(2048, 1789);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(332, 149);
            this.button2.TabIndex = 19;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 49);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 49);
            this.textBox2.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(221, 277);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(484, 49);
            this.textBox4.TabIndex = 23;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("男");
            this.domainUpDown1.Items.Add("女");
            this.domainUpDown1.Location = new System.Drawing.Point(221, 386);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 49);
            this.domainUpDown1.TabIndex = 25;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("运动员");
            this.domainUpDown2.Items.Add("教练");
            this.domainUpDown2.Items.Add("领队");
            this.domainUpDown2.Items.Add("裁判");
            this.domainUpDown2.Location = new System.Drawing.Point(221, 488);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(120, 49);
            this.domainUpDown2.TabIndex = 26;
            this.domainUpDown2.Text = "domainUpDown2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(901, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(915, 578);
            this.dataGridView1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 42);
            this.label2.TabIndex = 29;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 42);
            this.label3.TabIndex = 30;
            this.label3.Text = "身份证号";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 42);
            this.label4.TabIndex = 31;
            this.label4.Text = "电话号码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 42);
            this.label5.TabIndex = 32;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 42);
            this.label6.TabIndex = 33;
            this.label6.Text = "职位";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(884, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(915, 578);
            this.dataGridView2.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(204, 267);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(484, 49);
            this.textBox5.TabIndex = 39;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(204, 167);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(484, 49);
            this.textBox6.TabIndex = 40;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(204, 65);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(484, 49);
            this.textBox7.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 42);
            this.label9.TabIndex = 42;
            this.label9.Text = "年龄";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 42);
            this.label11.TabIndex = 44;
            this.label11.Text = "身份证号";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 42);
            this.label12.TabIndex = 45;
            this.label12.Text = "姓名";
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Items.Add("男");
            this.domainUpDown3.Items.Add("女");
            this.domainUpDown3.Location = new System.Drawing.Point(204, 371);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(120, 49);
            this.domainUpDown3.TabIndex = 48;
            this.domainUpDown3.Text = "domainUpDown3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 42);
            this.label14.TabIndex = 49;
            this.label14.Text = "性别";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.domainUpDown2);
            this.groupBox1.Controls.Add(this.domainUpDown1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(25, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1839, 694);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "非运动员";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.domainUpDown3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox2.Location = new System.Drawing.Point(1905, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1821, 697);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运动员";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(1050, 888);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1625, 845);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "运动员报名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "项目";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 32);
            this.label8.TabIndex = 47;
            this.label8.Text = "组别";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(330, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(484, 38);
            this.textBox3.TabIndex = 48;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(330, 162);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(484, 38);
            this.textBox8.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 42);
            this.label10.TabIndex = 50;
            this.label10.Text = "运动员号";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3822, 1985);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
    }
}