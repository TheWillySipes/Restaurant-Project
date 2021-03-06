﻿using BusinessLayer.BusinessLogic;
using BusinessLayer.ViewModels;
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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(EmployeeLogic.AuthenticateEmployee(txtUserName.Text, txtPassword.Text))
            {
                EmployeeVM employee = EmployeeLogic.Get(txtUserName.Text);
                GlobalData.Instance.SetLoggedInEmployee(employee);
                EmployeeActionSelector employeeActionSelector = new EmployeeActionSelector();
                txtPassword.Text = "";
                txtUserName.Text = "";
                employeeActionSelector.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
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

        //Override when user tries to close window, open new instance of login form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            GlobalData.Instance.LoginForm.Show();
            this.Hide();
            this.Dispose();
        }

    }
}
