namespace LinkMusicProject
{
    partial class Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabGroups = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.dgvViewGroups = new System.Windows.Forms.DataGridView();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.lblTele = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblContactFore = new System.Windows.Forms.Label();
            this.txtGrpName = new System.Windows.Forms.TextBox();
            this.lblGrpName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblEditID = new System.Windows.Forms.Label();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUpdEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdTele = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdSur = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdFore = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdGName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.GroupsReport1 = new LinkMusicProject.GroupsReport();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkMusicAcademyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabGroups.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkMusicAcademyDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Foco", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(202)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(82, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 56);
            this.label1.TabIndex = 20;
            this.label1.Text = "Management";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Foco", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 56);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Group";
            // 
            // tabGroups
            // 
            this.tabGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGroups.Controls.Add(this.tabPage1);
            this.tabGroups.Controls.Add(this.tabPage2);
            this.tabGroups.Controls.Add(this.tabPage3);
            this.tabGroups.Controls.Add(this.tabPage4);
            this.tabGroups.Controls.Add(this.tabPage5);
            this.tabGroups.Font = new System.Drawing.Font("Foco", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGroups.Location = new System.Drawing.Point(10, 138);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.SelectedIndex = 0;
            this.tabGroups.Size = new System.Drawing.Size(752, 563);
            this.tabGroups.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnUpd);
            this.tabPage1.Controls.Add(this.dgvViewGroups);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblView);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 527);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "View Groups";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage4_Click);
            this.tabPage1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(615, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnUpd.ForeColor = System.Drawing.Color.White;
            this.btnUpd.Location = new System.Drawing.Point(498, 44);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(107, 40);
            this.btnUpd.TabIndex = 26;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            this.btnUpd.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnUpd.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // dgvViewGroups
            // 
            this.dgvViewGroups.AllowUserToAddRows = false;
            this.dgvViewGroups.AllowUserToDeleteRows = false;
            this.dgvViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewGroups.AutoGenerateColumns = false;
            this.dgvViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewGroups.DataSource = this.groupBindingSource;
            this.dgvViewGroups.Location = new System.Drawing.Point(6, 90);
            this.dgvViewGroups.Name = "dgvViewGroups";
            this.dgvViewGroups.ReadOnly = true;
            this.dgvViewGroups.Size = new System.Drawing.Size(732, 431);
            this.dgvViewGroups.TabIndex = 25;
            this.dgvViewGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewGroups_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Foco", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(202)))), ((int)(((byte)(56)))));
            this.label9.Location = new System.Drawing.Point(61, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 43);
            this.label9.TabIndex = 24;
            this.label9.Text = "Groups";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Foco", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.lblView.Location = new System.Drawing.Point(6, 3);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(98, 43);
            this.lblView.TabIndex = 23;
            this.lblView.Text = "View";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddGroup);
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.lblEmail);
            this.tabPage2.Controls.Add(this.txtTele);
            this.tabPage2.Controls.Add(this.lblTele);
            this.tabPage2.Controls.Add(this.txtSurname);
            this.tabPage2.Controls.Add(this.lblSurname);
            this.tabPage2.Controls.Add(this.txtForename);
            this.tabPage2.Controls.Add(this.lblContactFore);
            this.tabPage2.Controls.Add(this.txtGrpName);
            this.tabPage2.Controls.Add(this.lblGrpName);
            this.tabPage2.Font = new System.Drawing.Font("Foco", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 527);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Add Group";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Location = new System.Drawing.Point(237, 273);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(122, 45);
            this.btnAddGroup.TabIndex = 25;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            this.btnAddGroup.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnAddGroup.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(376, 273);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 45);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset Fields";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnReset.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Foco", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(202)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 43);
            this.label2.TabIndex = 22;
            this.label2.Text = "Groups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Foco", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 43);
            this.label3.TabIndex = 21;
            this.label3.Text = "Add";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(237, 241);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(86, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(145, 24);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(237, 204);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(261, 26);
            this.txtTele.TabIndex = 7;
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTele.Location = new System.Drawing.Point(117, 206);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(114, 24);
            this.lblTele.TabIndex = 6;
            this.lblTele.Text = "Telephone:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(237, 172);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(261, 26);
            this.txtSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(55, 172);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(176, 24);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Contact Surname:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(237, 135);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(261, 26);
            this.txtForename.TabIndex = 3;
            // 
            // lblContactFore
            // 
            this.lblContactFore.AutoSize = true;
            this.lblContactFore.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactFore.Location = new System.Drawing.Point(44, 137);
            this.lblContactFore.Name = "lblContactFore";
            this.lblContactFore.Size = new System.Drawing.Size(187, 24);
            this.lblContactFore.TabIndex = 2;
            this.lblContactFore.Text = "Contact Forename:";
            // 
            // txtGrpName
            // 
            this.txtGrpName.Location = new System.Drawing.Point(237, 104);
            this.txtGrpName.Name = "txtGrpName";
            this.txtGrpName.Size = new System.Drawing.Size(261, 26);
            this.txtGrpName.TabIndex = 1;
            // 
            // lblGrpName
            // 
            this.lblGrpName.AutoSize = true;
            this.lblGrpName.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrpName.Location = new System.Drawing.Point(100, 106);
            this.lblGrpName.Name = "lblGrpName";
            this.lblGrpName.Size = new System.Drawing.Size(131, 24);
            this.lblGrpName.TabIndex = 0;
            this.lblGrpName.Text = "Group Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblEditID);
            this.tabPage3.Controls.Add(this.lblGroupID);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.txtUpdEmail);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtUpdTele);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtUpdSur);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtUpdFore);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtUpdGName);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Font = new System.Drawing.Font("Foco", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(744, 527);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Update Group";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblEditID
            // 
            this.lblEditID.AutoSize = true;
            this.lblEditID.Location = new System.Drawing.Point(260, 108);
            this.lblEditID.Name = "lblEditID";
            this.lblEditID.Size = new System.Drawing.Size(16, 19);
            this.lblEditID.TabIndex = 42;
            this.lblEditID.Text = "-";
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupID.Location = new System.Drawing.Point(157, 104);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(97, 24);
            this.lblGroupID.TabIndex = 41;
            this.lblGroupID.Text = "Group ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(260, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 45);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "Update Group";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(399, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 45);
            this.button2.TabIndex = 39;
            this.button2.Text = "Reset Fields";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUpdEmail
            // 
            this.txtUpdEmail.Location = new System.Drawing.Point(260, 273);
            this.txtUpdEmail.Name = "txtUpdEmail";
            this.txtUpdEmail.Size = new System.Drawing.Size(261, 26);
            this.txtUpdEmail.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "Email Address:";
            // 
            // txtUpdTele
            // 
            this.txtUpdTele.Location = new System.Drawing.Point(260, 236);
            this.txtUpdTele.Name = "txtUpdTele";
            this.txtUpdTele.Size = new System.Drawing.Size(261, 26);
            this.txtUpdTele.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(140, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "Telephone:";
            // 
            // txtUpdSur
            // 
            this.txtUpdSur.Location = new System.Drawing.Point(260, 204);
            this.txtUpdSur.Name = "txtUpdSur";
            this.txtUpdSur.Size = new System.Drawing.Size(261, 26);
            this.txtUpdSur.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "Contact Surname:";
            // 
            // txtUpdFore
            // 
            this.txtUpdFore.Location = new System.Drawing.Point(260, 167);
            this.txtUpdFore.Name = "txtUpdFore";
            this.txtUpdFore.Size = new System.Drawing.Size(261, 26);
            this.txtUpdFore.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(67, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "Contact Forename:";
            // 
            // txtUpdGName
            // 
            this.txtUpdGName.Location = new System.Drawing.Point(260, 136);
            this.txtUpdGName.Name = "txtUpdGName";
            this.txtUpdGName.Size = new System.Drawing.Size(261, 26);
            this.txtUpdGName.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(123, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 24);
            this.label14.TabIndex = 29;
            this.label14.Text = "Group Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Foco", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(202)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(70, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 43);
            this.label4.TabIndex = 24;
            this.label4.Text = "Groups";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Foco", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 43);
            this.label5.TabIndex = 23;
            this.label5.Text = "Update";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.btnDelete);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.lblDelete);
            this.tabPage4.Font = new System.Drawing.Font("Foco", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(744, 527);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Delete Group";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(14, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 26);
            this.textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Foco", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(221, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 384);
            this.textBox1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Group Information:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(625, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 40);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Group ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Foco", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(202)))), ((int)(((byte)(56)))));
            this.label8.Location = new System.Drawing.Point(70, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 43);
            this.label8.TabIndex = 32;
            this.label8.Text = "Groups";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Foco", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.lblDelete.Location = new System.Drawing.Point(6, 5);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(124, 43);
            this.lblDelete.TabIndex = 31;
            this.lblDelete.Text = "Delete";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.crystalReportViewer1);
            this.tabPage5.Location = new System.Drawing.Point(4, 32);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(744, 527);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Report";
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
            this.crystalReportViewer1.ReportSource = this.GroupsReport1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(738, 521);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 120);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 713);
            this.Controls.Add(this.tabGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Groups";
            this.Text = "Groups";
            this.Load += new System.EventHandler(this.Groups_Load);
            this.Shown += new System.EventHandler(this.Groups_Shown);
            this.Resize += new System.EventHandler(this.pictureBox1_Resize);
            this.tabGroups.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkMusicAcademyDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabGroups;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblContactFore;
        private System.Windows.Forms.TextBox txtGrpName;
        private System.Windows.Forms.Label lblGrpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvViewGroups;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactForenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource linkMusicAcademyDataSetBindingSource;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Label lblEditID;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUpdEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdTele;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdSur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdFore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdGName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private GroupsReport GroupsReport1;
    }
}