using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LupaISPrototype
{
    public partial class MainLoginForm : Form
    {
        // To hold job integer and pass to main form to enable and disable menu options for users with different priviledges
        public static int JOB_INT;
        public static int LOGGED_IN_ID;

        // Connection strings
        SqlConnection con1 = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
        SqlConnection con2 = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");
        SqlConnection con3 = new SqlConnection(@"Data Source = 146.230.177.46; Initial Catalog = GroupWst10; Persist Security Info=True;User ID = GroupWst10; Password=n2gfp");

        public MainLoginForm()
        {
            InitializeComponent();
        }

        // METHODS
        public int getJobTitleInteger(String name)
        {   
            // Gets the job title of an employee            
            con1.Open();
            using (SqlCommand q = con1.CreateCommand())
            {
                q.CommandText = String.Format(
                    @"select {0} from Staff where Staff_Username = @Myparameter", "Staff_Title");
                    q.Parameters.AddWithValue("@Myparameter", name);
                    using (var reader = q.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int value = Convert.ToInt32(reader[0]);
                            con1.Close();
                            return value;
                        }
                        else
                        {
                            // No such value found
                            MessageBox.Show("Staff DataBase Data Not Found: Job Title ID", "Error Finding Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con1.Close();
                            return 0;
                        }
                    }
            }
        } 

        public int getLoggedIDInteger(String name)
        {
            // Get Staff ID of an employee
            con2.Open();
            using (SqlCommand q = con2.CreateCommand())
            {
                q.CommandText = String.Format(
                    @"select {0} from Staff where Staff_Username = @Myparameter", "Staff_ID");
                    q.Parameters.AddWithValue("@Myparameter", name);
                    using (var reader = q.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int value = Convert.ToInt32(reader[0]);
                            con2.Close();
                            return value;
                        }
                        else
                        {
                            // No such value found
                            MessageBox.Show("Staff DataBase Data Not Found : Staff ID", "Error Finding Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            con2.Close();
                            return 0;
                        }
                    }
            }
        } 

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Start Main Form
            String username, user_password;
            username = usernametextBox.Text;
            user_password = passwordMaskedTextBox1.Text;

            try
            {
                con3.Open();
                String querry = "SELECT * FROM Staff WHERE Staff_Username = '" + usernametextBox.Text + "' AND Staff_Password = '" +passwordMaskedTextBox1.Text + "' AND Staff_Active = '" + 1 + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con2);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = usernametextBox.Text;
                    user_password = passwordMaskedTextBox1.Text;
                   
                    int ink = getJobTitleInteger(username);  // Get Job Type ID
                    int log = getLoggedIDInteger(username);
                    JOB_INT = ink;
                    LOGGED_IN_ID = log;   
                    
                    MainMenuForm form1 = new MainMenuForm(); //page that has to load next
                    con2.Close();
                
                    form1.Show();
                    this.Hide();      
                }
                else
                {
                    MessageBox.Show("Invalid login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernametextBox.Clear();
                    passwordMaskedTextBox1.Clear();                    
                    usernametextBox.Focus(); //to focus username
                }
            }
            catch
            {
                MessageBox.Show("Invalid Login", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {     
                con2.Close();      
            }     
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Exit this Application", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {                
                System.Windows.Forms.Application.Exit(); // Close all
            }
            else if (dialogResult == DialogResult.No)
            {
    
            }        
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernametextBox.Focus();  // to focus username
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernametextBox.Clear();
            passwordMaskedTextBox1.Clear();
        }

        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {
           if(usernametextBox.Text == "")
            {
                loginButton.Enabled = false;
            }
            else
            {
                loginButton.Enabled = true;
            }
        }       
    }
}
