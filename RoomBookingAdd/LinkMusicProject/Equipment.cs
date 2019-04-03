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
    public partial class Equipment : Form
    {
        SqlDataAdapter daEquipment;
        SqlConnection conn;
        SqlCommandBuilder cmdBEquipment;
        String cnStr;
        String sqlEquipment;
        DataSet dsEquipment = new DataSet();

        public Equipment()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            string tester = lblID.Text;
            cnStr = @"Data Source = .; Initial Catalog = Link Music Academy; Integrated Security = true";

            conn = new SqlConnection(cnStr);

            if (tester == "All")
            {
                sqlEquipment = @"select * from [Equipment]";
                daEquipment = new SqlDataAdapter(sqlEquipment, cnStr);
                cmdBEquipment = new SqlCommandBuilder(daEquipment);
                daEquipment.FillSchema(dsEquipment, SchemaType.Source, "[Equipment]");
                daEquipment.Fill(dsEquipment, "[Equipment]");

                dgvEquipment.AutoGenerateColumns = true;
                dgvEquipment.DataSource = dsEquipment.Tables["[Equipment]"];

                dgvEquipment.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else if (tester != "All")
            {
                sqlEquipment = @"select * from [Room Equipment] WHERE [Room Number ID] = '" + tester + "'";

                daEquipment = new SqlDataAdapter(sqlEquipment, cnStr);
                cmdBEquipment = new SqlCommandBuilder(daEquipment);
                daEquipment.FillSchema(dsEquipment, SchemaType.Source, "[Room Equipment]");
                daEquipment.Fill(dsEquipment, "[Room Equipment]");

                dgvEquipment.AutoGenerateColumns = true;
                dgvEquipment.DataSource = dsEquipment.Tables["[Room Equipment]"];

                dgvEquipment.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }

        }
    }
}
