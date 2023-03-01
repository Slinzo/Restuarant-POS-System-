using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LupaISPrototype
{
    public partial class FunctionsStaffManagementForm : Form
    {
        public FunctionsStaffManagementForm()
        {
            InitializeComponent();
        }
   
        SqlConnection conn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");

        void clearEntries()
        {
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            titleComboBox.SelectedItem = null;
            comboBox1.SelectedItem = null;
            phoneNumberTextBox.Clear();
            eMailTextBox.Clear();
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            passwordConfirmTextBox.Clear();
        }

        public void bindActiveStaff()
        {
            // FILL ACTIVE USERS
            GroupWst10ProtoDataSet DataSet1 = new GroupWst10ProtoDataSet();
            GroupWst10ProtoDataSetTableAdapters.StaffTableAdapter staff1TableAdapter =
                new GroupWst10ProtoDataSetTableAdapters.StaffTableAdapter();
            staff1TableAdapter.FillByStaffActive(DataSet1.Staff);
            this.staffDataGridView.DataSource = DataSet1.Tables["Staff"]; // Fill datagrid view from dataset
            //this.DataGridView.DataSource = myDataTable;   // Fill datagrid view from data table
        }

        public void bindInctiveStaff()
        {
            // FILL INACTIVE USERS
            GroupWst10ProtoDataSet DataSet2 = new GroupWst10ProtoDataSet();
            GroupWst10ProtoDataSetTableAdapters.StaffTableAdapter staff2TableAdapter =
                new GroupWst10ProtoDataSetTableAdapters.StaffTableAdapter();
            staff2TableAdapter.FillByStaffInactive(DataSet2.Staff);
            this.staffDataGridView1.DataSource = DataSet2.Tables["Staff"]; // Fill datagrid view from dataset
            //this.DataGridView.DataSource = myDataTable;   // Fill datagrid view from data table
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if ( // If all data is input
                fNameTextBox.Text != "" && lNameTextBox.Text != "" && phoneNumberTextBox.Text != "" &&
                titleComboBox.Text != "" && eMailTextBox.Text != "" && comboBox1.Text != "" &&
                userNameTextBox.Text != "" && passwordTextBox.Text != "" && passwordConfirmTextBox.Text != ""
                )
            {
                try
                {
                    string phNumberString = phoneNumberTextBox.Text;
                    if (Regex.IsMatch(phNumberString, "\\A[0-9]{10}\\z"))
                    {
                        string Email = eMailTextBox.Text;
                        String expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

                        if (Regex.IsMatch(Email, expression))
                        {
                            if (Regex.Replace(Email, expression, string.Empty).Length == 0)
                            {
                                // Pasted Here
                                if (passwordTextBox.Text == passwordConfirmTextBox.Text) // check passwords match
                                {
                                    if (addRadioButton.Checked == true)
                                    {
                                        conn.Open();
                                        SqlCommand command = new SqlCommand("insert into Staff values ('" +
                                            fNameTextBox.Text + "','" +
                                            lNameTextBox.Text + "','" +
                                            phoneNumberTextBox.Text + "','" +
                                            int.Parse(titleComboBox.Text) + "','" +
                                            eMailTextBox.Text + "','" +
                                            comboBox1.Text + "','" +
                                            userNameTextBox.Text + "','" +
                                            passwordTextBox.Text + "','" + 1 + "')", conn);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Successfully Inserted a new User", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        conn.Close();
                                        clearEntries();
                                    }
                                    if (updateRadioButton.Checked == true)
                                    {
                                        conn.Open();
                                        SqlCommand command = new SqlCommand(
                                            "Update Staff set  Staff_F_Name = '" + fNameTextBox.Text +
                                            "',Staff_L_Name ='" + lNameTextBox.Text +
                                            "',Staff_Phone_No ='" + phoneNumberTextBox.Text +
                                            "',Staff_Title ='" + int.Parse(titleComboBox.Text) +
                                            "',Staff_Email ='" + eMailTextBox.Text +
                                            "',Staff_Gender ='" + comboBox1.Text +
                                            "',Staff_UserName ='" + userNameTextBox.Text +
                                            "',Staff_PassWord ='" + passwordTextBox.Text + "' where Staff_ID = '" + int.Parse(staffIDLabel.Text) + "'", conn);
                                        // TODO get staff id from memory

                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Successfully Updated a user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        conn.Close();
                                        clearEntries();
                                    }
                                    /*
                                    if (deleteRadioButton.Checked == true)
                                    {         
                                        conn.Open();
                                        SqlCommand command = new SqlCommand("Delete Staff where Staff_ID = '" +
                                            2 + "'", conn); // TODO : get the id automatically
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Successfully Deleted");
                                        conn.Close();
                                        clearEntries();
                                    }
                                    */

                                    //bindActiveStaff();
                                    //bindInctiveStaff();
                                }
                                else
                                {
                                    MessageBox.Show("Passwords do not Match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Address", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    else
                    {
                        // Nope, no match, do your worst
                        MessageBox.Show("Please Enter Valid Phone Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    bindActiveStaff();
                    bindInctiveStaff();
                    // Set Active users background to green
                    int rowscount = staffDataGridView.Rows.Count;
                    for (int i = 0; i < rowscount; i++)
                    {
                        staffDataGridView.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;
                    }
                    // Set Inactive users background to red
                    int rowscount1 = staffDataGridView1.Rows.Count;
                    for (int i = 0; i < rowscount1; i++)
                    {
                        staffDataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    }
                }
                catch (ArgumentException ex)
                {
                    // Syntax error in the regular expression
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else // Not All Data Input
            {
                MessageBox.Show("Missing Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FunctionsStaffManagementForm_Load(object sender, EventArgs e)
        {
            bindActiveStaff();
            bindInctiveStaff();

            // Set Active users background to green
            int rowscount = staffDataGridView.Rows.Count;
            for (int i = 0; i < rowscount; i++)
            {
                staffDataGridView.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;
            }

            // Set Inactive users background to red
            int rowscount1 = staffDataGridView1.Rows.Count;
            for (int i = 0; i < rowscount1; i++)
            {
                staffDataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
            }

            // Start out as small current payment form
            Location = new Point(20, 80);
            Size = new Size(478, 634);

            infoLabel.Visible = false; // Job Code details Hidden
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Confirmation         
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the edit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Clear All Entries - Do not change dataset
                clearEntries();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing
            }
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst10ProtoDataSet);
        }

        private void updateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearEntries();

            Location = new Point(20, 80);
            Size = new Size(1297, 634);
        }

        private void addRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            clearEntries();

            Location = new Point(20, 80);
            Size = new Size(478, 634);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int index = staffDataGridView.CurrentCell.RowIndex;
            String id = staffDataGridView.Rows[index].Cells[0].Value.ToString();
            using (SqlConnection con = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE Staff_ID = '" + int.Parse(id) + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        comboBox1.Text = sdr["Staff_Gender"].ToString();
                        fNameTextBox.Text = sdr["Staff_F_Name"].ToString();
                        lNameTextBox.Text = sdr["Staff_L_Name"].ToString();                                          
                        phoneNumberTextBox.Text = sdr["Staff_Phone_No"].ToString();
                        titleComboBox.Text = sdr["Staff_Title"].ToString();
                        eMailTextBox.Text = sdr["Staff_EMail"].ToString();
                        //genderComboBox.Text = sdr["Staff_Gender"].ToString();                        
                        userNameTextBox.Text = sdr["Staff_Username"].ToString();
                        passwordTextBox.Text = sdr["Staff_Password"].ToString();
                        passwordConfirmTextBox.Text = sdr["Staff_Password"].ToString();
                        staffIDLabel.Text = sdr["Staff_ID"].ToString();
                    }
                    con.Close();
                }
            }
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            // first check if any row is selected 
            bool flag = (staffDataGridView.SelectedRows != null && staffDataGridView.SelectedRows.Count > 0);
            if (flag == true)
            { 
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to deactivate this user ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    {
                        foreach (DataGridViewRow item in this.staffDataGridView.SelectedRows)
                        {
                            // Change: product_status = 0
                            int rowindex = staffDataGridView.CurrentCell.RowIndex;
                            int id = Convert.ToInt32(staffDataGridView.Rows[rowindex].Cells[0].Value.ToString());

                            try
                            {
                                conn.Open();
                                SqlCommand command = new SqlCommand(
                                    "Update Staff set staff_Active = '" + 0 +
                                     "' where Staff_ID = '" + id + "'", conn);
                                command.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                        MessageBox.Show("The User has been deactivated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.staffTableAdapter.FillByActive(this.groupWst10ProtoDataSet.Stock);
                        bindActiveStaff();
                        bindInctiveStaff();

                        // Set Active users background to green
                        int rowscount = staffDataGridView.Rows.Count;
                        for (int i = 0; i < rowscount; i++)
                        {
                            staffDataGridView.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;
                        }
                        // Set Inactive users background to red
                        int rowscount1 = staffDataGridView1.Rows.Count;
                        for (int i = 0; i < rowscount1; i++)
                        {
                            staffDataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do something else
                }              
            }
            else
            {
                MessageBox.Show("Please Select a row to de-activate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reinstateUserButton_Click(object sender, EventArgs e)
        {
            // first check if any row is selected 
            bool flag = (staffDataGridView1.SelectedRows != null && staffDataGridView1.SelectedRows.Count > 0);
            if (flag == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to re-instate this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    {
                        foreach (DataGridViewRow item in this.staffDataGridView1.SelectedRows)
                        {
                            // Change: product_status = 0
                            int rowindex = staffDataGridView1.CurrentCell.RowIndex;
                            int id = Convert.ToInt32(staffDataGridView1.Rows[rowindex].Cells[0].Value.ToString());

                            try
                            {
                                conn.Open();
                                SqlCommand command = new SqlCommand(
                                    "Update Staff set staff_Active = '" + 1 +
                                     "' where Staff_ID = '" + id + "'", conn);
                                command.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                        MessageBox.Show("The User has been re-activated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.staffTableAdapter.FillByActive(this.groupWst10ProtoDataSet.Stock);
                        bindActiveStaff();
                        bindInctiveStaff();

                        // Set Active users background to green
                        int rowscount = staffDataGridView.Rows.Count;
                        for (int i = 0; i < rowscount; i++)
                        {
                            staffDataGridView.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;
                        }
                        // Set Inactive users background to red
                        int rowscount1 = staffDataGridView1.Rows.Count;
                        for (int i = 0; i < rowscount1; i++)
                        {
                            staffDataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Red;
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    // do something else
                }
            }
            else
            {
                MessageBox.Show("Please Select a row to re-activate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Random rd = new Random();
                int number = rd.Next(100, 200);
                String fullFName = fNameTextBox.Text;
                String fullLName = lNameTextBox.Text;
                userNameTextBox.Text = fullFName.Substring(0, 3) + fullLName.Substring(0, 3) + number; // use datetime and create a unique number
            } catch(Exception)
            {
               
            }
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleComboBox_MouseEnter(object sender, EventArgs e)
        {
            infoLabel.Visible = true;
        }

        private void titleComboBox_MouseLeave(object sender, EventArgs e)
        {
            infoLabel.Visible = false;
        }
    }
    }
