using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LinkMusicProject
{
    public partial class ViewBookings : Form
    {
        SqlDataAdapter daBookings, daGroups, daCount, daRooms, daSession;
        SqlConnection conn;
        SqlCommandBuilder cmdBBookings;
        String cnStr;
        String sqlBookings, sqlGroupName, sqlSessions, sqlRooms, sqlExists;
        DataSet dsBookings = new DataSet();
        DataTable dtBooking;
        DataRow drBooking;

        DateTime mydate;
        String sqlFormattedDate;
        String RoomID;
        String Session;
        String GroupName;
        String GroupID;

        private void ViewBookings_Load(object sender, EventArgs e)
        {

            string tester = lblID.Text;
            cnStr = @"Data Source = .; Initial Catalog = Link Music Academy; Integrated Security = true";

            conn = new SqlConnection(cnStr);

            if (tester == "All")
            {
                sqlBookings = @"select * from [Practice Room Booking]";
                daBookings = new SqlDataAdapter(sqlBookings, cnStr);
                cmdBBookings = new SqlCommandBuilder(daBookings);
                daBookings.FillSchema(dsBookings, SchemaType.Source, "Practice Room Booking");
                daBookings.Fill(dsBookings, "Practice Room Booking");

                dgvBookings.AutoGenerateColumns = true;
                dgvBookings.DataSource = dsBookings.Tables["Practice Room Booking"];

                dgvBookings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else if (tester != "All")
            {
                sqlBookings = @"select * from [Practice Room Booking] WHERE [Room ID] = '" + tester + "'";

                daBookings = new SqlDataAdapter(sqlBookings, cnStr);
                cmdBBookings = new SqlCommandBuilder(daBookings);
                daBookings.FillSchema(dsBookings, SchemaType.Source, "Practice Room Booking");
                daBookings.Fill(dsBookings, "Practice Room Booking");

                dgvBookings.AutoGenerateColumns = true;
                dgvBookings.DataSource = dsBookings.Tables["Practice Room Booking"];

                dgvBookings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }

            sqlGroupName = @"select * from [Groups]";

            daGroups = new SqlDataAdapter(sqlGroupName, cnStr);
            daGroups.FillSchema(dsBookings, SchemaType.Source, "Groups");
            daGroups.Fill(dsBookings, "Groups");

            sqlRooms = @"select * from [Rooms]";
            daRooms = new SqlDataAdapter(sqlRooms, cnStr);
            daRooms.FillSchema(dsBookings, SchemaType.Source, "Rooms");
            daRooms.Fill(dsBookings, "Rooms");

            lbRoomID.DataSource = dsBookings.Tables["Rooms"];
            lbRoomID.DisplayMember = "Room Number ID";

            lbGroupName.DataSource = dsBookings.Tables["Groups"];
            lbGroupName.DisplayMember = "Group Name";

            sqlSessions = @"select * from [Slots]";
            daSession = new SqlDataAdapter(sqlSessions, cnStr);
            daSession.FillSchema(dsBookings, SchemaType.Source, "Slots");
            daSession.Fill(dsBookings, "Slots");
            lbSessions.DataSource = dsBookings.Tables["Slots"];
            lbSessions.DisplayMember = "Slot ID";

            
        }
        public ViewBookings()
        {
            InitializeComponent();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lbSessions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpView_ValueChanged(object sender, EventArgs e)
        {
            string mydate = dtpView.Value.Date.ToShortDateString();
            (dgvBookings.DataSource as DataTable).DefaultView.RowFilter = string.Format("Date = '" + mydate + "'");
        }
        private void getNumber(int noRows)
        {
            drBooking = dsBookings.Tables["Practice Room Booking"].Rows[noRows - 1];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            mydate = dtpAdd.Value;
            sqlFormattedDate = mydate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            lbGroupName.DataSource = dsBookings.Tables["Groups"];
            lbGroupName.DisplayMember = "Group Name";
            GroupID = (lbGroupName.SelectedItem as DataRowView)["Group Number ID"].ToString();
            GroupName = lbGroupName.GetItemText(lbGroupName.SelectedItem);
            RoomID = lbRoomID.GetItemText(lbRoomID.SelectedItem);
            Session = lbSessions.GetItemText(lbSessions.SelectedItem);
            sqlExists = @"SELECT COUNT(*) FROM [Practice Room Booking] WHERE [Room ID] like '" + RoomID + "' AND [Slot ID] like '" + Session + "' AND [Date] = '" + sqlFormattedDate + "'";
            daCount = new SqlDataAdapter(sqlExists, cnStr);
            int groupID = int.Parse(GroupID);
            int session = int.Parse(Session);
            int roomID = int.Parse(RoomID);
            SqlCommand cmd = new SqlCommand(sqlExists, conn);
            conn.Open();

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
            {
                myBooking MyBooking = new myBooking();

                MyBooking.groupID = groupID;
                MyBooking.slotID = session;
                MyBooking.roomID = roomID;
                MyBooking.date = sqlFormattedDate;
                MyBooking.equipmentRequest = txtEquipRequest.Text.Trim();

                try
                {
                    drBooking = dsBookings.Tables["Practice Room Booking"].NewRow();

                    drBooking["Group ID"] = MyBooking.groupID;
                    drBooking["Room ID"] = MyBooking.roomID;
                    drBooking["Date"] = MyBooking.date;
                    drBooking["Slot ID"] = MyBooking.slotID;
                    drBooking["Equipment Request"] = MyBooking.equipmentRequest;

                    dsBookings.Tables["Practice Room Booking"].Rows.Add(drBooking);
                    daBookings.Update(dsBookings, "Practice Room Booking");
                    MessageBox.Show("New booking has been added.");
                    dsBookings.Clear();
                    daBookings.Fill(dsBookings, "Practice Room Booking");
                    daGroups.FillSchema(dsBookings, SchemaType.Source, "Groups");
                    daGroups.Fill(dsBookings, "Groups");
                    daRooms.FillSchema(dsBookings, SchemaType.Source, "Rooms");
                    daRooms.Fill(dsBookings, "Rooms");
                    daSession.FillSchema(dsBookings, SchemaType.Source, "Slots");
                    daSession.Fill(dsBookings, "Slots");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error occured.",
                        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
            else if (count != 0)
            {
                MessageBox.Show("There is currently a booking in this slot.");
            }
            conn.Close();


        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            DialogResult drAdd = MessageBox.Show("Add a new group?", "Add Group?", MessageBoxButtons.YesNo);
            if (drAdd == DialogResult.Yes)
            {
                Groups newGroups = new Groups();
                newGroups.ShowDialog();
            }
        }

        private void btnUpdSearch_Click(object sender, EventArgs e)
        {
            txtGroupID.Visible = false;
            cmbRoomID.Visible = false;
            cmbSlotID.Visible = false;
            txtUpdEquip.Visible = false;
            dtpUpd.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            btnUpdUpd.Visible = false;
            btnSave.Visible = false;

            int SelectedGroup;
            SelectedGroup = int.Parse(txtUpdGN.Text);
            drBooking = dsBookings.Tables["Practice Room Booking"].Rows.Find(SelectedGroup);
            try
            {
                txtGroupID.Text = drBooking["Group ID"].ToString();
                cmbRoomID.Text = drBooking["Room ID"].ToString();
                cmbSlotID.Text = drBooking["Slot ID"].ToString();
                txtUpdEquip.Text = drBooking["Equipment Request"].ToString();
                dtpUpd.Value = Convert.ToDateTime(drBooking["Date"]);

                if (txtGroupID.ToString() == "")
                {
                    MessageBox.Show("No records found.");
                }
                else
                {
                    btnUpdUpd.Enabled = true;
                    btnSave.Enabled = false;
                    txtGroupID.Visible = true;
                    cmbRoomID.Visible = true;
                    cmbSlotID.Visible = true;
                    txtUpdEquip.Visible = true;
                    dtpUpd.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label15.Visible = true;
                    btnUpdUpd.Visible = true;
                    btnSave.Visible = true;
                    cmbRoomID.Enabled = false;
                    cmbSlotID.Enabled = false;
                    dtpUpd.Enabled = false;
                    txtUpdEquip.Enabled = false;
                    btnUpdUpd.Enabled = true;
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record does not exist!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mydate = dtpUpd.Value;
            sqlFormattedDate = mydate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            int SelectedGroup;
            SelectedGroup = int.Parse(txtUpdGN.Text);
            drBooking = dsBookings.Tables["Practice Room Booking"].Rows.Find(SelectedGroup);
            drBooking.BeginEdit();

            drBooking["Room ID"] = Convert.ToInt32(cmbRoomID.Text);
            drBooking["Slot ID"] = Convert.ToInt32(cmbSlotID.Text);

            drBooking["Equipment Request"] = txtUpdEquip.Text;
            drBooking["Date"] = mydate;

            drBooking.EndEdit();
            daBookings.Update(dsBookings, "Practice Room Booking");

            MessageBox.Show("Details for:" + SelectedGroup + " Have been updated!");
            clear();
        }

        private void btnUpdUpd_Click(object sender, EventArgs e)
        {
            cmbRoomID.Enabled = true;
            cmbSlotID.Enabled = true;
            dtpUpd.Enabled = true;
            txtUpdEquip.Enabled = true;
            btnUpdUpd.Enabled = false;
            btnSave.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;

            txtDelEquip.Visible = false;
            txtDelGroupID.Visible = false;
            cmbDelRoom.Visible = false;
            cmbDelSlot.Visible = false;
            dtpDel.Visible = false;
            btnDel.Visible = false;

            int SelectedGroup;
            SelectedGroup = int.Parse(txtDelSearch.Text);
            drBooking = dsBookings.Tables["Practice Room Booking"].Rows.Find(SelectedGroup);
            try
            {
                txtDelGroupID.Text = drBooking["Group ID"].ToString();
                cmbDelRoom.Text = drBooking["Room ID"].ToString();
                cmbDelSlot.Text = drBooking["Slot ID"].ToString();
                txtDelEquip.Text = drBooking["Equipment Request"].ToString();
                dtpDel.Value = Convert.ToDateTime(drBooking["Date"]);

                if (txtDelGroupID.ToString() == "")
                {
                    MessageBox.Show("No records found.");
                }
                else
                {
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;

                    txtDelEquip.Visible = true;
                    txtDelGroupID.Visible = true;
                    cmbDelRoom.Visible = true;
                    cmbDelSlot.Visible = true;
                    dtpDel.Visible = true;
                    btnDel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record does not exist!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDelGroupID.ToString() != "")
            {
                if(MessageBox.Show("Are you sure you want to delete this booking?", "Delete Booking Details",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int SelectedGroup;
                    SelectedGroup = int.Parse(txtDelSearch.Text);
                    drBooking = dsBookings.Tables["Practice Room Booking"].Rows.Find(SelectedGroup);
                    drBooking.Delete();
                    daBookings.Update(dsBookings, "Practice Room Booking");
                    MessageBox.Show("Details have been deleted for: " + SelectedGroup.ToString());

                    clear();
                }
            }
        }

        private void clear()
        {
            txtGroupID.Visible = false;
            cmbRoomID.Visible = false;
            cmbSlotID.Visible = false;
            txtUpdEquip.Visible = false;
            dtpUpd.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label15.Visible = false;
            btnUpdUpd.Visible = false;
            btnSave.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;

            txtDelEquip.Visible = false;
            txtDelGroupID.Visible = false;
            cmbDelRoom.Visible = false;
            cmbDelSlot.Visible = false;
            dtpDel.Visible = false;
            btnDel.Visible = false;
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
