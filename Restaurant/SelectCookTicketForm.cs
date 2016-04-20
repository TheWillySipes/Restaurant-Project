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
    public partial class SelectCookTicketForm : Form
    {
        public SelectCookTicketForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TicketForm Ticket = new TicketForm();

           foreach (string value in tickets)
	{
	    
	}
            textBox1.Text = 
        }
    }
}
