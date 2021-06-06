
namespace DatabaseProject
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowPW = new System.Windows.Forms.CheckBox();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.accInfoGridView = new System.Windows.Forms.DataGridView();
            this.refreshAccInfo = new System.Windows.Forms.Button();
            this.delAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.accType = new System.Windows.Forms.DomainUpDown();
            this.addAcc = new System.Windows.Forms.Button();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.delFromSchedule = new System.Windows.Forms.GroupBox();
            this.noticeLabelSchedule = new System.Windows.Forms.Label();
            this.delSchedule = new System.Windows.Forms.Button();
            this.noticeLabel1 = new System.Windows.Forms.Label();
            this.refreshSchedule = new System.Windows.Forms.Button();
            this.scheduleGridView = new System.Windows.Forms.DataGridView();
            this.addToSchedule = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.arrangementUpDown = new System.Windows.Forms.NumericUpDown();
            this.ageGroupUpDown = new System.Windows.Forms.DomainUpDown();
            this.genderUpDown = new System.Windows.Forms.DomainUpDown();
            this.gameTypeUpDown = new System.Windows.Forms.DomainUpDown();
            this.npgsqlCommand2 = new Npgsql.NpgsqlCommand();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.judgesInfoGrid = new System.Windows.Forms.DataGridView();
            this.addJudgeToGame = new System.Windows.Forms.Button();
            this.judgeAccNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gameToJudge = new System.Windows.Forms.TextBox();
            this.noticeLabelAddJudge = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accInfoGridView)).BeginInit();
            this.delFromSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrangementUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.judgesInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员页面";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(943, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "登出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxShowPW);
            this.groupBox1.Controls.Add(this.noticeLabel);
            this.groupBox1.Controls.Add(this.accInfoGridView);
            this.groupBox1.Controls.Add(this.refreshAccInfo);
            this.groupBox1.Controls.Add(this.delAcc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.accType);
            this.groupBox1.Controls.Add(this.addAcc);
            this.groupBox1.Controls.Add(this.passWord);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.accNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 307);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账号管理";
            // 
            // checkBoxShowPW
            // 
            this.checkBoxShowPW.AutoSize = true;
            this.checkBoxShowPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPW.Location = new System.Drawing.Point(272, 202);
            this.checkBoxShowPW.Name = "checkBoxShowPW";
            this.checkBoxShowPW.Size = new System.Drawing.Size(114, 29);
            this.checkBoxShowPW.TabIndex = 13;
            this.checkBoxShowPW.Text = "显示密码";
            this.checkBoxShowPW.UseVisualStyleBackColor = true;
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.Location = new System.Drawing.Point(27, 188);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(78, 29);
            this.noticeLabel.TabIndex = 12;
            this.noticeLabel.Text = "notice";
            // 
            // accInfoGridView
            // 
            this.accInfoGridView.AllowUserToAddRows = false;
            this.accInfoGridView.AllowUserToDeleteRows = false;
            this.accInfoGridView.AllowUserToOrderColumns = true;
            this.accInfoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accInfoGridView.Location = new System.Drawing.Point(432, 33);
            this.accInfoGridView.Name = "accInfoGridView";
            this.accInfoGridView.ReadOnly = true;
            this.accInfoGridView.RowHeadersWidth = 51;
            this.accInfoGridView.RowTemplate.Height = 24;
            this.accInfoGridView.Size = new System.Drawing.Size(458, 257);
            this.accInfoGridView.TabIndex = 5;
            // 
            // refreshAccInfo
            // 
            this.refreshAccInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshAccInfo.Location = new System.Drawing.Point(269, 237);
            this.refreshAccInfo.Name = "refreshAccInfo";
            this.refreshAccInfo.Size = new System.Drawing.Size(146, 53);
            this.refreshAccInfo.TabIndex = 11;
            this.refreshAccInfo.Text = "刷新账号信息";
            this.refreshAccInfo.UseVisualStyleBackColor = true;
            this.refreshAccInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // delAcc
            // 
            this.delAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAcc.Location = new System.Drawing.Point(142, 237);
            this.delAcc.Name = "delAcc";
            this.delAcc.Size = new System.Drawing.Size(121, 53);
            this.delAcc.TabIndex = 10;
            this.delAcc.Text = "删除账号";
            this.delAcc.UseVisualStyleBackColor = true;
            this.delAcc.Click += new System.EventHandler(this.delAcc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "账号类型";
            // 
            // accType
            // 
            this.accType.Items.Add("代表队");
            this.accType.Items.Add("小组裁判");
            this.accType.Items.Add("总裁判");
            this.accType.Location = new System.Drawing.Point(142, 137);
            this.accType.Name = "accType";
            this.accType.Size = new System.Drawing.Size(271, 34);
            this.accType.TabIndex = 8;
            this.accType.Text = "选择账号类型";
            // 
            // addAcc
            // 
            this.addAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAcc.Location = new System.Drawing.Point(20, 237);
            this.addAcc.Name = "addAcc";
            this.addAcc.Size = new System.Drawing.Size(116, 53);
            this.addAcc.TabIndex = 7;
            this.addAcc.Text = "新增账号";
            this.addAcc.UseVisualStyleBackColor = true;
            this.addAcc.Click += new System.EventHandler(this.addAcc_Click);
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.Location = new System.Drawing.Point(142, 97);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(244, 34);
            this.passWord.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码：";
            // 
            // accNo
            // 
            this.accNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNo.Location = new System.Drawing.Point(142, 57);
            this.accNo.Name = "accNo";
            this.accNo.Size = new System.Drawing.Size(244, 34);
            this.accNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "账号：";
            // 
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // delFromSchedule
            // 
            this.delFromSchedule.Controls.Add(this.noticeLabelSchedule);
            this.delFromSchedule.Controls.Add(this.delSchedule);
            this.delFromSchedule.Controls.Add(this.noticeLabel1);
            this.delFromSchedule.Controls.Add(this.refreshSchedule);
            this.delFromSchedule.Controls.Add(this.scheduleGridView);
            this.delFromSchedule.Controls.Add(this.addToSchedule);
            this.delFromSchedule.Controls.Add(this.label8);
            this.delFromSchedule.Controls.Add(this.label7);
            this.delFromSchedule.Controls.Add(this.label6);
            this.delFromSchedule.Controls.Add(this.label5);
            this.delFromSchedule.Controls.Add(this.arrangementUpDown);
            this.delFromSchedule.Controls.Add(this.ageGroupUpDown);
            this.delFromSchedule.Controls.Add(this.genderUpDown);
            this.delFromSchedule.Controls.Add(this.gameTypeUpDown);
            this.delFromSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delFromSchedule.Location = new System.Drawing.Point(20, 406);
            this.delFromSchedule.Name = "delFromSchedule";
            this.delFromSchedule.Size = new System.Drawing.Size(1058, 431);
            this.delFromSchedule.TabIndex = 5;
            this.delFromSchedule.TabStop = false;
            this.delFromSchedule.Text = "赛程安排";
            // 
            // noticeLabelSchedule
            // 
            this.noticeLabelSchedule.AutoSize = true;
            this.noticeLabelSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabelSchedule.Location = new System.Drawing.Point(291, 205);
            this.noticeLabelSchedule.Name = "noticeLabelSchedule";
            this.noticeLabelSchedule.Size = new System.Drawing.Size(78, 29);
            this.noticeLabelSchedule.TabIndex = 21;
            this.noticeLabelSchedule.Text = "notice";
            // 
            // delSchedule
            // 
            this.delSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delSchedule.Location = new System.Drawing.Point(227, 381);
            this.delSchedule.Name = "delSchedule";
            this.delSchedule.Size = new System.Drawing.Size(201, 34);
            this.delSchedule.TabIndex = 20;
            this.delSchedule.Text = "移除该场次比赛";
            this.delSchedule.UseVisualStyleBackColor = true;
            this.delSchedule.Click += new System.EventHandler(this.delSchedule_Click);
            // 
            // noticeLabel1
            // 
            this.noticeLabel1.AutoSize = true;
            this.noticeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel1.Location = new System.Drawing.Point(641, 386);
            this.noticeLabel1.Name = "noticeLabel1";
            this.noticeLabel1.Size = new System.Drawing.Size(78, 29);
            this.noticeLabel1.TabIndex = 14;
            this.noticeLabel1.Text = "notice";
            // 
            // refreshSchedule
            // 
            this.refreshSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshSchedule.Location = new System.Drawing.Point(432, 312);
            this.refreshSchedule.Name = "refreshSchedule";
            this.refreshSchedule.Size = new System.Drawing.Size(201, 34);
            this.refreshSchedule.TabIndex = 18;
            this.refreshSchedule.Text = "刷新当前预赛赛程表";
            this.refreshSchedule.UseVisualStyleBackColor = true;
            this.refreshSchedule.Click += new System.EventHandler(this.refreshSchedule_Click);
            // 
            // scheduleGridView
            // 
            this.scheduleGridView.AllowUserToAddRows = false;
            this.scheduleGridView.AllowUserToDeleteRows = false;
            this.scheduleGridView.AllowUserToOrderColumns = true;
            this.scheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGridView.Location = new System.Drawing.Point(432, 33);
            this.scheduleGridView.Name = "scheduleGridView";
            this.scheduleGridView.ReadOnly = true;
            this.scheduleGridView.RowHeadersWidth = 51;
            this.scheduleGridView.RowTemplate.Height = 24;
            this.scheduleGridView.Size = new System.Drawing.Size(620, 273);
            this.scheduleGridView.TabIndex = 14;
            // 
            // addToSchedule
            // 
            this.addToSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToSchedule.Location = new System.Drawing.Point(20, 381);
            this.addToSchedule.Name = "addToSchedule";
            this.addToSchedule.Size = new System.Drawing.Size(201, 34);
            this.addToSchedule.TabIndex = 6;
            this.addToSchedule.Text = "添加场次";
            this.addToSchedule.UseVisualStyleBackColor = true;
            this.addToSchedule.Click += new System.EventHandler(this.addToSchedule_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "场次";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "年龄组";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "项目";
            // 
            // arrangementUpDown
            // 
            this.arrangementUpDown.AllowDrop = true;
            this.arrangementUpDown.Location = new System.Drawing.Point(20, 272);
            this.arrangementUpDown.Maximum = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.arrangementUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arrangementUpDown.Name = "arrangementUpDown";
            this.arrangementUpDown.Size = new System.Drawing.Size(244, 34);
            this.arrangementUpDown.TabIndex = 3;
            this.arrangementUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ageGroupUpDown
            // 
            this.ageGroupUpDown.AllowDrop = true;
            this.ageGroupUpDown.Items.Add("7-8");
            this.ageGroupUpDown.Items.Add("9-10");
            this.ageGroupUpDown.Items.Add("11-12");
            this.ageGroupUpDown.Location = new System.Drawing.Point(20, 203);
            this.ageGroupUpDown.Name = "ageGroupUpDown";
            this.ageGroupUpDown.Size = new System.Drawing.Size(244, 34);
            this.ageGroupUpDown.TabIndex = 2;
            this.ageGroupUpDown.Text = "选择年龄组";
            // 
            // genderUpDown
            // 
            this.genderUpDown.AllowDrop = true;
            this.genderUpDown.Items.Add("男");
            this.genderUpDown.Items.Add("女");
            this.genderUpDown.Location = new System.Drawing.Point(20, 134);
            this.genderUpDown.Name = "genderUpDown";
            this.genderUpDown.Size = new System.Drawing.Size(244, 34);
            this.genderUpDown.TabIndex = 1;
            this.genderUpDown.Text = "选择性别";
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
            this.gameTypeUpDown.Location = new System.Drawing.Point(20, 65);
            this.gameTypeUpDown.Name = "gameTypeUpDown";
            this.gameTypeUpDown.Size = new System.Drawing.Size(244, 34);
            this.gameTypeUpDown.TabIndex = 0;
            this.gameTypeUpDown.Text = "选择项目";
            // 
            // npgsqlCommand2
            // 
            this.npgsqlCommand2.AllResultTypesAreUnknown = false;
            this.npgsqlCommand2.Transaction = null;
            this.npgsqlCommand2.UnknownResultTypeList = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noticeLabelAddJudge);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.gameToJudge);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.judgeAccNo);
            this.groupBox2.Controls.Add(this.addJudgeToGame);
            this.groupBox2.Controls.Add(this.judgesInfoGrid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1084, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 431);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "安排裁判";
            // 
            // judgesInfoGrid
            // 
            this.judgesInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.judgesInfoGrid.Location = new System.Drawing.Point(301, 36);
            this.judgesInfoGrid.Name = "judgesInfoGrid";
            this.judgesInfoGrid.RowHeadersWidth = 51;
            this.judgesInfoGrid.RowTemplate.Height = 24;
            this.judgesInfoGrid.Size = new System.Drawing.Size(240, 365);
            this.judgesInfoGrid.TabIndex = 0;
            // 
            // addJudgeToGame
            // 
            this.addJudgeToGame.Location = new System.Drawing.Point(20, 309);
            this.addJudgeToGame.Name = "addJudgeToGame";
            this.addJudgeToGame.Size = new System.Drawing.Size(147, 72);
            this.addJudgeToGame.TabIndex = 1;
            this.addJudgeToGame.Text = "添加";
            this.addJudgeToGame.UseVisualStyleBackColor = true;
            this.addJudgeToGame.Click += new System.EventHandler(this.addJudgeToGame_Click);
            // 
            // judgeAccNo
            // 
            this.judgeAccNo.Location = new System.Drawing.Point(7, 94);
            this.judgeAccNo.Name = "judgeAccNo";
            this.judgeAccNo.Size = new System.Drawing.Size(275, 30);
            this.judgeAccNo.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "裁判账号";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "裁决场次";
            // 
            // gameToJudge
            // 
            this.gameToJudge.Location = new System.Drawing.Point(7, 159);
            this.gameToJudge.Name = "gameToJudge";
            this.gameToJudge.Size = new System.Drawing.Size(275, 30);
            this.gameToJudge.TabIndex = 23;
            // 
            // noticeLabelAddJudge
            // 
            this.noticeLabelAddJudge.AutoSize = true;
            this.noticeLabelAddJudge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabelAddJudge.Location = new System.Drawing.Point(6, 219);
            this.noticeLabelAddJudge.Name = "noticeLabelAddJudge";
            this.noticeLabelAddJudge.Size = new System.Drawing.Size(78, 29);
            this.noticeLabelAddJudge.TabIndex = 22;
            this.noticeLabelAddJudge.Text = "notice";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 865);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.delFromSchedule);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(13000, 16000);
            this.Name = "AdminForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AdminForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accInfoGridView)).EndInit();
            this.delFromSchedule.ResumeLayout(false);
            this.delFromSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrangementUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.judgesInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addAcc;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown accType;
        private System.Windows.Forms.Button delAcc;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.DataGridView accInfoGridView;
        private System.Windows.Forms.Button refreshAccInfo;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.GroupBox delFromSchedule;
        private System.Windows.Forms.CheckBox checkBoxShowPW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown arrangementUpDown;
        private System.Windows.Forms.DomainUpDown ageGroupUpDown;
        private System.Windows.Forms.DomainUpDown genderUpDown;
        private System.Windows.Forms.DomainUpDown gameTypeUpDown;
        private Npgsql.NpgsqlCommand npgsqlCommand2;
        private System.Windows.Forms.Button refreshSchedule;
        private System.Windows.Forms.DataGridView scheduleGridView;
        private System.Windows.Forms.Button addToSchedule;
        private System.Windows.Forms.Label noticeLabel1;
        private System.Windows.Forms.Button delSchedule;
        private System.Windows.Forms.Label noticeLabelSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox gameToJudge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox judgeAccNo;
        private System.Windows.Forms.Button addJudgeToGame;
        private System.Windows.Forms.DataGridView judgesInfoGrid;
        private System.Windows.Forms.Label noticeLabelAddJudge;
    }
}