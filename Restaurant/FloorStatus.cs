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
            
        }

        //Setting table status to Dirty by default
        TableStatus tblStat = TableStatus.Dirty;

        Random rng = new Random();
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
            WaitStaffForm waitForm = new WaitStaffForm();
            waitForm.checkclockin = true;
            waitForm.Show();
            this.Hide();
        }

        private void FloorStatus_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
