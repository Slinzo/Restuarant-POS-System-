using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LupaISPrototype
{
    public partial class SubSysInventoryManForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");

        public SubSysInventoryManForm()
        {
            InitializeComponent();
        }      

        private void SubSysInventoryManForm_Load(object sender, EventArgs e)
        {           
            this.stockTableAdapter.FillByActiveInvetoryItem(this.groupWst10ProtoDataSet.Stock);

            // Maximise Form
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
        }

        public void refreshDB()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from Stock WHERE Stock_Active = '1'", conn);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                inventoryDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshDBButton_Click(object sender, EventArgs e)
        {
            refreshDB();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchByIDRadioButton.Checked == true)
            {
                try
                {
                    SqlCommand command = new SqlCommand("select * from Stock where Stock_ID = '" +
                        int.Parse(searchTextBox.Text) + "' AND Stock_Active = 1", conn);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    inventoryDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (searchByNameRadioButton.Checked == true)
            {
                try
                {
                    SqlCommand command = new SqlCommand("select * from Stock where Stock_Name  like  '%" +
                               searchTextBox.Text + "%' AND Stock_Active = 1", conn);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    inventoryDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            // for dynamic search
            if (dynamicSearchCheckBox.Checked == true && searchByNameRadioButton.Checked == true)
            {
                try
                {
                    SqlCommand command = new SqlCommand("select * from Stock where Stock_Name  like  '%" +
                           searchTextBox.Text + "%' AND Stock_Active = 1", conn);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    inventoryDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // for dynamic search
            if (dynamicSearchCheckBox.Checked == true && searchByIDRadioButton.Checked == true)
            {
                try
                {
                    SqlCommand command = new SqlCommand("select * from Stock where Stock_ID  like  '%" +
                           searchTextBox.Text + "%' AND Stock_Active = 1", conn);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    inventoryDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // If no input 
            if (searchTextBox.Text == "")
            {
                // Do Nothing
            }

            if (searchTextBox.Text == "" && (dynamicSearchCheckBox.Checked != true))
            {
                try {
                    SqlCommand command = new SqlCommand("select * from Stock WHERE Stock_Active = 1", conn);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    inventoryDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchByIDRadioButton_TextChanged(object sender, EventArgs e)
        {
            searchTextBox.Text = "";

            try {
                SqlCommand command = new SqlCommand("select * from Stock WHERE Stock_Active = 1", conn);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                inventoryDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchByNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchTextBox.Clear();

            try 
            {
                SqlCommand command = new SqlCommand("select * from Stock WHERE Stock_Active = 1", conn);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                inventoryDataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dynamicSearchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dynamicSearchCheckBox.Checked == true)
            {
                searchTextBox.Clear();
            }
            if (dynamicSearchCheckBox.Checked == false)
            {
                searchTextBox.Clear();
            }
        }

        // Refresh DB as Stock Management form closes
        private void manageInventoryButton_Click(object sender, EventArgs e)
        {
            IMStockManagementForm smf = new IMStockManagementForm();  // create new isntance of form
            smf.FormClosed += new FormClosedEventHandler(IMStockManagementForm_FormClosed); // add handler to catch when child form is closed
            smf.ShowDialog();
        }
        void IMStockManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // when child form is closed, this code is executed
            refreshDB(); // or update()
        }
        
        // Refresh DB as Stock Quantity form closes
        private void editStockInventoryButton_Click(object sender, EventArgs e)
        {
            IMStockQuantitManForm sqmf = new IMStockQuantitManForm(); //create new isntance of form
            sqmf.FormClosed += new FormClosedEventHandler(IMStockQuantitManForm_FormClosed); //add handler to catch when child form is closed
            sqmf.ShowDialog();
        }
        private void IMStockQuantitManForm_FormClosed(object sender, FormClosedEventArgs e)
        {           
            refreshDB(); //when child form is closed, this code is executed
        }
     
        private void button1_Click(object sender, EventArgs e)  // Refresh DB as actdeact form closes
        {
            IMSActDeactStockForm ads = new IMSActDeactStockForm(); //create new isntance of form
            ads.FormClosed += new FormClosedEventHandler(IMSActDeactStockForm_FormClosed); //add handler to catch when child form is closed
            ads.ShowDialog();
        }

        void IMSActDeactStockForm_FormClosed(object sender, FormClosedEventArgs e)
        {           
            refreshDB();  //when child form is closed, this code is executed
        }

        private void searchByIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from Stock WHERE Stock_Active = 1", conn);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                inventoryDataGridView.DataSource = dt;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox1.ReadOnly = false;
            }
            else
            {
                textBox1.ReadOnly = true;
            }
        }

        private void lowStockButton_Click(object sender, EventArgs e)
        {
            try
            {
                searchTextBox.Text = "";   
                int quant = Convert.ToInt32(textBox1.Text);
               
                try
                {
                    SqlCommand command = new SqlCommand("select * from Stock WHERE Stock_Active = 1 AND stock_Quantity < '" + quant + "'" , conn);
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    inventoryDataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
                // Chance background colour to orange for low stock items
                int rowscount = inventoryDataGridView.Rows.Count;
                for (int i = 0; i < rowscount; i++)
                {
                    inventoryDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Orange;
                }
                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
