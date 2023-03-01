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
    public partial class IMSActDeactStockForm : Form
    {
        public IMSActDeactStockForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst10ProtoDataSet);

        }

        private void IMSActDeactStockForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst10ProtoDataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.groupWst10ProtoDataSet.Stock);

            this.stockTableAdapter.FillByActive(this.groupWst10ProtoDataSet.Stock);

            int rowscount = stockDataGridView.Rows.Count;
            for (int i = 0; i < rowscount; i++)
            {
                stockDataGridView.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;

            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {  // Nothing to select on data grid view check
                if (radioButtonShowActive.Checked == true)
                {
                    // first check if any row is selected 
                    bool flag = (stockDataGridView.SelectedRows != null && stockDataGridView.SelectedRows.Count > 0);
                    if (flag == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you Sure You Want To Deactivate This Item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //do something
                            foreach (DataGridViewRow item in this.stockDataGridView.SelectedRows)
                            {
                                // Change: product_status = 0
                                int rowindex = stockDataGridView.CurrentCell.RowIndex;
                                int id = Convert.ToInt32(stockDataGridView.Rows[rowindex].Cells[0].Value.ToString());

                                try
                                {
                                    conn.Open();
                                    SqlCommand command = new SqlCommand(
                                        "Update Stock set stock_Active = '" + 0 +
                                         "' where Stock_ID = '" + id + "'", conn);
                                    command.ExecuteNonQuery();
                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error");
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }
                            MessageBox.Show("The Product has been deactivated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.stockTableAdapter.FillByActive(this.groupWst10ProtoDataSet.Stock);
                            
                            // Frefresh the POS Menu
                            


                            int rowscount = stockDataGridView.Rows.Count;
                            for (int i = 0; i < rowscount; i++)
                            {
                                stockDataGridView.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;

                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Select a row to de-activate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (radioButtonShowInactive.Checked == true)
                {
                    bool flag = (stockDataGridView.SelectedRows != null && stockDataGridView.SelectedRows.Count > 0);
                    if (flag == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you Sure You Want To Re-activate This Item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //do something
                            foreach (DataGridViewRow item in this.stockDataGridView.SelectedRows)
                            {
                                // Change: product_status = 1
                                int rowindex = stockDataGridView.CurrentCell.RowIndex;
                                int id = Convert.ToInt32(stockDataGridView.Rows[rowindex].Cells[0].Value.ToString());

                                try
                                {
                                    conn.Open();
                                    SqlCommand command = new SqlCommand(
                                        "Update Stock set stock_Active = '" + 1 +
                                         "' where Stock_ID = '" + id + "'", conn);
                                    command.ExecuteNonQuery();
                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error");
                                }

                                finally
                                {
                                    conn.Close();
                                }
                            }
                            MessageBox.Show("The Product has been re-activated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.stockTableAdapter.FillByInactive(this.groupWst10ProtoDataSet.Stock);
                            int rowscount = stockDataGridView.Rows.Count;
                            for (int i = 0; i < rowscount; i++)
                            {
                                stockDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Red;

                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Select a row to reactivate", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception) // Nothing to select on data grid view check
            {
                //MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Please Make A Valid Selection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButtonShowActive_CheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Text = "Deactivate Product";
            this.stockTableAdapter.FillByActive(this.groupWst10ProtoDataSet.Stock);

            int rowscount = stockDataGridView.Rows.Count;
            for (int i = 0; i < rowscount; i++)
            {
                stockDataGridView.Rows[i].Cells[0].Style.BackColor = Color.LightGreen;

            }
        }

        private void radioButtonShowInactive_CheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Text = "Activate Product";
            this.stockTableAdapter.FillByInactive(this.groupWst10ProtoDataSet.Stock);

            int rowscount = stockDataGridView.Rows.Count;
            for (int i = 0; i < rowscount; i++)
            {
                stockDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Red;

            }
        }

        private void groupBoxProducts_Enter(object sender, EventArgs e)
        {

        }

        private void IMSActDeactStockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Keep this to refresh DB
        }
    }
}
