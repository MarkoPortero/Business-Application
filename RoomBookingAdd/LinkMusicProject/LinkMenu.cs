using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkMusicProject
{
    public partial class LinkMenu : Form
    {
        public LinkMenu()
        {
            InitializeComponent();
        }

        private void LinkMenu_Load(object sender, EventArgs e)
        {

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Groups newGroups = new Groups();
            newGroups.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Rooms newRoom = new Rooms();
            newRoom.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Groups newGroups = new Groups();
            newGroups.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ViewBookings viewBooking = new ViewBookings();
            viewBooking.ShowDialog();
        }
    }
}
