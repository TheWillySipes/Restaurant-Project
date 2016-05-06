using BusinessLayer;
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
    public partial class FloorStatus : Form
    {
        public FloorStatus()
        {
            InitializeComponent();

            //Changing the colors of the tables with random number generator
            //Used to simulate table activity
            pictureBox1.Paint += FloorStats;
            pictureBox2.Paint += FloorStats;
            pictureBox3.Paint += FloorStats;
            pictureBox4.Paint += FloorStats;
            pictureBox5.Paint += FloorStats;
            pictureBox6.Paint += FloorStats;
            pictureBox7.Paint += FloorStats;
            pictureBox8.Paint += FloorStats;
            pictureBox9.Paint += FloorStats;
            pictureBox10.Paint += FloorStats;

            //Manually changing the colors of the tables by clicking them
            pictureBox1.Click += changeTableStatus;
            pictureBox2.Click += changeTableStatus;
            pictureBox3.Click += changeTableStatus;
            pictureBox4.Click += changeTableStatus;
            pictureBox5.Click += changeTableStatus;
            pictureBox6.Click += changeTableStatus;
            pictureBox7.Click += changeTableStatus;
            pictureBox8.Click += changeTableStatus;
            pictureBox9.Click += changeTableStatus;
            pictureBox10.Click += changeTableStatus;

        }

        TableStatus tblStat = TableStatus.Open;
        Random rng = new Random();
        int checkStatus = 0;
        private void FloorStats(object sender, EventArgs e)
        {


            //Setting table status with use of random number
            //Just to show an example of how things would look
            int randomNumber = rng.Next(0, 90);
            Console.WriteLine(randomNumber);

            if (randomNumber > 0 && randomNumber < 30)
            {
                tblStat = TableStatus.Open;

            }
            else if (randomNumber > 30 && randomNumber < 60)
            {
                tblStat = TableStatus.Occupied;
            }
            else
            {
                tblStat = TableStatus.Dirty;
            }


            //Changing table colors
            PictureBox picBox = (PictureBox)sender;

            if (tblStat == TableStatus.Open)
            {
                picBox.BackColor = Color.Green;
            }
            else if (tblStat == TableStatus.Occupied)
            {
                picBox.BackColor = Color.Yellow;
            }
            else
            {
                picBox.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Opening the waitstaff form
            WaitStaffForm waitForm = new WaitStaffForm();
            waitForm.checkclockin = true;
            waitForm.Show();
            this.Hide();
        }

        private void FloorStatus_Load(object sender, EventArgs e)
        {
          //empty               
        }

        private void changeTableStatus(object sender, EventArgs e)
        {
            //Changing table colors maually
            PictureBox picBox = (PictureBox) sender;
           
            if (checkStatus == 0)
            {
                //Open
                picBox.BackColor = Color.Green;
                tblStat = TableStatus.Open;
                checkStatus = 1;
                Console.WriteLine(checkStatus);
            }
            else if (checkStatus == 1)
            {
                //Occupied
                picBox.BackColor = Color.Yellow;
                tblStat = TableStatus.Occupied;
                checkStatus = 2;
                Console.WriteLine(checkStatus);
            }
            else if (checkStatus == 2)
            {
                //Dirty
                picBox.BackColor = Color.Red;
                tblStat = TableStatus.Dirty;
                checkStatus = 0;
                Console.WriteLine(checkStatus);
            }
        }
    }
}
