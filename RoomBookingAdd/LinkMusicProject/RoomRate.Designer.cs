namespace LinkMusicProject
{
    partial class RoomRate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomRate));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRoomRate = new System.Windows.Forms.Label();
            this.LBRooms = new System.Windows.Forms.ListBox();
            this.lbRate = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRoomRate = new System.Windows.Forms.Button();
            this.btnRoomID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 120);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Foco", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(202)))), ((int)(((byte)(56)))));
            this.lblID.Location = new System.Drawing.Point(89, 76);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 56);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "All";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Foco", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.lblTitle.Location = new System.Drawing.Point(2, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 56);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Room";
            // 
            // lblRoomRate
            // 
            this.lblRoomRate.AutoSize = true;
            this.lblRoomRate.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomRate.ForeColor = System.Drawing.Color.Black;
            this.lblRoomRate.Location = new System.Drawing.Point(205, 140);
            this.lblRoomRate.Name = "lblRoomRate";
            this.lblRoomRate.Size = new System.Drawing.Size(110, 24);
            this.lblRoomRate.TabIndex = 23;
            this.lblRoomRate.Text = "Room Rate";
            // 
            // LBRooms
            // 
            this.LBRooms.FormattingEnabled = true;
            this.LBRooms.Location = new System.Drawing.Point(209, 167);
            this.LBRooms.Name = "LBRooms";
            this.LBRooms.Size = new System.Drawing.Size(168, 147);
            this.LBRooms.TabIndex = 24;
            this.LBRooms.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbRate
            // 
            this.lbRate.FormattingEnabled = true;
            this.lbRate.Location = new System.Drawing.Point(12, 167);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(164, 147);
            this.lbRate.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Foco", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Room Name";
            // 
            // btnRoomRate
            // 
            this.btnRoomRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnRoomRate.ForeColor = System.Drawing.Color.White;
            this.btnRoomRate.Location = new System.Drawing.Point(109, 325);
            this.btnRoomRate.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomRate.Name = "btnRoomRate";
            this.btnRoomRate.Size = new System.Drawing.Size(130, 37);
            this.btnRoomRate.TabIndex = 29;
            this.btnRoomRate.Text = "Edit Rates";
            this.btnRoomRate.UseVisualStyleBackColor = false;
            this.btnRoomRate.Click += new System.EventHandler(this.btnRoomRate_Click);
            // 
            // btnRoomID
            // 
            this.btnRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.btnRoomID.ForeColor = System.Drawing.Color.White;
            this.btnRoomID.Location = new System.Drawing.Point(247, 325);
            this.btnRoomID.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoomID.Name = "btnRoomID";
            this.btnRoomID.Size = new System.Drawing.Size(130, 37);
            this.btnRoomID.TabIndex = 30;
            this.btnRoomID.Text = "Save New Room Price";
            this.btnRoomID.UseVisualStyleBackColor = false;
            // 
            // RoomRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 375);
            this.Controls.Add(this.btnRoomID);
            this.Controls.Add(this.btnRoomRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.LBRooms);
            this.Controls.Add(this.lblRoomRate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Foco", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RoomRate";
            this.Text = "RoomRate";
            this.Load += new System.EventHandler(this.RoomRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoomRate;
        private System.Windows.Forms.ListBox LBRooms;
        private System.Windows.Forms.ListBox lbRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRoomRate;
        private System.Windows.Forms.Button btnRoomID;
    }
}