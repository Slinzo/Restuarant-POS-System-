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
    public partial class IMStockQuantitManForm : Form
    {
        public IMStockQuantitManForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");

        void clearEntries()
        {
            stockNameTextBox.Clear();
            stockDescriptionTextBox.Clear();
            stockQuantityTextBox.Clear();
            offsetTextBox.Clear();
            stockUpdateIDTextBox.Clear();
        }

        public int getQuant(int id)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp"))
            {
                con.Open();
                using (SqlCommand q = con.CreateCommand())
                {
                    q.CommandText = String.Format(
                      @"select {0}
                          from Stock -- put actual table name here
                          where Stock_ID = @MyString", "Stock_Quantity");
                    q.Parameters.AddWithValue("@MyString", id);
                    using (var reader = q.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int value = Convert.ToInt32(reader[0]);
                            return value;
                        }
                        else
                        {
                            MessageBox.Show("Name For item Not Found", "Error"); //TODO: no such value: put your code here
                            return -1; // not Found
                        }
                    }
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (
                stockUpdateIDTextBox.Text != ""
               )
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
                                stockDescriptionTextBox.Text = sdr["stock_Discription"].ToString();
                                stockQuantityTextBox.Text = sdr["stock_Quantity"].ToString();
                            }
                            con.Close();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Item Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {

                }
            }
            else
            {
                MessageBox.Show("Please Enter All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            bool isProceed = true; // To test if the addition or subtraction of stock should continue
            if ( // All Data in
                stockNameTextBox.Text != "" &&
                stockDescriptionTextBox.Text != "" &&
                stockQuantityTextBox.Text != "" &&
                offsetTextBox.Text != ""
                ) 
            {
                int offsetValue = 0;
                int quant = 0;
                try
                {
                    offsetValue = int.Parse(offsetTextBox.Text);
                    // get quantity
                    quant = int.Parse(stockQuantityTextBox.Text);
                    // compare to actual
                }
                catch
                {
                    // TODO
                }

                //  do not decrease to negative (or add too much)
                // confirm dialoge

                int val = 0;
                if (addRadioButton.Checked == true)
                {
                    val = int.Parse(stockQuantityTextBox.Text) + int.Parse(offsetTextBox.Text);
                    // No limit set on addition yet
                }
                if (subRadioButton.Checked == true)
                {
                    val = int.Parse(stockQuantityTextBox.Text) - int.Parse(offsetTextBox.Text);
                    // limits on subtraction
                    if (val < 0)
                        isProceed = false;
                    else
                        isProceed = true;
                }

                if (isProceed) // Addition or subtraction allowed
                {
                    DialogResult dialogResult = MessageBox.Show("Are you Sure you want to edit Quantities?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        try
                        {
                            conn.Open();
                            SqlCommand command = new SqlCommand(
                                "Update Stock set  stock_Quantity = '" + val +
                                "' where Stock_ID = '" + stockUpdateIDTextBox.Text + "'", conn);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Quantity Successfully Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        offsetTextBox.Text = "";
                        stockUpdateIDTextBox.Focus();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                   
                } else // If addition or subtraction not allowed
                {
                    if (val < 0)
                    {
                        MessageBox.Show("Cannot Process - Final Stock is below 0",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } else // Not All data in
            {
                MessageBox.Show("Please Enter All Data" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            changeButton.Text = "Increment Stock";
            clearEntries();
        }

        private void subRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            changeButton.Text = "Decrement Stock";
            clearEntries();
        }

        private void newSearchButton_Click(object sender, EventArgs e)
        {
            clearEntries();
        }

        private void stockUpdateIDTextBox_TextChanged(object sender, EventArgs e)
        {
            stockNameTextBox.Clear();
            stockDescriptionTextBox.Clear();
            stockQuantityTextBox.Clear();
            offsetTextBox.Clear();
            //stockUpdateIDTextBox.Clear();
        }

        private void IMStockQuantitManForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // keep to refresh DB when this form closes
        }

        private void IMStockQuantitManForm_Load(object sender, EventArgs e)
        {

        }
    }
}
