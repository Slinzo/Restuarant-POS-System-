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
    public partial class SubSysPOSForm : Form
    {
        // GLOBAL VARIABLE DECLARATIONS 
        private const double TAX = 0.15; // Tax rate
        public static double AMOUNT_DUE = 0.0;
        public static int ORDER_ID = 0; // To allow for the payment recording
        //public static int PAYMENT_STATE = 1;   // To see if payment is for current order(0) or old order(1)
        //public static int SLIP_STATE = 1;   // To see if slip is for current order(0) or old order(1)
        
        // CONNECTIONS
        SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp");

        // PROCESS ORDER CONNECTION STRINGS
        SqlConnection conItem = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp");
        SqlConnection conOrder = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp");
        SqlConnection conpaym = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp");

        public SubSysPOSForm()
        { InitializeComponent(); }

        // METHODS
        public void buildMenu()
        {
            /* CREATE MENU DISPLAY : Read all DataBase rows to get the Menu Items Names and create Menu for each category */
            // 1. Pizza Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command0 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Pizza'", con);
            SqlDataAdapter sd0 = new SqlDataAdapter(command0);
            DataSet ds0 = new DataSet();
            sd0.Fill(ds0);
            int x0 = 10;
            int y0 = 10;
            for (int i = 0; i < ds0.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds0.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelPizza", menuItemName, x0, y0);
                y0 += 60;
            }
            con.Close();

            // 2. Drink Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command1 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Drink'", con);
            SqlDataAdapter sd1 = new SqlDataAdapter(command1);
            DataSet ds1 = new DataSet();
            sd1.Fill(ds1);
            int x1 = 10;
            int y1 = 10;
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds1.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelDrink", menuItemName, x1, y1);
                y1 += 60;
            }
            con.Close();

            // 3. Cocktail Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command2 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Cocktail'", con);
            SqlDataAdapter sd2 = new SqlDataAdapter(command2);
            DataSet ds2 = new DataSet();
            sd2.Fill(ds2);
            int x2 = 10;
            int y2 = 10;
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds2.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelCocktail", menuItemName, x2, y2);
                y2 += 60;
            }
            con.Close();

            // 4. Mocktail Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command3 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Mocktail'", con);
            SqlDataAdapter sd3 = new SqlDataAdapter(command3);
            DataSet ds3 = new DataSet();
            sd3.Fill(ds3);
            int x3 = 10;
            int y3 = 10;
            for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds3.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelMocktail", menuItemName, x3, y3);
                y3 += 60;
            }
            con.Close();

            // 5. Antipasti Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command4 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Antipasti'", con);
            SqlDataAdapter sd4 = new SqlDataAdapter(command4);
            DataSet ds4 = new DataSet();
            sd4.Fill(ds4);
            int x4 = 10;
            int y4 = 10;
            for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds4.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelAntipasti", menuItemName, x4, y4);
                y4 += 60;
            }
            con.Close();

            // 6. Secondi Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command5 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Secondi'", con);
            SqlDataAdapter sd5 = new SqlDataAdapter(command5);
            DataSet ds5 = new DataSet();
            sd5.Fill(ds5);
            int x5 = 10;
            int y5 = 10;
            for (int i = 0; i < ds5.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds5.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelSecondi", menuItemName, x5, y5);
                y5 += 60;
            }
            con.Close();

            // 7. Dolce Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command6 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Dolce'", con);
            SqlDataAdapter sd6 = new SqlDataAdapter(command6);
            DataSet ds6 = new DataSet();
            sd6.Fill(ds6);
            int x6 = 10;
            int y6 = 10;
            for (int i = 0; i < ds6.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds6.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelDolce", menuItemName, x6, y6);
                y6 += 60;
            }
            con.Close();

            // 8. Pasta Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command7 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Pasta'", con);
            SqlDataAdapter sd7 = new SqlDataAdapter(command7);
            DataSet ds7 = new DataSet();
            sd7.Fill(ds7);
            int x7 = 10;
            int y7 = 10;
            for (int i = 0; i < ds7.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds7.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelPasta", menuItemName, x7, y7);
                y7 += 60;
            }
            con.Close();

            // 9. Wine Menu Items : Create a dataset from the Menu Database Table and create the menu list
            con.Open();
            SqlCommand command8 = new SqlCommand("select * from Stock WHERE stock_Active = 1 AND stock_Discription = 'Wine'", con);
            SqlDataAdapter sd8 = new SqlDataAdapter(command8);
            DataSet ds8 = new DataSet();
            sd8.Fill(ds8);
            int x8 = 10;
            int y8 = 10;
            for (int i = 0; i < ds8.Tables[0].Rows.Count; i++)
            {
                string menuItemName = ds8.Tables[0].Rows[i][1].ToString();
                createMenuItems("panelWine", menuItemName, x8, y8);
                y8 += 60;
            }
            con.Close();
        }

        void createMenuItemsButtons(string place, string str, int startTopLPointX, int startTopLPointY)
        {
            Button button = new Button();
            button.Text = str;
            button.Location = new Point(startTopLPointX, startTopLPointY);
            button.Size = new Size(250, 50);
            button.Visible = true;
            button.BringToFront();
            //(Controls[TMT] as Button).Text = "Hullo";
            //itemsPanel.Controls.Add(button);
            (Controls[place] as Panel).Controls.Add(button); // # Added 
            button.Click += new EventHandler(this.MenuItemsButtonHandler);
        } // End createMenuItemsButtons   
      
        void createMenuItems(string s1, string s2, int x, int y)   
        {
            // Method to Create Menu Items
            for (int i = 0; i < 5; i++)
                createMenuItemsButtons(s1, s2, x, y);
        }

        void MenuItemsButtonHandler(object sender, EventArgs e)
        {
            Button Mybutton = sender as Button; // identify which button was clicked and perform necessary actions
            string menuItemName = Mybutton.Text;

            int quantityInitial = 1; // Initial quantity added is 1
            int quantityStock = getQuantity(menuItemName); // current quantity in stock

            // check if the amounts match 
            if ( quantityStock >= quantityInitial) // Compare to current quantity - If enough stock to buy : Allow to add to invoice
            {
                double Price = getPrice(menuItemName);
                double initialTotal = 1 * Price;
                orderListDataGridView.Rows.Add(menuItemName, 1, Price, initialTotal);
                updatePaymentDue(); 
            }
            else 
            {
                // If NOT enough stock to buy
                MessageBox.Show("Sorry Not Enough Stock: Only " + quantityStock + " Items Available\n" + menuItemName,
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        void quant(int n)
        {
            /* Method to change the quantity of the items in the list */
            try
            {                
                int quantityInitial = n; // Get the orded quantity
                
                int rowindex = orderListDataGridView.CurrentCell.RowIndex;
                String stockItemName = orderListDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                int quantityStock = getQuantity(stockItemName); // current quantity in stock
                           
                int numRows = orderListDataGridView.Rows.Count - 1;  // count number of rows of items
                if (numRows > 0)
                {
                    if
                    ( quantityStock >= quantityInitial) // Compare odered stock quantity to quantity n stock : If enough stock to buy
                    {                            
                        rowindex = orderListDataGridView.CurrentCell.RowIndex; // Get current index
                        stockItemName = orderListDataGridView.Rows[rowindex].Cells[0].Value.ToString(); // Extract the item name

                        string s = getItem(stockItemName);  // Get name of the order item from the datagrid view

                        changeQuantity(stockItemName, n); // change quantity of selected item in the slip grid                      
                        updatePaymentDue();  // update payment displays
                    }
                    else 
                    {
                        // If NOT enough stock to buy
                        MessageBox.Show("Sorry Not Enough Stock: Only " + quantityStock + " Items Available\n" + stockItemName,
                            "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No Items Selected to Change Quantity", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception) // Nothing to select on data grid view check
            {
                MessageBox.Show("Please Make A Valid Selection To Change Quantity Value", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method ----------------------------------------------------
        void changeQuantity(string s, int n)
        {
            double p = getPrice(s); // get price from DB

            // update the amount on the datagrid view
            int rowindex = orderListDataGridView.CurrentCell.RowIndex;
            orderListDataGridView.Rows[rowindex].Cells[1].Value = n;
            orderListDataGridView.Rows[rowindex].Cells[2].Value = p;
            orderListDataGridView.Rows[rowindex].Cells[3].Value = n * p;
        }

        public int getQuantity(String name)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp"))
            {
                con.Open();
                using (SqlCommand q = con.CreateCommand())
                {
                    q.CommandText = String.Format(
                      @"select {0} from Stock where stock_Name = @MyParameter", "stock_Quantity");
                    q.Parameters.AddWithValue("@MyParameter", name);
                    using (var reader = q.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int value = Convert.ToInt32(reader[0]);
                            con.Close();
                            return value;
                        }
                        else
                        {
                            MessageBox.Show("Staff DataBase Data Not Found : Item Quantity", "Error Finding Data", MessageBoxButtons.OK, MessageBoxIcon.Error);  // No such value
                            con.Close();
                            return 0;
                        }
                    }
                }
            }
        }

        public double getPrice(String name)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp"))
            {
                con.Open();
                using (SqlCommand q = con.CreateCommand())
                {
                    q.CommandText = String.Format(
                      @"select {0} from Stock where stock_Name = @MyParameter", "stock_Selling_Price");
                    q.Parameters.AddWithValue("@MyParameter", name);
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
                            MessageBox.Show("Staff DataBase Data Not Found : Item Price", "Error Finding Data", MessageBoxButtons.OK, MessageBoxIcon.Error);  // No such value
                            con.Close();
                            return 0.0;
                        }
                    }
                }
            }
        }

        public string getItem(string name)
        {
            // To get item name from datagrid and return the name of item at that row
            //SqlConnection con = new SqlConnection(@"Data Source=146.230.177.46\istn3;Initial Catalog=ist3cb;Persist Security Info=True;User ID=ist3cb;Password=rwgteg");
            using (SqlConnection con = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp"))
            {
                con.Open();
                using (SqlCommand q = con.CreateCommand())
                {
                    q.CommandText = String.Format(
                      @"select {0} from Stock where Stock_Name = @MyParameter", "Stock_Name");
                    q.Parameters.AddWithValue("@MyParameter", name);
                    using (var reader = q.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string value = reader[0].ToString();
                            con.Close();
                            return value;
                        }
                        else
                        {
                            MessageBox.Show("Staff DataBase Data Not Found : Item Name", "Error Finding Data", MessageBoxButtons.OK, MessageBoxIcon.Error); // no such value
                            con.Close();
                            return "";
                        }
                    }
                }
            }
        }

        public int getId(string name)
        {
            // To get item name from datagrid and return the ID of item at that row
            using (SqlConnection con = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp"))
            {
                con.Open();
                using (SqlCommand q = con.CreateCommand())
                {
                    q.CommandText = String.Format(
                      @"select {0} from Stock where Stock_Name = @MyParameter", "Stock_ID");
                    q.Parameters.AddWithValue("@MyParameter", name);
                    using (var reader = q.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int value = Convert.ToInt32(reader[0]);
                            con.Close();
                            return value;
                        }
                        else
                        {
                            MessageBox.Show("Staff DataBase Data Not Found : Item ID", "Error Finding Data", MessageBoxButtons.OK, MessageBoxIcon.Error); //TODO: no such value: put your code here+
                            con.Close();
                            return -1; 
                        }
                    }
                }
            }
        }

        void updatePaymentDue()
        {            
            double subtot = 0; // the total of all the items
            if (orderListDataGridView.Rows.Count > 1) // Calculate only if rows more than 1
            {
                for (int i = 0; i < orderListDataGridView.Rows.Count; i++)
                {
                    // subtotal += Price per row * quantities in the row
                    subtot += Convert.ToDouble(orderListDataGridView.Rows[i].Cells[2].Value) * Convert.ToInt32(orderListDataGridView.Rows[i].Cells[1].Value);
                }
            }
            subtotalLabel.Text = (subtot).ToString("C");
            taxLabel.Text = (subtot * TAX).ToString("C");
            amountDueLabel.Text = (subtot * (1 + TAX)).ToString();
        } // End updatePaymentDue

        private void SubSysPOSForm_Load(object sender, EventArgs e)
        {
            panelDrink.Visible = true;
            panelWine.Visible = false;
            panelCocktail.Visible = false;
            panelMocktail.Visible = false;
            panelPizza.Visible = false;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = false;
            panelDolce.Visible = false;
            panelPasta.Visible = false;

            drinkButton.Select();

            buildMenu();

            // Set initial Payment details
            subtotalLabel.Text = (0).ToString("C");
            taxLabel.Text = (0 * TAX).ToString("C");
            amountDueLabel.Text = (0 * (1 + TAX)).ToString();

            // Maximise Form
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;

            // De activate most of the controls
            cancelButton.Enabled = false;
            orderDoneButton.Enabled = false;
        } // End Form load

        private void pizzaButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = false;
            panelWine.Visible = false;
            panelCocktail.Visible = false;
            panelMocktail.Visible = false;
            panelPizza.Visible = true;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = false;
            panelDolce.Visible = false;
            panelPasta.Visible = false;
        }

        private void drinkButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = true;
            panelWine.Visible = false;
            panelCocktail.Visible = false;
            panelMocktail.Visible = false;
            panelPizza.Visible = false;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = false;
            panelDolce.Visible = false;
            panelPasta.Visible = false;
        }

        private void wineButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = false;
            panelWine.Visible = true;
            panelCocktail.Visible = false;
            panelMocktail.Visible = false;
            panelPizza.Visible = false;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = false;
            panelDolce.Visible = false;
            panelPasta.Visible = false;
        }

        private void cocktailButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = false;
            panelWine.Visible = false;
            panelCocktail.Visible = true;
            panelMocktail.Visible = false;
            panelPizza.Visible = false;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = false;
            panelDolce.Visible = false;
            panelPasta.Visible = false;
        }

        private void mocktailButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = false;
            panelWine.Visible = false;
            panelCocktail.Visible = false;
            panelMocktail.Visible = true;
            panelPizza.Visible = false;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = false;
            panelDolce.Visible = false;
            panelPasta.Visible = false;
        }

        private void antipastiButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = false;
            panelWine.Visible = false;
            panelCocktail.Visible = false;
            panelMocktail.Visible = false;
            panelPizza.Visible = false;
            panelAntipasti.Visible = true;
            panelSecondi.Visible = false;
            panelDolce.Visible = false;
            panelPasta.Visible = false;
        }

        private void secondiButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = false;
            panelWine.Visible = false;
            panelCocktail.Visible = false;
            panelMocktail.Visible = false;
            panelPizza.Visible = false;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = true;
            panelDolce.Visible = false;
            panelPasta.Visible = false;
        }

        private void dolceButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = false;
            panelWine.Visible = false;
            panelCocktail.Visible = false;
            panelMocktail.Visible = false;
            panelPizza.Visible = false;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = false;
            panelDolce.Visible = true;
            panelPasta.Visible = false;
        }

        private void pastaButton_Click(object sender, EventArgs e)
        {
            panelDrink.Visible = false;
            panelWine.Visible = false;
            panelCocktail.Visible = false;
            panelMocktail.Visible = false;
            panelPizza.Visible = false;
            panelAntipasti.Visible = false;
            panelSecondi.Visible = false;
            panelDolce.Visible = false;
            panelPasta.Visible = true;
        }

        private void number1Button_Click(object sender, EventArgs e)
        {
            quant(1); // can use the text property of the button as an argument
        }

        private void number2Button_Click(object sender, EventArgs e)
        {
            quant(2);
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            quant(3);
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
            quant(4);
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
            quant(5);
        }

        private void number6Button_Click(object sender, EventArgs e)
        {
            quant(6);
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            quant(7);
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            quant(8);
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            quant(9);
        }

        private void number10Button_Click(object sender, EventArgs e)
        {
            quant(10);
        }
        
        private void manualTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            /* Method to manually enter the quantity of a stock product in the list */
            if (e.KeyCode == Keys.Enter) //If key pressed is ENTER
            {
                if (manualTextBox.Text != "") // TODO Make it take only numbers
                {
                    try
                    {
                        quant(int.Parse(manualTextBox.Text));
                        manualTextBox.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        manualTextBox.Clear();
                    }
                } // end if
            } // end if
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            try
            {  // Nothing to select on data grid view check

                // What to do if there is a valid selection on the datagrid view
                // first check if any row is selected 
                bool flag = (orderListDataGridView.SelectedRows != null && orderListDataGridView.SelectedRows.Count > 0);
                if (flag == true)
                {
                    // Get index
                    int rowindex = orderListDataGridView.CurrentCell.RowIndex;
                    // Get Stock Name
                    String stockName = orderListDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Remove " + stockName + " From Invoice ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Remove a selected item in the datagrid
                        foreach (DataGridViewRow item in this.orderListDataGridView.SelectedRows)
                        {
                            orderListDataGridView.Rows.RemoveAt(item.Index);
                        }
                        MessageBox.Show(stockName + " Removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                        updatePaymentDue();  // update payment displays
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }

                }
                else
                {
                    MessageBox.Show("Please select row of item to remove", "Error Removing Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) // Nothing to select on data grid view check
            {
                MessageBox.Show("Please Make A Valid Selection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Clear the datagrid view
            orderListDataGridView.Rows.Clear();
            orderListDataGridView.Refresh();
            
            updatePaymentDue(); // update payment displays
        }

        // GET LAST INSERTED ID TO PREPARE FOR PAYMENT
        public int getLastInsertedDBID()
        {
            try
            {
                String q = "";
                SqlConnection cn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
                String sqlStm = "SELECT MAX(Order_ID) FROM tblOrder";
                SqlCommand cmd = new SqlCommand(sqlStm, cn);
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar));
                cmd.Parameters["@id"].Value = q;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int prevInsertedOrderID = Convert.ToInt32(reader[0]);
                    cn.Close();
                    return prevInsertedOrderID;
                }
                else
                {
                    cn.Close();
                    // What if there are no orders
                    return 0;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }

        // GET LAST INSERTED ID TO PREPARE FOR PAYMENT
        public int getLastInsertedDBPaymentID()
        {
            String q = "";
            SqlConnection cn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
            String sqlStm = "SELECT MAX(PAYMENT_ID) FROM Payment";
            SqlCommand cmd = new SqlCommand(sqlStm, cn);
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NVarChar));
            cmd.Parameters["@id"].Value = q;
            cn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int prevInsertedOrderID = Convert.ToInt32(reader[0]);
                cn.Close();
                return prevInsertedOrderID;
            }
            else
            {
                cn.Close();
                // What if there are no orders
                return 0;
            }
            //cn.Close();
        }

        // PROCESS ORDER
        private void orderDoneButton_Click(object sender, EventArgs e)
        {
            //int currentOrderID = 0;
            if (orderListDataGridView.Rows.Count > 1)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Submit Order ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //do something
                        // Get Potential Order No 
                        int nextOrderID = getLastInsertedDBID() + 1;
                        //MessageBox.Show(nextOrderID.ToString());
                        
                        // CALCULATE TOTAL DUE
                        AMOUNT_DUE = Convert.ToDouble(amountDueLabel.Text);
                        //MessageBox.Show(AMOUNT_DUE.ToString());
                        //PAYMENT_STATE = 0;
                        ORDER_ID = nextOrderID;
                        payment(); // call payment form
                        if(POSPaymentForm.IS_PAID == true) // If OK Continue
                        {
                            // CREATE ORDER
                            try
                            {
                                // CREATE A NEW ORDER
                                conOrder.Open();
                                String sqlStatement = "insert into tblOrder values(NULL, '" +
                                MainLoginForm.LOGGED_IN_ID + "', NULL, '" +
                                2 + "', getdate(),'" + AMOUNT_DUE +"','" + POSPaymentForm.PAID_AMOUNT + "')";
                                SqlCommand command = new SqlCommand(sqlStatement, conOrder);
                                command.ExecuteNonQuery();
                                conOrder.Close();
                                //MessageBox.Show("@@ ORDER CREATED " + getLastInsertedDBID().ToString(), "TEST");
                            } catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } // End order creation

                            // PAYMENT ID
                            SqlConnection conn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp");
                            try
                            {
                                // open the connection
                                conn.Open();
                                SqlCommand command = new SqlCommand("insert into Payment values (" +
                                    ORDER_ID + "," +
                                    MainLoginForm.LOGGED_IN_ID + "," +
                                    POSPaymentForm.PAYMENT_TYPE + "," +
                                    AMOUNT_DUE +
                                    ", getdate())", conn);
                                command.ExecuteNonQuery();
                                //MessageBox.Show("Order " + idOrder + " Successfully paid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                                //MessageBox.Show("@@ PAYMENT CREATED", "TEST");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            // CREATE A NEW ORDER ITEMS
                            // go through list of items in the list and get ID
                            // create order_item using current order ID  
                            SqlConnection cn = new SqlConnection(@"Data Source=146.230.177.46;Initial Catalog=GroupWst10;User ID=GroupWst10;Password=n2gfp");
                            for (int i = 0; i < orderListDataGridView.Rows.Count - 1; i++)
                            {
                                // get id of Stock item
                                String stockName = orderListDataGridView.Rows[i].Cells[0].Value.ToString();
                                int currentStockId = getId(stockName);
                                // create Order_Item
                                conItem.Open();
                                int currentItemQuantity = Convert.ToInt32(orderListDataGridView.Rows[i].Cells[1].Value.ToString());
                                String sqlStatementItem = "insert into Order_Item values(" + ORDER_ID + "," +
                                currentStockId + "," +
                                currentItemQuantity + ")";
                                SqlCommand commandItem = new SqlCommand(sqlStatementItem, conItem);
                                commandItem.ExecuteNonQuery();
                                conItem.Close();

                                // DECREMENT STOCK IN INVENTORY
                                // get stock name = stockName
                                // get Stock Quantity value to edit =  currentItemQuantity
                                int currentStockQuantity = getQuantity(stockName);
                                int newQuant = currentStockQuantity - currentItemQuantity;
                                int stockID = getId(stockName);
                                try
                                {
                                    cn.Open();
                                    SqlCommand comm = new SqlCommand(
                                        "Update Stock set  Stock_Quantity = '" + newQuant +
                                        "' where Stock_ID = '" + stockID + "'", cn);
                                    comm.ExecuteNonQuery();
                                    cn.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                finally
                                {

                                }
                            } // End of for loop to create Order Items
                              //MessageBox.Show("@@ ITEMS CREATED AND INVENTORY DECREMENTED", "TEST");

                            // UPDATE PAYMENT ID 
                            // Get last updated payment and update the payment id in the order table
                            int payID = getLastInsertedDBPaymentID();
                            try
                            {
                                // Update Statement
                                conpaym.Open();
                                SqlCommand command = new SqlCommand(
                                    "Update tblOrder set  Payment_ID = '" + payID +
                                    "' where Order_ID = '" + ORDER_ID + "'", conpaym);
                                command.ExecuteNonQuery();
                                conpaym.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Order Payment Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            // ORDER DONE
                            MessageBox.Show("Order " + ORDER_ID + " Processed Sucessfully", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // VIEW SLIP
                            POSSlip sf = new POSSlip();
                            //SubSysPOSForm.SLIP_STATE = 0;
                            sf.ShowDialog();
                            if(POSSlip.IS_SLIP == true)
                            {
                                // Clear the datagrid view
                                orderListDataGridView.Rows.Clear();
                                orderListDataGridView.Refresh();
                                
                                updatePaymentDue(); // update payment displays
                            }
                        }
                        else 
                        {
                            // Payment not accepted, Do not create order
                            MessageBox.Show("Payment Cancelled - Order Not Yet Processed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }          
                    } // End of yes to order submit dialog
                    else if (dialogResult == DialogResult.No) // If no to order submit dialog
                    {
                        MessageBox.Show("Order Submission Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else // No datagrid view items
            {
                MessageBox.Show("Have atleast 1 Order Item", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        } // End of orderDoneButton   


        private void payment()
        {
            POSPaymentForm pff = new POSPaymentForm();
            pff.ShowDialog();
            //PAYMENT_STATE = 1;
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            payment();
        }

        void orderEnables() 
        {
            // Method to enable and disable some controls
            if (orderListDataGridView.Rows.Count > 1)
            {
                orderDoneButton.Enabled = true;
                cancelButton.Enabled = true;
            }
            else
            {
                orderDoneButton.Enabled = false;
                cancelButton.Enabled = false;
            }
        }

        private void orderListDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            orderEnables();
        }

        private void orderListDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            orderEnables();
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            if (cancelButton.Enabled == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are Sure You Want To Stop Current Order And Start A new Order", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    // Clear the datagrid view
                    orderListDataGridView.Rows.Clear();
                    orderListDataGridView.Refresh();
                    updatePaymentDue(); // update payment displays                                     
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
            else
            {
                // Clear the datagrid view
                orderListDataGridView.Rows.Clear();
                orderListDataGridView.Refresh();
                updatePaymentDue(); // update payment displays
            }
        }

        private void printSlipButton_Click(object sender, EventArgs e)
        {
            POSSlip sf = new POSSlip();
            //SubSysPOSForm.SLIP_STATE = 1;
            sf.ShowDialog();
        }
    }
}
