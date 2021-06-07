
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
            this.nonAthleteName = new System.Windows.Forms.TextBox();
            this.nonAthleteIdNo = new System.Windows.Forms.TextBox();
            this.nonAthletePhone = new System.Windows.Forms.TextBox();
            this.nonAthleteGenderUpDown = new System.Windows.Forms.DomainUpDown();
            this.nonAthleteAccType = new System.Windows.Forms.DomainUpDown();
            this.nonAthleteInfoGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.athleteInfoGrid = new System.Windows.Forms.DataGridView();
            this.athleteId = new System.Windows.Forms.TextBox();
            this.athleteName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.athleteGenderUpDown = new System.Windows.Forms.DomainUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noticeLabelNonAthlete = new System.Windows.Forms.Label();
            this.addNonAthleteInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.athleteAge = new System.Windows.Forms.NumericUpDown();
            this.addAthlete = new System.Windows.Forms.Button();
            this.noticeLabelAthlete = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.noticeLabelParticipate = new System.Windows.Forms.Label();
            this.participatesInfoGrid = new System.Windows.Forms.DataGridView();
            this.participates = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.participatesAthleteNo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gameTypeUpDown = new System.Windows.Forms.DomainUpDown();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nonAthleteInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteInfoGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.athleteAge)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participatesInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "代表队页面";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1523, 772);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "登出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(1384, 1113);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 77);
            this.button2.TabIndex = 19;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nonAthleteName
            // 
            this.nonAthleteName.Location = new System.Drawing.Point(132, 43);
            this.nonAthleteName.Margin = new System.Windows.Forms.Padding(2);
            this.nonAthleteName.Name = "nonAthleteName";
            this.nonAthleteName.Size = new System.Drawing.Size(157, 28);
            this.nonAthleteName.TabIndex = 20;
            // 
            // nonAthleteIdNo
            // 
            this.nonAthleteIdNo.Location = new System.Drawing.Point(132, 91);
            this.nonAthleteIdNo.Margin = new System.Windows.Forms.Padding(2);
            this.nonAthleteIdNo.Name = "nonAthleteIdNo";
            this.nonAthleteIdNo.Size = new System.Drawing.Size(157, 28);
            this.nonAthleteIdNo.TabIndex = 21;
            // 
            // nonAthletePhone
            // 
            this.nonAthletePhone.Location = new System.Drawing.Point(132, 145);
            this.nonAthletePhone.Margin = new System.Windows.Forms.Padding(2);
            this.nonAthletePhone.Name = "nonAthletePhone";
            this.nonAthletePhone.Size = new System.Drawing.Size(157, 28);
            this.nonAthletePhone.TabIndex = 23;
            // 
            // nonAthleteGenderUpDown
            // 
            this.nonAthleteGenderUpDown.Items.Add("男");
            this.nonAthleteGenderUpDown.Items.Add("女");
            this.nonAthleteGenderUpDown.Location = new System.Drawing.Point(132, 198);
            this.nonAthleteGenderUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.nonAthleteGenderUpDown.Name = "nonAthleteGenderUpDown";
            this.nonAthleteGenderUpDown.Size = new System.Drawing.Size(157, 28);
            this.nonAthleteGenderUpDown.TabIndex = 25;
            this.nonAthleteGenderUpDown.Text = "选择性别";
            // 
            // nonAthleteAccType
            // 
            this.nonAthleteAccType.Items.Add("教练");
            this.nonAthleteAccType.Items.Add("领队");
            this.nonAthleteAccType.Items.Add("队医");
            this.nonAthleteAccType.Location = new System.Drawing.Point(132, 251);
            this.nonAthleteAccType.Margin = new System.Windows.Forms.Padding(2);
            this.nonAthleteAccType.Name = "nonAthleteAccType";
            this.nonAthleteAccType.Size = new System.Drawing.Size(157, 28);
            this.nonAthleteAccType.TabIndex = 26;
            this.nonAthleteAccType.Text = "选择职位";
            // 
            // nonAthleteInfoGrid
            // 
            this.nonAthleteInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.nonAthleteInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonAthleteInfoGrid.Location = new System.Drawing.Point(306, 33);
            this.nonAthleteInfoGrid.Margin = new System.Windows.Forms.Padding(2);
            this.nonAthleteInfoGrid.Name = "nonAthleteInfoGrid";
            this.nonAthleteInfoGrid.ReadOnly = true;
            this.nonAthleteInfoGrid.RowHeadersWidth = 4;
            this.nonAthleteInfoGrid.RowTemplate.Height = 40;
            this.nonAthleteInfoGrid.Size = new System.Drawing.Size(488, 298);
            this.nonAthleteInfoGrid.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "身份证号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "电话号码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "职位";
            // 
            // athleteInfoGrid
            // 
            this.athleteInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.athleteInfoGrid.Location = new System.Drawing.Point(403, 32);
            this.athleteInfoGrid.Margin = new System.Windows.Forms.Padding(2);
            this.athleteInfoGrid.Name = "athleteInfoGrid";
            this.athleteInfoGrid.ReadOnly = true;
            this.athleteInfoGrid.RowHeadersWidth = 4;
            this.athleteInfoGrid.RowTemplate.Height = 40;
            this.athleteInfoGrid.Size = new System.Drawing.Size(761, 298);
            this.athleteInfoGrid.TabIndex = 36;
            // 
            // athleteId
            // 
            this.athleteId.Location = new System.Drawing.Point(132, 74);
            this.athleteId.Margin = new System.Windows.Forms.Padding(2);
            this.athleteId.Name = "athleteId";
            this.athleteId.Size = new System.Drawing.Size(244, 28);
            this.athleteId.TabIndex = 40;
            // 
            // athleteName
            // 
            this.athleteName.Location = new System.Drawing.Point(132, 32);
            this.athleteName.Margin = new System.Windows.Forms.Padding(2);
            this.athleteName.Name = "athleteName";
            this.athleteName.Size = new System.Drawing.Size(244, 28);
            this.athleteName.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "年龄";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 44;
            this.label11.Text = "身份证号";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 24);
            this.label12.TabIndex = 45;
            this.label12.Text = "姓名";
            // 
            // athleteGenderUpDown
            // 
            this.athleteGenderUpDown.Items.Add("男");
            this.athleteGenderUpDown.Items.Add("女");
            this.athleteGenderUpDown.Location = new System.Drawing.Point(132, 158);
            this.athleteGenderUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.athleteGenderUpDown.Name = "athleteGenderUpDown";
            this.athleteGenderUpDown.Size = new System.Drawing.Size(244, 28);
            this.athleteGenderUpDown.TabIndex = 48;
            this.athleteGenderUpDown.Text = "选择性别";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 163);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 24);
            this.label14.TabIndex = 49;
            this.label14.Text = "性别";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noticeLabelNonAthlete);
            this.groupBox1.Controls.Add(this.addNonAthleteInfo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nonAthleteInfoGrid);
            this.groupBox1.Controls.Add(this.nonAthleteAccType);
            this.groupBox1.Controls.Add(this.nonAthleteGenderUpDown);
            this.groupBox1.Controls.Add(this.nonAthletePhone);
            this.groupBox1.Controls.Add(this.nonAthleteIdNo);
            this.groupBox1.Controls.Add(this.nonAthleteName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(815, 358);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "其他人员登记";
            // 
            // noticeLabelNonAthlete
            // 
            this.noticeLabelNonAthlete.AutoSize = true;
            this.noticeLabelNonAthlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabelNonAthlete.Location = new System.Drawing.Point(154, 302);
            this.noticeLabelNonAthlete.Name = "noticeLabelNonAthlete";
            this.noticeLabelNonAthlete.Size = new System.Drawing.Size(15, 24);
            this.noticeLabelNonAthlete.TabIndex = 53;
            this.noticeLabelNonAthlete.Text = ".";
            // 
            // addNonAthleteInfo
            // 
            this.addNonAthleteInfo.Location = new System.Drawing.Point(18, 296);
            this.addNonAthleteInfo.Name = "addNonAthleteInfo";
            this.addNonAthleteInfo.Size = new System.Drawing.Size(121, 44);
            this.addNonAthleteInfo.TabIndex = 53;
            this.addNonAthleteInfo.Text = "提交";
            this.addNonAthleteInfo.UseVisualStyleBackColor = true;
            this.addNonAthleteInfo.Click += new System.EventHandler(this.addNonAthleteInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.athleteAge);
            this.groupBox2.Controls.Add(this.addAthlete);
            this.groupBox2.Controls.Add(this.noticeLabelAthlete);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.athleteGenderUpDown);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.athleteName);
            this.groupBox2.Controls.Add(this.athleteId);
            this.groupBox2.Controls.Add(this.athleteInfoGrid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 471);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1177, 360);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运动员登记";
            // 
            // athleteAge
            // 
            this.athleteAge.Location = new System.Drawing.Point(132, 116);
            this.athleteAge.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.athleteAge.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.athleteAge.Name = "athleteAge";
            this.athleteAge.Size = new System.Drawing.Size(244, 28);
            this.athleteAge.TabIndex = 55;
            this.athleteAge.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // addAthlete
            // 
            this.addAthlete.Location = new System.Drawing.Point(18, 267);
            this.addAthlete.Name = "addAthlete";
            this.addAthlete.Size = new System.Drawing.Size(121, 44);
            this.addAthlete.TabIndex = 54;
            this.addAthlete.Text = "提交";
            this.addAthlete.UseVisualStyleBackColor = true;
            this.addAthlete.Click += new System.EventHandler(this.addAthlete_Click);
            // 
            // noticeLabelAthlete
            // 
            this.noticeLabelAthlete.AutoSize = true;
            this.noticeLabelAthlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabelAthlete.Location = new System.Drawing.Point(14, 206);
            this.noticeLabelAthlete.Name = "noticeLabelAthlete";
            this.noticeLabelAthlete.Size = new System.Drawing.Size(15, 24);
            this.noticeLabelAthlete.TabIndex = 54;
            this.noticeLabelAthlete.Text = ".";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.noticeLabelParticipate);
            this.groupBox3.Controls.Add(this.participatesInfoGrid);
            this.groupBox3.Controls.Add(this.participates);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.participatesAthleteNo);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.gameTypeUpDown);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(830, 85);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(832, 360);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "运动员报名";
            // 
            // noticeLabelParticipate
            // 
            this.noticeLabelParticipate.AutoSize = true;
            this.noticeLabelParticipate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabelParticipate.Location = new System.Drawing.Point(17, 243);
            this.noticeLabelParticipate.Name = "noticeLabelParticipate";
            this.noticeLabelParticipate.Size = new System.Drawing.Size(15, 24);
            this.noticeLabelParticipate.TabIndex = 54;
            this.noticeLabelParticipate.Text = ".";
            // 
            // participatesInfoGrid
            // 
            this.participatesInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participatesInfoGrid.Location = new System.Drawing.Point(379, 26);
            this.participatesInfoGrid.Margin = new System.Windows.Forms.Padding(2);
            this.participatesInfoGrid.Name = "participatesInfoGrid";
            this.participatesInfoGrid.ReadOnly = true;
            this.participatesInfoGrid.RowHeadersWidth = 4;
            this.participatesInfoGrid.RowTemplate.Height = 40;
            this.participatesInfoGrid.Size = new System.Drawing.Size(429, 302);
            this.participatesInfoGrid.TabIndex = 55;
            // 
            // participates
            // 
            this.participates.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participates.Location = new System.Drawing.Point(21, 185);
            this.participates.Name = "participates";
            this.participates.Size = new System.Drawing.Size(124, 38);
            this.participates.TabIndex = 53;
            this.participates.Text = "报名";
            this.participates.UseVisualStyleBackColor = true;
            this.participates.Click += new System.EventHandler(this.participates_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 29);
            this.label7.TabIndex = 61;
            this.label7.Text = "运动员号";
            // 
            // participatesAthleteNo
            // 
            this.participatesAthleteNo.Location = new System.Drawing.Point(21, 143);
            this.participatesAthleteNo.Margin = new System.Windows.Forms.Padding(2);
            this.participatesAthleteNo.Name = "participatesAthleteNo";
            this.participatesAthleteNo.Size = new System.Drawing.Size(244, 28);
            this.participatesAthleteNo.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 29);
            this.label16.TabIndex = 58;
            this.label16.Text = "项目";
            // 
            // gameTypeUpDown
            // 
            this.gameTypeUpDown.Items.Add("蹦床");
            this.gameTypeUpDown.Items.Add("吊环");
            this.gameTypeUpDown.Items.Add("双杠");
            this.gameTypeUpDown.Items.Add("高低杠");
            this.gameTypeUpDown.Items.Add("自由体操");
            this.gameTypeUpDown.Items.Add("跳马");
            this.gameTypeUpDown.Items.Add("单杠");
            this.gameTypeUpDown.Items.Add("平衡木");
            this.gameTypeUpDown.Items.Add("鞍马");
            this.gameTypeUpDown.Location = new System.Drawing.Point(21, 81);
            this.gameTypeUpDown.Name = "gameTypeUpDown";
            this.gameTypeUpDown.Size = new System.Drawing.Size(244, 28);
            this.gameTypeUpDown.TabIndex = 55;
            this.gameTypeUpDown.Text = "选择项目";
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1193, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 192);
            this.label8.TabIndex = 62;
            this.label8.Text = "男运动员可报项目：\r\n单杠\r\n双杠\r\n吊环\r\n跳马\r\n自由体操\r\n鞍马\r\n蹦床";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1416, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 144);
            this.label10.TabIndex = 63;
            this.label10.Text = "女运动员可报项目：\r\n跳马\r\n高低杠\r\n平衡木\r\n自由体操\r\n蹦床\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 925);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1700, 1500);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nonAthleteInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteInfoGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.athleteAge)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participatesInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nonAthleteName;
        private System.Windows.Forms.TextBox nonAthleteIdNo;
        private System.Windows.Forms.TextBox nonAthletePhone;
        private System.Windows.Forms.DomainUpDown nonAthleteGenderUpDown;
        private System.Windows.Forms.DomainUpDown nonAthleteAccType;
        private System.Windows.Forms.DataGridView nonAthleteInfoGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView athleteInfoGrid;
        private System.Windows.Forms.TextBox athleteId;
        private System.Windows.Forms.TextBox athleteName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DomainUpDown athleteGenderUpDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addNonAthleteInfo;
        private System.Windows.Forms.Label noticeLabelNonAthlete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox participatesAthleteNo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DomainUpDown gameTypeUpDown;
        private System.Windows.Forms.Button addAthlete;
        private System.Windows.Forms.Label noticeLabelAthlete;
        private System.Windows.Forms.Button participates;
        private System.Windows.Forms.DataGridView participatesInfoGrid;
        private System.Windows.Forms.NumericUpDown athleteAge;
        private System.Windows.Forms.Label noticeLabelParticipate;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}