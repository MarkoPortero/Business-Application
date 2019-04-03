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
    public partial class roomMenu : Form
    {
        public roomMenu()
        {
            InitializeComponent();
        }
        //public void ChangeLabel(string s)
        //{
        //    lblRoomName.Text = s;
        //}
        private void roomMenu_Load(object sender, EventArgs e)
        {
 
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equipment viewEquip = new Equipment();
            ((Label)viewEquip.Controls["lblID"]).Text = lblRoomName.Text;
            viewEquip.ShowDialog();
        }

        private void btnRoomRate_Click(object sender, EventArgs e)
        {
            RoomRate viewRate = new RoomRate();
            ((Label)viewRate.Controls["lblID"]).Text = lblRoomName.Text;
            viewRate.ShowDialog();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            ViewBookings viewBooking = new ViewBookings();
            ((Label)viewBooking.Controls["lblID"]).Text = lblRoomName.Text;
            viewBooking.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewBookings viewBooking = new ViewBookings();
            ((Label)viewBooking.Controls["lblID"]).Text = lblRoomName.Text;
            viewBooking.ShowDialog();
           
        }


    }
}
