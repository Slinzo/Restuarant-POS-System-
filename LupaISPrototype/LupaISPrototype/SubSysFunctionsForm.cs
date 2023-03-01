using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LupaISPrototype
{
    public partial class SubSysFunctionsForm : Form
    {
        public SubSysFunctionsForm()
        {
            InitializeComponent();
        }

        private void SubSysFunctionsForm_Load(object sender, EventArgs e)
        {
            // Maximise Form
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void manageStaffButton_Click(object sender, EventArgs e)
        {
            FunctionsStaffManagementForm smf = new FunctionsStaffManagementForm();
            smf.ShowDialog();
        }  

        private void paymentHistoryButton_Click(object sender, EventArgs e)
        {
            FunctionsPaymentForm pf = new FunctionsPaymentForm();
            pf.ShowDialog();
        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {
            FunctionsOrderHistoryForm ohf = new FunctionsOrderHistoryForm();
            ohf.ShowDialog();
        }

        private void slipButton_Click(object sender, EventArgs e)
        {
            POSSlip sf = new POSSlip();
            //SubSysPOSForm.SLIP_STATE = 1;
            sf.ShowDialog();
        }
    }
}
