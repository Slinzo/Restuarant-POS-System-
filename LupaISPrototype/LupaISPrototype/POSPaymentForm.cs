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
    public partial class POSPaymentForm : Form
    {
       
        public POSPaymentForm()
        { InitializeComponent(); }

        // GLOBAL VARIABLES
        public static bool IS_PAID = false; // To Process Order
        public static int PAYMENT_TYPE = 0;
        public static double PAID_AMOUNT = 0;

        // VARIABLES
        double paymentDue; // payment due   

        // CONNECTIONS
        SqlConnection conItms = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");

        private void PaymentForm_Load(object sender, EventArgs e)
        {           
                paymentDue = SubSysPOSForm.AMOUNT_DUE;   // The amount to be paid
                TotalDueTextBox.Text = paymentDue.ToString();

                if (SubSysPOSForm.ORDER_ID != 0)
                    orderIdTextBox.Text = SubSysPOSForm.ORDER_ID.ToString();
                else
                    orderIdTextBox.Text = "";
                ChangeLabel.Visible = true;
        }

        void clearEntries()
        {
            PaidAmountTextBox.Clear();
            TotalDueTextBox.Clear();
            ChangeTextBox.Clear();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (
                // all input in
                PaidAmountTextBox.Text != "" &&
                TotalDueTextBox.Text != "" &&
                ChangeTextBox.Text != ""
                )
            {  
                if (Convert.ToDouble(PaidAmountTextBox.Text) - Convert.ToDouble(TotalDueTextBox.Text) >= 0) // Funds Sufficient for payment
                {
                    int theOrderID = int.Parse(orderIdTextBox.Text); // Added
                   
                    if (CashRadioButton.Checked == true)
                    {
                        PAYMENT_TYPE = 0;
                    }
                    if (CardRadioButton.Checked == true)
                    {
                        PAYMENT_TYPE = 1;
                    }
                    
                    PAID_AMOUNT = Convert.ToDouble(PaidAmountTextBox.Text); 
                    IS_PAID = true; // payment is accepted and boolean set to true
                    MessageBox.Show("Payment for Order " + theOrderID + " Accepted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                } else 
                {
                    MessageBox.Show("Insufficient Funds", "Information"); 
                }          
            }
            else
            {
                MessageBox.Show("Enter All Fields", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CashRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Visible = true;
            ChangeTextBox.Visible = true;
        }

        private void CardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabel.Visible = false;
            ChangeTextBox.Visible = false;
        }
        
        private void PaidAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(TotalDueTextBox.Text);
                double pay = Convert.ToDouble(PaidAmountTextBox.Text);

                if (PaidAmountTextBox.Text == "")
                {
                    ChangeTextBox.Text = "";
                }
                if ( (total - pay >= 0) && PaidAmountTextBox.Text != "")
                {
                    ChangeTextBox.Text = "Insufficient Funds";
                }
                if ((total - pay <= 0) && PaidAmountTextBox.Text != "")
                {
                    ChangeTextBox.Text = (pay - total).ToString("C");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want To Cancel Payment ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                IS_PAID = false;
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }            
        }      
        
    }
}
