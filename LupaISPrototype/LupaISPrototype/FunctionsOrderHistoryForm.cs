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
    public partial class FunctionsOrderHistoryForm : Form
    {
        public FunctionsOrderHistoryForm()
        {
            InitializeComponent();
        }

        private void tblOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblOrderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst10ProtoDataSet);
        }

        private void FunctionsOrderHistoryForm_Load(object sender, EventArgs e)
        {        
            // TODO: This line of code loads data into the 'groupWst10ProtoDataSet.tblOrder' table. You can move, or remove it, as needed.
            this.tblOrderTableAdapter.Fill(this.groupWst10ProtoDataSet.tblOrder);
        }

        SqlConnection conItms = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
        private void tblOrderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {  
                bool flag = (tblOrderDataGridView.SelectedRows != null && tblOrderDataGridView.SelectedRows.Count > 0);
                if (flag == true)
                {
                    int rowindex = tblOrderDataGridView.CurrentCell.RowIndex;
                    int orderID = Convert.ToInt32(tblOrderDataGridView.Rows[rowindex].Cells[0].Value);

                    conItms.Open();
                    String sqlquerry = "Select Order_Item.Order_Item_ID, Stock.Stock_Name, Order_Item.Item_Quantity from Order_Item inner join Stock on Stock.Stock_ID =  Order_Item.Stock_ID " +
                       "where Order_ID = '" + orderID + "'";
                    SqlCommand sqlcomm = new SqlCommand(sqlquerry, conItms);
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt = new DataTable();
                    sdr.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conItms.Close();
                }
                else
                {
                    // Nothing to select on data grid view check
                    MessageBox.Show("Please Select Row Of Item To View Order Item", "Error Removing Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) // Nothing or no valid selection on the datagrid view
            {
                String errMsg = ex.Message;
                MessageBox.Show( errMsg + "\nPlease Make A Valid Selection To View Order Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }
    }
}
