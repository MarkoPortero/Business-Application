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
    public partial class RoomRate : Form
    {
        SqlDataAdapter daRates, daRooms;
        SqlConnection conn;
        SqlCommandBuilder cmdBRates;
        String cnStr;
        String sqlRates;
        DataSet dsRates = new DataSet();
        public RoomRate()
        {
            InitializeComponent();
        }

        private void RoomRate_Load(object sender, EventArgs e)
        {
            string tester = lblID.Text;
            cnStr = @"Data Source = .; Initial Catalog = Link Music Academy; Integrated Security = true";

            conn = new SqlConnection(cnStr);

            sqlRates = @"SELECT Rooms.[Room Name], Rooms.[Room Number ID], [Room Rate].[Room Rate]
                            FROM Rooms
                            INNER JOIN [Room Rate]
                            ON Rooms.[Room Rate ID]=[Room Rate].[Room Rate ID]
                            WHERE [Room Number ID] = '" +tester+"'";
            daRates = new SqlDataAdapter(sqlRates, cnStr);

            daRooms = new SqlDataAdapter(sqlRates, cnStr);
            cmdBRates = new SqlCommandBuilder(daRates);

            daRates.FillSchema(dsRates, SchemaType.Source, "[Room Rate]");
            daRates.Fill(dsRates, "[Room Rate]");

            daRooms.FillSchema(dsRates, SchemaType.Source, "Rooms");
            daRooms.Fill(dsRates, "Rooms");

            LBRooms.DataSource = dsRates.Tables["Rooms"];
            LBRooms.DisplayMember = "Room Rate";
            

            lbRate.DataSource = dsRates.Tables["Rooms"];
            lbRate.DisplayMember = "Room Name";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBRooms.DataSource = dsRates.Tables["Room Rate"];
            LBRooms.DisplayMember = "Room Rate ID";
        }

        private void btnRoomRate_Click(object sender, EventArgs e)
        {

        }
    }
}
