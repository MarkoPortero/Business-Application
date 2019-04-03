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
    public partial class Rooms : Form
    {

        public Rooms()
        {
            InitializeComponent();
            pb101.Enabled = false;
            pb102.Enabled = false;
            pb103.Enabled = false;
            pb104.Enabled = false;
            pb105.Enabled = false;
            pb106.Enabled = false;
            pb107.Enabled = false;
            pb108.Enabled = false;
            pb109.Enabled = false;
            pb110.Enabled = false;
            pb101.Visible = false;
            pb102.Visible = false;
            pb103.Visible = false;
            pb104.Visible = false;
            pb105.Visible = false;
            pb106.Visible = false;
            pb107.Visible = false;
            pb108.Visible = false;
            pb109.Visible = false;
            pb110.Visible = false;

        }

        private void Rooms_Load(object sender, EventArgs e)
        {

        }

        private void btnFloor1_Click(object sender, EventArgs e)
        {
                //Resources.ResourceManager.GetObject("");
            this.BackgroundImage = LinkMusicProject.Resources.Link_Academy_1st_Floor;
            //pictureBox2.Visible = true;
            //pictureBox3.Visible = false; 
            btnFloor1.Enabled = false;
            btnFloor2.Enabled = true;
            pb101.Enabled = false;
            pb102.Enabled = false;
            pb103.Enabled = false;
            pb104.Enabled = false;
            pb105.Enabled = false;
            pb106.Enabled = false;
            pb107.Enabled = false;
            pb108.Enabled = false;
            pb109.Enabled = false;
            pb110.Enabled = false;

            pb101.Visible = false;
            pb102.Visible = false;
            pb103.Visible = false;
            pb104.Visible = false;
            pb105.Visible = false;
            pb106.Visible = false;
            pb107.Visible = false;
            pb108.Visible = false;
            pb109.Visible = false;
            pb110.Visible = false;
            pbflr1Equipment.Enabled = true;
            pbOffice.Enabled = true;
            pbReception.Enabled = true;
            pbStaffRoom.Enabled = true;
            pbflr1Equipment.Visible = true;
            pbReception.Visible = true;
            pbOffice.Visible = true;
            pbStaffRoom.Visible = true;
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = LinkMusicProject.Resources.Floor2;
            //pictureBox2.Visible = false;
            //pictureBox3.Visible = true;
            btnFloor1.Enabled = true;
            btnFloor2.Enabled = false;
            pbflr1Equipment.Enabled = false;
            pbOffice.Enabled = false;
            pbReception.Enabled = false;
            pbStaffRoom.Enabled = false;
            pbflr1Equipment.Visible = false;
            pbReception.Visible = false;
            pbOffice.Visible = false;
            pbStaffRoom.Visible = false;
            pb101.Enabled = true;
            pb102.Enabled = true;
            pb103.Enabled = true;
            pb104.Enabled = true;
            pb105.Enabled = true;
            pb106.Enabled = true;
            pb107.Enabled = true;
            pb108.Enabled = true;
            pb109.Enabled = true;
            pb110.Enabled = true;
            pb101.Visible = true;
            pb102.Visible = true;
            pb103.Visible = true;
            pb104.Visible = true;
            pb105.Visible = true;
            pb106.Visible = true;
            pb107.Visible = true;
            pb108.Visible = true;
            pb109.Visible = true;
            pb110.Visible = true;

        }        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult equipmentDialog = MessageBox.Show("View current equipment in storage?", "Equipment Storage", MessageBoxButtons.YesNo);
            if (equipmentDialog == DialogResult.Yes)
            {
                Equipment viewEquip = new Equipment();
                viewEquip.ShowDialog();
            }


        }
        private void button1_MouseHover(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(154, 202, 56);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(66, 99, 168);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)(sender);
            picBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = (PictureBox)(sender);
            picBox.BorderStyle = BorderStyle.None;
        }


        private void pbOffice_Click(object sender, EventArgs e)
        {
            DialogResult officeDialog = MessageBox.Show("This is an office. View staff?", "Office", MessageBoxButtons.YesNo);
            if (officeDialog == DialogResult.Yes)
            {
                //show staff
            }
            
        }

        private void pbReception_Click(object sender, EventArgs e)
        {
            DialogResult officeDialog = MessageBox.Show("View current reception Staff?", "Reception", MessageBoxButtons.YesNo);
            if (officeDialog == DialogResult.Yes)
            {
                //show staff
            }
        }

        private void pb107_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "107";
            menu.ShowDialog();
        }

        private void pb104_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "104";
            menu.ShowDialog();   
        }

        private void pb103_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "103";
            menu.ShowDialog();
        }
        private void pb102_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "102";
            menu.ShowDialog();
        }

        private void pb101_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "101";
            menu.ShowDialog();
        }

        private void pb105_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "105";
            menu.ShowDialog();
        }

        private void pb106_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "106";
            menu.ShowDialog();
        }

        private void pb109_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "109";
            menu.ShowDialog();
        }

        private void pb108_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "108";
            menu.ShowDialog();
        }

        private void pb110_Click(object sender, EventArgs e)
        {
            roomMenu menu = new roomMenu();
            ((Label)menu.Controls["lblRoomName"]).Text = "110";
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewBookings viewBooking = new ViewBookings();
            viewBooking.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equipment viewEquip = new Equipment();
            viewEquip.ShowDialog();
        }







    }
}
