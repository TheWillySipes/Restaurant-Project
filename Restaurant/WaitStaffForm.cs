﻿using BusinessLayer;
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
    public partial class WaitStaffForm : Form
    {
        public WaitStaffForm()
        {
            InitializeComponent();
        }
        
        WaitStaff waitStaff = new WaitStaff();
        bool clockedIn = false;

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            //Disable multiple clock ins
            btnClockIn.Enabled = false;
            clockedIn = true;

            if (clockedIn == true)
            {
                //Enabling all buttons once wait staff has clocked in
                btnEnterOrder.Enabled = true;
                btnCheckOrder.Enabled = true;
                btnCashOut.Enabled = true;
                btnClockOut.Enabled = true;
                btnFloorStatus.Enabled = true;

                //Clocking in wait staff
                DateTime clockedInTime = DateTime.Now;
                MessageBox.Show("Wait Staff Clocked in: " + clockedInTime);
            }

        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            //Clocking out wait staff and reverting back to login screen
            clockedIn = false;
            DateTime clockedOutTime = DateTime.Now;
            MessageBox.Show("Wait Staff Clocked out: " + clockedOutTime);
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
            
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
           //Checking status of an order
        }

        private void btnEnterOrder_Click(object sender, EventArgs e)
        {
            //Opens form to enter ticket order
            TicketForm ticketForm = new TicketForm();
            this.Hide();
            ticketForm.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Revert back to login screen while still clocked in
            clockedIn = true;
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnFloorStatus_Click(object sender, EventArgs e)
        {
            
            FloorStatus floorForm = new FloorStatus();
            floorForm.Show();
            this.Hide();
        }
    }
}