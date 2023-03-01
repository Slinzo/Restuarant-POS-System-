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
    public partial class IMStockManagementForm : Form
    {
        public IMStockManagementForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");

        void clearEntries()
        {
            stockNameTextBox.Clear();
            stockDescriptionComboBox.Text = "";
            stockPurchasePTextBox.Clear();
            stockSellingPTextBox.Clear();
            stockQuantityTextBox.Clear();
        }

        private void IMStockManagementForm_Load(object sender, EventArgs e)
        {
            stockSearchGroupBox.Enabled = false;
        }

        private void insertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            stockSearchGroupBox.Enabled = false;
            stockUpdateIDTextBox.Clear();

            clearEntries();
        }

        private void updateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            stockSearchGroupBox.Enabled = true;
            stockUpdateIDTextBox.Clear();

            clearEntries();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (stockUpdateIDTextBox.Text != "") // Text Entry Not Empty
            {
                try
                {
                    string constr = @"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp";
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT stock_Name, stock_Discription, stock_Purchase_Price, stock_Selling_Price, stock_Quantity, stock_Active FROM Stock WHERE Stock_ID = " + stockUpdateIDTextBox.Text))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = con;
                            con.Open();
                            using (SqlDataReader sdr = cmd.ExecuteReader())
                            {
                                sdr.Read();
                                stockNameTextBox.Text = sdr["stock_Name"].ToString();
                                stockDescriptionComboBox.Text = sdr["stock_Discription"].ToString();
                                stockPurchasePTextBox.Text = sdr["stock_Purchase_Price"].ToString();
                                stockSellingPTextBox.Text = sdr["stock_Selling_Price"].ToString();
                                stockQuantityTextBox.Text = sdr["stock_Quantity"].ToString();
                            }
                            con.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No Item Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stockUpdateIDTextBox.Clear();
                }
                finally
                {

                }
            } else // No Data Enrty
            {
                MessageBox.Show("Please Enter Search Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if ( // All data in
                stockNameTextBox.Text != "" &&
                stockDescriptionComboBox.Text != "" &&
                stockPurchasePTextBox.Text != "" &&
                stockSellingPTextBox.Text != "" &&
                stockQuantityTextBox.Text != ""
                )
            {
                try
                { // Check Data Types Input 
                    if ( // Quantity greater than zero
                            int.Parse(stockQuantityTextBox.Text) >= 0
                        )
                    {

                        if (insertRadioButton.Checked == true)
                        {

                            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to add this Product", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                //do something
                                // Insert
                                try
                                {
                                    conn.Open();
                                    SqlCommand command = new SqlCommand("insert into Stock values ('" +
                                        stockNameTextBox.Text + "','" +
                                        stockDescriptionComboBox.Text + "','" +
                                        Convert.ToDecimal(stockPurchasePTextBox.Text) + "','" +
                                        Convert.ToDecimal(stockSellingPTextBox.Text) + "','" +
                                        Convert.ToInt32(stockQuantityTextBox.Text) + "','" +
                                        1 + "')", conn);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Product Item Successfully Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    conn.Close();
                                    clearEntries();

                                    // Reset POS Menu
                                    
                                    // Reset Inventory
                                    
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {
                                    
                                }

                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //do something else
                            }

                        }
                        if (updateRadioButton.Checked == true)
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to update this Product", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                //do something
                                // Update
                                try
                                {
                                    conn.Open();
                                    SqlCommand command = new SqlCommand(
                                        "Update Stock set  stock_Name = '" + stockNameTextBox.Text +
                                        "',stock_Discription ='" + stockDescriptionComboBox.Text +
                                        "',stock_Purchase_Price ='" + decimal.Parse(stockPurchasePTextBox.Text) +
                                        "',stock_Selling_Price ='" + decimal.Parse(stockSellingPTextBox.Text) +
                                        "',stock_Quantity ='" + int.Parse(stockQuantityTextBox.Text) +
                                        "' where Stock_ID = '" + int.Parse(stockUpdateIDTextBox.Text) + "'", conn);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Product Item Successfully Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    conn.Close();
                                    clearEntries();
                                    stockUpdateIDTextBox.Clear();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {

                                }
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //do something else
                            }

                        }
                    }
                    else // Quantity less than zero
                    {
                        MessageBox.Show("Cannot accept quantity less than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } catch(FormatException ex) // Input Validation
                {
                    MessageBox.Show(ex.Message , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // Not All data in 
            {
                MessageBox.Show("Please Enter All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void stockUpdateIDTextBox_TextChanged(object sender, EventArgs e)
        {
            clearEntries();
        }

        void IMStockManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // keep to refresh DB when this form closes
        }

    }
}