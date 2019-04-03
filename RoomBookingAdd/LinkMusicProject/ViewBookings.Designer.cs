namespace LinkMusicProject
{
    partial class ViewBookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookings));
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpView = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEquipRequest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.ListBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSessions = new System.Windows.Forms.ListBox();
            this.lbGroupName = new System.Windows.Forms.ListBox();
            this.dtpAdd = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdUpd = new System.Windows.Forms.Button();
            this.txtUpdEquip = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSlotID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpUpd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbRoomID = new System.Windows.Forms.ComboBox();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdGN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdSearch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtDelEquip = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDelSlot = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDel = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbDelRoom = new System.Windows.Forms.ComboBox();
            this.txtDelGroupID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDelSearch = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Timetable1 = new LinkMusicProject.Timetable();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Foco", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(202)))), ((int)(((byte)(56)))));
            this.lblID.Location = new System.Drawing.Point(113, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 56);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "All";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Foco", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "Room";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(0, 38);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.Size = new System.Drawing.Size(623, 474);
            this.dgvBookings.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "View Bookings";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Foco", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 544);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dtpView);
            this.tabPage1.Controls.Add(this.dgvBookings);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 26);
            this.button2.TabIndex = 23;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtpView
            // 
            this.dtpView.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpView.Location = new System.Drawing.Point(6, 6);
            this.dtpView.Name = "dtpView";
            this.dtpView.Size = new System.Drawing.Size(200, 26);
            this.dtpView.TabIndex = 22;
            this.dtpView.ValueChanged += new System.EventHandler(this.dtpView_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtEquipRequest);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lbRoomID);
            this.tabPage2.Controls.Add(this.btnAddBooking);
            this.tabPage2.Controls.Add(this.btnAddGroup);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbSessions);
            this.tabPage2.Controls.Add(this.lbGroupName);
            this.tabPage2.Controls.Add(this.dtpAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Equipment Request:";
            // 
            // txtEquipRequest
            // 
            this.txtEquipRequest.Location = new System.Drawing.Point(17, 349);
            this.txtEquipRequest.Multiline = true;
            this.txtEquipRequest.Name = "txtEquipRequest";
            this.txtEquipRequest.Size = new System.Drawing.Size(328, 147);
            this.txtEquipRequest.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Group Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Slots:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Room ID:";
            // 
            // lbRoomID
            // 
            this.lbRoomID.FormattingEnabled = true;
            this.lbRoomID.ItemHeight = 19;
            this.lbRoomID.Location = new System.Drawing.Point(17, 85);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(200, 232);
            this.lbRoomID.TabIndex = 28;
            this.lbRoomID.SelectedIndexChanged += new System.EventHandler(this.lbRoomID_SelectedIndexChanged);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnAddBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBooking.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.Location = new System.Drawing.Point(471, 451);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(122, 45);
            this.btnAddBooking.TabIndex = 27;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Location = new System.Drawing.Point(471, 400);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(122, 45);
            this.btnAddGroup.TabIndex = 26;
            this.btnAddGroup.Text = "New Group";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add Booking";
            // 
            // lbSessions
            // 
            this.lbSessions.FormattingEnabled = true;
            this.lbSessions.ItemHeight = 19;
            this.lbSessions.Location = new System.Drawing.Point(223, 85);
            this.lbSessions.Name = "lbSessions";
            this.lbSessions.Size = new System.Drawing.Size(164, 232);
            this.lbSessions.TabIndex = 2;
            this.lbSessions.SelectedIndexChanged += new System.EventHandler(this.lbSessions_SelectedIndexChanged);
            // 
            // lbGroupName
            // 
            this.lbGroupName.FormattingEnabled = true;
            this.lbGroupName.ItemHeight = 19;
            this.lbGroupName.Location = new System.Drawing.Point(393, 85);
            this.lbGroupName.Name = "lbGroupName";
            this.lbGroupName.Size = new System.Drawing.Size(200, 232);
            this.lbGroupName.TabIndex = 1;
            // 
            // dtpAdd
            // 
            this.dtpAdd.Location = new System.Drawing.Point(17, 30);
            this.dtpAdd.Name = "dtpAdd";
            this.dtpAdd.Size = new System.Drawing.Size(200, 26);
            this.dtpAdd.TabIndex = 0;
            this.dtpAdd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSave);
            this.tabPage3.Controls.Add(this.btnUpdUpd);
            this.tabPage3.Controls.Add(this.txtUpdEquip);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.cmbSlotID);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dtpUpd);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cmbRoomID);
            this.tabPage3.Controls.Add(this.txtGroupID);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtUpdGN);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.btnUpdSearch);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(623, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(286, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 37);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdUpd
            // 
            this.btnUpdUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnUpdUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdUpd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdUpd.ForeColor = System.Drawing.Color.White;
            this.btnUpdUpd.Location = new System.Drawing.Point(166, 401);
            this.btnUpdUpd.Name = "btnUpdUpd";
            this.btnUpdUpd.Size = new System.Drawing.Size(114, 37);
            this.btnUpdUpd.TabIndex = 58;
            this.btnUpdUpd.Text = "Update";
            this.btnUpdUpd.UseVisualStyleBackColor = false;
            this.btnUpdUpd.Visible = false;
            this.btnUpdUpd.Click += new System.EventHandler(this.btnUpdUpd_Click);
            // 
            // txtUpdEquip
            // 
            this.txtUpdEquip.Enabled = false;
            this.txtUpdEquip.Location = new System.Drawing.Point(166, 271);
            this.txtUpdEquip.Multiline = true;
            this.txtUpdEquip.Name = "txtUpdEquip";
            this.txtUpdEquip.Size = new System.Drawing.Size(331, 124);
            this.txtUpdEquip.TabIndex = 57;
            this.txtUpdEquip.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 19);
            this.label15.TabIndex = 56;
            this.label15.Text = "Equipment Request:";
            this.label15.Visible = false;
            // 
            // cmbSlotID
            // 
            this.cmbSlotID.Enabled = false;
            this.cmbSlotID.FormattingEnabled = true;
            this.cmbSlotID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbSlotID.Location = new System.Drawing.Point(166, 238);
            this.cmbSlotID.Name = "cmbSlotID";
            this.cmbSlotID.Size = new System.Drawing.Size(159, 27);
            this.cmbSlotID.TabIndex = 55;
            this.cmbSlotID.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 19);
            this.label12.TabIndex = 54;
            this.label12.Text = "Slot ID:";
            this.label12.Visible = false;
            // 
            // dtpUpd
            // 
            this.dtpUpd.Enabled = false;
            this.dtpUpd.Location = new System.Drawing.Point(166, 207);
            this.dtpUpd.Name = "dtpUpd";
            this.dtpUpd.Size = new System.Drawing.Size(224, 26);
            this.dtpUpd.TabIndex = 53;
            this.dtpUpd.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 19);
            this.label11.TabIndex = 52;
            this.label11.Text = "Date:";
            this.label11.Visible = false;
            // 
            // cmbRoomID
            // 
            this.cmbRoomID.Enabled = false;
            this.cmbRoomID.FormattingEnabled = true;
            this.cmbRoomID.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110"});
            this.cmbRoomID.Location = new System.Drawing.Point(166, 174);
            this.cmbRoomID.Name = "cmbRoomID";
            this.cmbRoomID.Size = new System.Drawing.Size(159, 27);
            this.cmbRoomID.TabIndex = 51;
            this.cmbRoomID.Visible = false;
            // 
            // txtGroupID
            // 
            this.txtGroupID.Enabled = false;
            this.txtGroupID.Location = new System.Drawing.Point(166, 139);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(159, 26);
            this.txtGroupID.TabIndex = 50;
            this.txtGroupID.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 49;
            this.label10.Text = "Room ID:";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "Group ID:";
            this.label9.Visible = false;
            // 
            // txtUpdGN
            // 
            this.txtUpdGN.Location = new System.Drawing.Point(302, 49);
            this.txtUpdGN.Name = "txtUpdGN";
            this.txtUpdGN.Size = new System.Drawing.Size(125, 26);
            this.txtUpdGN.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(279, 19);
            this.label14.TabIndex = 46;
            this.label14.Text = "Please Enter a Group Booking Number:";
            // 
            // btnUpdSearch
            // 
            this.btnUpdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnUpdSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdSearch.ForeColor = System.Drawing.Color.White;
            this.btnUpdSearch.Location = new System.Drawing.Point(302, 81);
            this.btnUpdSearch.Name = "btnUpdSearch";
            this.btnUpdSearch.Size = new System.Drawing.Size(103, 32);
            this.btnUpdSearch.TabIndex = 38;
            this.btnUpdSearch.Text = "Search";
            this.btnUpdSearch.UseVisualStyleBackColor = false;
            this.btnUpdSearch.Click += new System.EventHandler(this.btnUpdSearch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 24);
            this.label13.TabIndex = 37;
            this.label13.Text = "Edit Booking";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDel);
            this.tabPage4.Controls.Add(this.txtDelEquip);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.cmbDelSlot);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.dtpDel);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.cmbDelRoom);
            this.tabPage4.Controls.Add(this.txtDelGroupID);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.txtDelSearch);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(623, 512);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(157, 390);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(114, 37);
            this.btnDel.TabIndex = 75;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtDelEquip
            // 
            this.txtDelEquip.Enabled = false;
            this.txtDelEquip.Location = new System.Drawing.Point(157, 250);
            this.txtDelEquip.Multiline = true;
            this.txtDelEquip.Name = "txtDelEquip";
            this.txtDelEquip.Size = new System.Drawing.Size(331, 124);
            this.txtDelEquip.TabIndex = 73;
            this.txtDelEquip.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 19);
            this.label16.TabIndex = 72;
            this.label16.Text = "Equipment Request:";
            this.label16.Visible = false;
            // 
            // cmbDelSlot
            // 
            this.cmbDelSlot.Enabled = false;
            this.cmbDelSlot.FormattingEnabled = true;
            this.cmbDelSlot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbDelSlot.Location = new System.Drawing.Point(157, 217);
            this.cmbDelSlot.Name = "cmbDelSlot";
            this.cmbDelSlot.Size = new System.Drawing.Size(159, 27);
            this.cmbDelSlot.TabIndex = 71;
            this.cmbDelSlot.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(83, 225);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 19);
            this.label17.TabIndex = 70;
            this.label17.Text = "Slot ID:";
            this.label17.Visible = false;
            // 
            // dtpDel
            // 
            this.dtpDel.Enabled = false;
            this.dtpDel.Location = new System.Drawing.Point(157, 186);
            this.dtpDel.Name = "dtpDel";
            this.dtpDel.Size = new System.Drawing.Size(224, 26);
            this.dtpDel.TabIndex = 69;
            this.dtpDel.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(96, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 19);
            this.label18.TabIndex = 68;
            this.label18.Text = "Date:";
            this.label18.Visible = false;
            // 
            // cmbDelRoom
            // 
            this.cmbDelRoom.Enabled = false;
            this.cmbDelRoom.FormattingEnabled = true;
            this.cmbDelRoom.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110"});
            this.cmbDelRoom.Location = new System.Drawing.Point(157, 153);
            this.cmbDelRoom.Name = "cmbDelRoom";
            this.cmbDelRoom.Size = new System.Drawing.Size(159, 27);
            this.cmbDelRoom.TabIndex = 67;
            this.cmbDelRoom.Visible = false;
            // 
            // txtDelGroupID
            // 
            this.txtDelGroupID.Enabled = false;
            this.txtDelGroupID.Location = new System.Drawing.Point(157, 118);
            this.txtDelGroupID.Name = "txtDelGroupID";
            this.txtDelGroupID.Size = new System.Drawing.Size(159, 26);
            this.txtDelGroupID.TabIndex = 66;
            this.txtDelGroupID.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(70, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 19);
            this.label19.TabIndex = 65;
            this.label19.Text = "Room ID:";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(70, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 19);
            this.label20.TabIndex = 64;
            this.label20.Text = "Group ID:";
            this.label20.Visible = false;
            // 
            // txtDelSearch
            // 
            this.txtDelSearch.Location = new System.Drawing.Point(307, 45);
            this.txtDelSearch.Name = "txtDelSearch";
            this.txtDelSearch.Size = new System.Drawing.Size(125, 26);
            this.txtDelSearch.TabIndex = 63;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(279, 19);
            this.label21.TabIndex = 62;
            this.label21.Text = "Please Enter a Group Booking Number:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(307, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 32);
            this.button4.TabIndex = 61;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Delete Booking";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.crystalReportViewer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(623, 512);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Timetable";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Timetable1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(617, 506);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 120);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ViewBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 707);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewBookings";
            this.Text = "View Bookings";
            this.Load += new System.EventHandler(this.ViewBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbSessions;
        private System.Windows.Forms.ListBox lbGroupName;
        private System.Windows.Forms.DateTimePicker dtpAdd;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.DateTimePicker dtpView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbRoomID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEquipRequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdGN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUpdUpd;
        private System.Windows.Forms.TextBox txtUpdEquip;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSlotID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpUpd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbRoomID;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtDelEquip;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbDelSlot;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpDel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbDelRoom;
        private System.Windows.Forms.TextBox txtDelGroupID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDelSearch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Timetable Timetable1;
    }
}