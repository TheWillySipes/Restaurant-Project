using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //Employee ID set to 5 numbers
            txtBxID.MaxLength = 5;

            //Pin Number length set to 4 numbers
            txtBxPIN.MaxLength = 4;
            txtBxPIN.PasswordChar = '*';
        }

        HostForm hostForm = new HostForm();
        WaitStaffForm waitForm = new WaitStaffForm();

        //Password
        public char PasswordChar { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string idString = txtBxID.Text;
            string pinString = txtBxPIN.Text;
            int idParsed = 0;
            int pinParsed = 0;

            if (int.TryParse(idString, out idParsed) && int.TryParse(pinString, out pinParsed))
            {
                //Just an example to open up to the HOST form. 
                //Employee ID:12345 PIN:1234

                if (idParsed == 12345 && pinParsed == 1234)
                {
                    //This message box can be deleted, just showing progression to Host Form
                    MessageBox.Show("Host login successful!");
                    hostForm.Show();
                    this.Hide();
                }

                //Example to open WaitStaff Form
                //Employee ID:98765 PIN:9876
                else if (idParsed == 98765 && pinParsed == 9876)
                {
                    MessageBox.Show("WaitStaff Login Successful!");
                    waitForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Not Yet Created.");
                }

            }
            else
            {
                //Parse unsucessful
                MessageBox.Show("Invalid credentials.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Help file
            string output = "";
            output += "Welcome to the Login Screen\n";
            output += "Employee ID is 5 characters in length\n";
            output += "PIN number is 4 characters in length\n";
            output += "Version 1.0 - Restaurant Project";
            MessageBox.Show(output);

        }
    }
}
