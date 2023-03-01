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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            // Start The Order Child Form
            //SubSysPOSForm orderfrm = new SubSysPOSForm();
            //orderfrm.MdiParent = this;    
            //orderfrm.Show();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "SubSysPOSForm")
                {
                    IsOpen = true;
                    f.Focus();
                    f.Update(); // Added this to update menu
                    //f.Controls.Clear(); // Added this to update menu
                    //f.Refresh();
                    break;
                }
            }
            if (IsOpen == false)
            {
                SubSysPOSForm f2 = new SubSysPOSForm();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Exit The Application", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //this.Close();
                System.Windows.Forms.Application.Exit();
                //System.Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainAboutBox MyAboutBox = new MainAboutBox();
            MyAboutBox.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int JOB_LIMITATION = MainLoginForm.JOB_INT;
            if(JOB_LIMITATION == 0) // Manager
            {
                orderToolStripMenuItem.Enabled = true;
                inventoryToolStripMenuItem.Enabled = true;
                functionsToolStripMenuItem.Enabled = true;
            }
            if (JOB_LIMITATION == 1) // Waiter
            {
                orderToolStripMenuItem.Enabled = true;
                inventoryToolStripMenuItem.Enabled = false;
                functionsToolStripMenuItem.Enabled = false;
            }
            if (JOB_LIMITATION == 2) // Chef
            {
                orderToolStripMenuItem.Enabled = false;
                inventoryToolStripMenuItem.Enabled = false;
                functionsToolStripMenuItem.Enabled = false;
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SubSysInventoryManForm ims = new SubSysInventoryManForm();
            //ims.MdiParent = this;
            //ims.Show();

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Inventory Management")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                SubSysInventoryManForm f2 = new SubSysInventoryManForm();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void functionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SubSysFunctionsForm ff = new SubSysFunctionsForm();
            //ff.MdiParent = this;
            //ff.Show();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Functions")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                SubSysFunctionsForm f2 = new SubSysFunctionsForm();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Log Out", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                MainLoginForm log = new MainLoginForm();
                log.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        // If form is closed, Application must close
        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
