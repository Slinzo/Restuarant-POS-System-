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
    public partial class POSSlip : Form
    {
        public POSSlip()
        {
            InitializeComponent();
        }

        // VARIABLE DECLARATION
        public static bool IS_SLIP = false; // To indicate successful slip view/print and exit

        // METHOD TO GET PRICE FOR STOCK ITEM
        public double getPrice(String name)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp"))
            {
                con.Open();
                using (SqlCommand q = con.CreateCommand())
                {
                    q.CommandText = String.Format(
                      @"select {0} from Stock where stock_Name = @MyString", "stock_Selling_Price");
                    q.Parameters.AddWithValue("@MyString", name);
                    using (var reader = q.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Double value = Convert.ToDouble(reader[0]);
                            con.Close();
                            return value;
                        }
                        else
                        {
                            MessageBox.Show("Price For item Not Found", "Error");  // No such value
                            con.Close();
                            return 0.0;
                        }
                    }
                }
            }
        }

        // METHOD TO GET AMOUNT PAID FOR ORDER
        public double getPaidAmount()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp"))
            {
                con.Open();
                using (SqlCommand q = con.CreateCommand())
                {
                    q.CommandText = String.Format(
                      @"select {0} from tblOrder where Order_ID = @MyString", "Order_Payment");
                    q.Parameters.AddWithValue("@MyString", SubSysPOSForm.ORDER_ID);
                    using (var reader = q.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Double value = Convert.ToDouble(reader[0]);
                            con.Close();
                            return value;
                        }
                        else
                        {
                            MessageBox.Show("Price For item Not Found", "Error");  // No such value
                            con.Close();
                            return 0.0;
                        }
                    }
                }
            }
        }

        private void POSSlip_Load(object sender, EventArgs e)
        {          
                Location = new Point(100, 80);
                Size = new Size(386, 489);

                loadSlip();          
        }
    
        public void loadSlip()
        {
            try
            {
                // Clear listbox
                slipListBox.Items.Clear();
                slipListBox.Items.Add("------------------------------------------------------------");
                slipListBox.Items.Add("                   LUPA RESTAURANT                           ");
                slipListBox.Items.Add("------------------------------------------------------------");
                String headings = String.Format("{0,-15}{1,-50}{2,20}", "Quantity", "Item", "Subtotal");
                slipListBox.Items.Add(headings);
                slipListBox.Items.Add("");

                // get the order item ID of that order
                //int rowindex = tblOrderDataGridView.CurrentCell.RowIndex;
                int OrderId = SubSysPOSForm.ORDER_ID;

                // Get Order Item Id
                double total = 0.0; // To store slip total
                String q0 = "";
                SqlConnection cn0 = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
                String sqlStm0 = "SELECT Stock_ID FROM Order_Item WHERE Order_ID = '" + OrderId + "'";
                SqlCommand cmd0 = new SqlCommand(sqlStm0, cn0);
                cmd0.Parameters.Add(new SqlParameter("@questionno", SqlDbType.NVarChar));
                cmd0.Parameters["@questionno"].Value = q0;
                cn0.Open();
                var reader0 = cmd0.ExecuteReader();
                //MessageBox.Show("GOT ORDER ID " + OrderId.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Get All Stock Id's
                //itemLine = ""; // Line To add in list box in Slip
                while (reader0.Read())
                {
                    String stockId = reader0[0].ToString(); // The Stock Id
                                                        //MessageBox.Show("GETTING STOCK ID 1 " + stockId , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    String q1 = "";
                    SqlConnection cn1 = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
                    String sqlStm1 = "SELECT Stock_ID FROM Order_Item WHERE Order_ID = '" + OrderId + "'";
                    SqlCommand cmd1 = new SqlCommand(sqlStm1, cn1);
                    cmd1.Parameters.Add(new SqlParameter("@questionno", SqlDbType.NVarChar));
                    cmd1.Parameters["@questionno"].Value = q1;
                    cn1.Open();
                    var reader1 = cmd1.ExecuteReader();

                    if (reader1.Read())
                    {
                        stockId = reader0[0].ToString(); // The Stock Id
                        //MessageBox.Show("GETTING STOCK ID 2 " + stockId.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Get the Stock Quantity
                        //String stockId = reader[0].ToString();
                        String q2 = "";
                        SqlConnection con2 = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
                        String sqlStm2 = "SELECT Item_Quantity FROM Order_Item WHERE Stock_ID = '" + stockId + "'";
                        SqlCommand cmd2 = new SqlCommand(sqlStm2, con2);
                        cmd2.Parameters.Add(new SqlParameter("@questionno", SqlDbType.NVarChar));
                        cmd2.Parameters["@questionno"].Value = q2;
                        con2.Open();
                        var reader2 = cmd2.ExecuteReader();

                        if (reader2.Read())
                        {
                            //MessageBox.Show("I'M READING QUANTITIES ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            String item1 = reader2[0].ToString();
                            //MessageBox.Show(item, "Item");
                            //slipListBox.Items.Add(item);
                            //itemLine += item1 + "\t";
                            String itemQuantity = item1;
                            //MessageBox.Show("Added " + item1 , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //slipListBox.Items.Add(item1);

                            // Get Stock Item name                         
                            String q3 = "";
                            SqlConnection con3 = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
                            String sqlStm3 = "SELECT Stock_Name FROM Stock WHERE Stock_ID = '" + stockId + "'";
                            SqlCommand cmd3 = new SqlCommand(sqlStm3, con3);
                            cmd3.Parameters.Add(new SqlParameter("@questionno", SqlDbType.NVarChar));
                            cmd3.Parameters["@questionno"].Value = q3;
                            con3.Open();
                            var reader3 = cmd3.ExecuteReader();
                            if (reader3.Read())
                            {
                                String item2 = reader3[0].ToString();
                                //MessageBox.Show(item, "Item");
                                //slipListBox.Items.Add(item);
                                //itemLine += item2 + "\t\t\t";
                                String itemName = item2;
                                //MessageBox.Show("Added " + item2, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Get Price and calculate sub total
                                double price = getPrice(item2);
                                double subtotal = price * int.Parse(item1);
                                total += subtotal;
                                // Add subtotal to slip line
                                String subT = " R " + subtotal.ToString();

                                // Add Line To Slip
                                String items = String.Format("{0,-15}{1,-50}{2,20}", itemQuantity, itemName, subT);
                                slipListBox.Items.Add(items);
                                //itemLine = "";
                            }
                        }
                    }
                } // End while read

                // Get Paid Amount 
                double paid = getPaidAmount();

                // Add Sub Total To Slip
                DateTime dt = DateTime.Now;
                string accessDate = dt.ToString("dd/MM/yyyy h:mm tt");
                slipListBox.Items.Add("");
                slipListBox.Items.Add("------------------------------------------------------------");
                slipListBox.Items.Add("TOTAL DUE   = R " + SubSysPOSForm.AMOUNT_DUE.ToString());
                slipListBox.Items.Add("AMOUNT PAID = R " + paid.ToString());
                double change = paid - SubSysPOSForm.AMOUNT_DUE; // TODO
                slipListBox.Items.Add("CHANGE      = R " + change.ToString());
                slipListBox.Items.Add("");
                slipListBox.Items.Add("PAYMENT TIME : " + accessDate);
                slipListBox.Items.Add("ORDER NUMBER : " + OrderId);
                slipListBox.Items.Add("------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR LOADING SLIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void printButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            IS_SLIP = true;
            this.Close();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print Settings
            Font printFont = new Font("Arial", 10);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float verticalPrintPositionFloat = e.MarginBounds.Top;
            float horizontallPrintPositionFloat = e.MarginBounds.Left;
            float lineHeightFloat = printFont.GetHeight();

            // Print Heading

            // Loop through list for printing
            for (int indexInteger = 0; indexInteger < slipListBox.Items.Count; indexInteger++)
            {
                e.Graphics.DrawString(slipListBox.Items[indexInteger].ToString(),
                    printFont, Brushes.Black, horizontallPrintPositionFloat, verticalPrintPositionFloat);
                verticalPrintPositionFloat += lineHeightFloat;
            }
        }
    }
}
