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
    public partial class FunctionsPaymentForm : Form
    {
        public FunctionsPaymentForm()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupWst10ProtoDataSet);
        }

        private void FunctionsPaymentForm_Load(object sender, EventArgs e)
        {
            this.tblOrderTableAdapter.FillByPaidOrder(this.groupWst10ProtoDataSet.tblOrder);
            this.paymentTableAdapter.Fill(this.groupWst10ProtoDataSet.Payment);
        }
       
    }
}
