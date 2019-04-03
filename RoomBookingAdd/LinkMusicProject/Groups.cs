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
    public partial class Groups : Form
    {
        SqlDataAdapter daGroups, daNames, daInfo;

        SqlConnection conn;
        SqlCommandBuilder cmdBGroups;
        String cnStr;
        String sqlGroups;
        DataSet dsGroups = new DataSet();
        DataRow drGroups;

        int groupNoSelected = 0;
        int selectedTab = 0;
        bool groupSelected = false;

        private void Groups_Load(object sender, EventArgs e)
        {
           

            cnStr = @"Data Source = .; Initial Catalog = Link Music Academy; Integrated Security = true";

            conn = new SqlConnection(cnStr);
            sqlGroups = @"select * from Groups";

            daGroups = new SqlDataAdapter(sqlGroups, cnStr);
            cmdBGroups = new SqlCommandBuilder(daGroups);
            daGroups.FillSchema(dsGroups, SchemaType.Source, "Groups");
            daGroups.Fill(dsGroups, "Groups");

            dgvViewGroups.AutoGenerateColumns = true;
            dgvViewGroups.DataSource = dsGroups.Tables["Groups"];
           // dgvViewGroups.DataMember = dsGroups.Tables[0].TableName;
            dgvViewGroups.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
            tabGroups.SelectedIndex = 1;
            tabGroups.SelectedIndex = 0;

            daGroups.Fill(dsGroups, "Groups");
            

            

        }
        public Groups()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void button_mousehover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(154, 202, 56);
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(66, 99, 168);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void dgvViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void lbUpdateID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Anchor = (AnchorStyles.Top);
            pictureBox1.Anchor = (AnchorStyles.Right);


        }



        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            MyGroups myGroups = new MyGroups();
            //Clear errorprovider..


            //Add Try+catch for validation
            myGroups.groupName = txtGrpName.Text.Trim();
            myGroups.contactForename = txtForename.Text.Trim();
            myGroups.contactSurname = txtSurname.Text.Trim();
            myGroups.email = txtEmail.Text.Trim();
            myGroups.telephone = txtTele.Text.Trim();

            try
            {
                drGroups = dsGroups.Tables["Groups"].NewRow();

                drGroups["Group Name"] = myGroups.groupName;
                drGroups["Contact Forename"] = myGroups.contactForename;
                drGroups["Contact Surname"] = myGroups.contactSurname;
                drGroups["Telephone Number"] = myGroups.telephone;
                drGroups["Email"] = myGroups.email;
                dsGroups.Tables["Groups"].Rows.Add(drGroups);
                daGroups.Update(dsGroups, "Groups");

                MessageBox.Show("New entry has been added.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error occured.",
                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            clearAddForm();



        }

        void clearAddForm()
        {
            txtEmail.Clear();
            txtForename.Clear();
            txtGrpName.Clear();
            txtSurname.Clear();
            txtTele.Clear();
            txtUpdEmail.Clear();
            txtUpdFore.Clear();
            txtUpdGName.Clear();
            txtUpdSur.Clear();
            txtUpdTele.Clear();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            tabPage3.Enabled = true;
            string value1 = dgvViewGroups.CurrentRow.Cells[0].Value.ToString();
            drGroups = dsGroups.Tables["Groups"].Rows.Find(value1);

            tabGroups.SelectedIndex = 2;
            lblEditID.Text = value1;
            txtUpdEmail.Text = drGroups["Email"].ToString();
            txtUpdFore.Text = drGroups["Contact Forename"].ToString();
            txtUpdGName.Text = drGroups["Group Name"].ToString();
            txtUpdSur.Text = drGroups["Contact Surname"].ToString();
            txtUpdTele.Text = drGroups["Telephone Number"].ToString();


        }
        //private void getNumber(int noRows)
        //{
        //    drGroups = dsGroups.Tables["Groups"].Rows[noRows - 1];

        //}
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedTab = tabGroups.SelectedIndex;
            tabGroups.TabPages[tabGroups.SelectedIndex].Focus();
            tabGroups.TabPages[tabGroups.SelectedIndex].CausesValidation = true;

            switch (tabGroups.SelectedIndex)
            {
                case 0:
                    {
                        dsGroups.Tables["Customer"].Clear();
                        daGroups.Fill(dsGroups, "Groups");

                        break;
                    }
                case 1:
                    {
                        clearAddForm();
                        break;
                    }
                //case 2:
                //    {

                //        if (groupNoSelected == 0)
                //        {
                //            tabGroups.SelectedIndex = 0;
                //            break;
                //        }
                //        else
                        
                        
                //            lblEditID.Text = groupNoSelected.ToString();

                //            drGroups = dsGroups.Tables["Groups"].Rows.Find(lblEditID.Text);

                //            txtUpdEmail.Text = drGroups["Email"].ToString();
                //            txtUpdFore.Text = drGroups["Contact Forename"].ToString();
                //            txtUpdGName.Text = drGroups["Group Name"].ToString();
                //            txtUpdSur.Text = drGroups["Contact Surname"].ToString();
                //            txtUpdTele.Text = drGroups["Telephone Number"].ToString();

                //            break;
                        
                //    }
            }
        }

        private void Groups_Shown(object sender, EventArgs e)
        {
        //    tabGroups.TabPages[2].CausesValidation = true;
        //    tabGroups.TabPages[3].CausesValidation = true;
        //    tabGroups.TabPages[2].Validating += new CancelEventHandler(AddTabValidate);
        //    tabGroups.TabPages[3].Validating += new CancelEventHandler(EditTabValidate);
        }
        //void AddTabValidate(object sender, CancelEventArgs e)
        //{
        //    if (dgvViewGroups.SelectedRows.Count == 0)
        //    {
        //        groupNoSelected = 0;
        //        groupSelected = false;
        //    }
        //    else if (dgvViewGroups.SelectedRows.Count == 1)
        //    {
        //        groupSelected = true;
        //        groupNoSelected = Convert.ToInt32(dgvViewGroups.SelectedRows[0].Cells[0].Value);
        //    }
        //}
        //void EditTabValidate(object sender, CancelEventArgs e)
        //{
        //    if (groupSelected == false && groupNoSelected == 0)
        //    {
        //        groupNoSelected = 0;
        //        groupSelected = false;
        //    }
        //    else if (dgvViewGroups.SelectedRows.Count == 1)
        //    {
        //        groupSelected = true;
        //        groupNoSelected = Convert.ToInt32(dgvViewGroups.SelectedRows[0].Cells[0].Value);
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            tabGroups.SelectedIndex = 1;
        }

        private void tabPage4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String value1 = lblEditID.Text;
            drGroups = dsGroups.Tables["Groups"].Rows.Find(value1);

            drGroups.BeginEdit();

            drGroups["Group Name"] = txtUpdGName.Text.Trim();
            drGroups["Contact Forename"] = txtUpdFore.Text.Trim();
            drGroups["Contact Surname"] = txtUpdSur.Text.Trim();
            drGroups["Telephone Number"] = txtUpdTele.Text.Trim();
            drGroups["Email"] = txtUpdEmail.Text.Trim();

            drGroups.EndEdit();
            daGroups.Update(dsGroups, "Groups");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = dgvViewGroups.CurrentRow.Cells[1].Value.ToString()+"\r\n" 
                +dgvViewGroups.CurrentRow.Cells[2].Value.ToString()+"\r\n"
                +dgvViewGroups.CurrentRow.Cells[3].Value.ToString()+"\r\n"
                +dgvViewGroups.CurrentRow.Cells[4].Value.ToString();
            tabGroups.SelectedIndex = 3;
            textBox2.Text = dgvViewGroups.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = value1;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox2.ToString() != "")
            {
                if (MessageBox.Show("Are you sure you want to delete this Group?", "Delete Group Details",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int SelectedGroup;
                    SelectedGroup = int.Parse(textBox2.Text);
                    drGroups = dsGroups.Tables["Groups"].Rows.Find(SelectedGroup);
                    drGroups.Delete();
                    daGroups.Update(dsGroups, "Groups");
                    MessageBox.Show("Details have been deleted for: " + SelectedGroup.ToString());
                    textBox1.Clear();
                    textBox2.Clear();
                    tabGroups.SelectedIndex = 0;

                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGrpName.Clear();
            txtForename.Clear();
            txtSurname.Clear();
            txtTele.Clear();
            txtEmail.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUpdEmail.Clear();
            txtUpdFore.Clear();
            txtUpdGName.Clear();
            txtUpdSur.Clear();
            txtUpdTele.Clear();
        }



    }
}