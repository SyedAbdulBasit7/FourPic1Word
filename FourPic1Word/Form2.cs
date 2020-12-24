using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourPic1Word
{
    public partial class Form2 : Form
    {
        private int seconds;
        private int minutes;
        private bool check;
        private int score;
        private char[] letters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
        public Form2()
        {
            InitializeComponent();
            seconds = minutes = score = 0;
            check = false;
            timer1.Start();
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
            pictureBox3.Image = imageList1.Images[2];
            pictureBox4.Image = imageList1.Images[3];
            randomLetter("b", "a","t");
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 2)
            {
                minutes = 0;
                seconds = 0;
                pictureBox1.Image = imageList1.Images[4];
                pictureBox2.Image = imageList1.Images[5];
                pictureBox3.Image = imageList1.Images[6];
                pictureBox4.Image = imageList1.Images[7];
                randomLetter("c", "a","n");
                timer1.Stop();
                check = true;
            }
          
            if (check==true)
            {
                check = false;
                timer2.Start();
            }
          
            Minute.Text = Change(minutes);
            Second.Text = Change(seconds);
        }
        private string Change(int value)
        {
            if (value <= 9)
                return "0" + value;
            else
                return value.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 2)
            {
                minutes = 0;
                seconds = 0;
                pictureBox1.Image = imageList1.Images[8];
                pictureBox2.Image = imageList1.Images[9];
                pictureBox3.Image = imageList1.Images[10];
                pictureBox4.Image = imageList1.Images[11];
                randomLetter("e", "g","g");
                timer2.Stop();
                check = true;
            }
        
            if (check == true)
            {
                check = false;
                timer3.Start();
            }

            Minute.Text = Change(minutes);
            Second.Text = Change(seconds);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 2)
            {
                minutes = 0;
                seconds = 0;
                pictureBox1.Image = imageList1.Images[12];
                pictureBox2.Image = imageList1.Images[13];
                pictureBox3.Image = imageList1.Images[14];
                pictureBox4.Image = imageList1.Images[15];
                randomLetter("t", "o","s");
                timer3.Stop();
                check = true;
            }
           
            if (check == true)
            {
                check = false;
                timer4.Start();
            }

            Minute.Text = Change(minutes);
            Second.Text = Change(seconds);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 2)
            {
                minutes = 0;
                seconds = 0;
                pictureBox1.Image = imageList1.Images[16];
                pictureBox2.Image = imageList1.Images[17];
                pictureBox3.Image = imageList1.Images[18];
                pictureBox4.Image = imageList1.Images[19];
                randomLetter("z", "i","p");
                timer4.Stop();
                check = true;
            }
         
            if (check == true)
            {
                check = false;
                timer5.Start();
            }
            Minute.Text = Change(minutes);
            Second.Text = Change(seconds);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 2)
            {
                minutes = 0;
                seconds = 0;
                MessageBox.Show("Your Score: " + score);
                timer5.Stop();
            }
            Minute.Text = Change(minutes);
            Second.Text = Change(seconds);
        }

        private void randomLetter(string l1,string l2,string l3)
        {
            Random r = new Random();
            string randomString = "";
            for(int i = 0; i < 12; i++)
            {
                randomString += letters[r.Next(0, 25)].ToString();
            }
            guess.Text = l1 + randomString + l2 + l3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gLetter.Text == "bat")
            {
                score = score + 20;
                gLetter.Text = "";
                minutes = 0;
                seconds = 0;
                pictureBox1.Image = imageList1.Images[4];
                pictureBox2.Image = imageList1.Images[5];
                pictureBox3.Image = imageList1.Images[6];
                pictureBox4.Image = imageList1.Images[7];
                randomLetter("c", "a", "n");
            }
            if (gLetter.Text == "can")
            {
                score = score + 20;
                gLetter.Text = "";
                minutes = 0;
                seconds = 0;
                pictureBox1.Image = imageList1.Images[8];
                pictureBox2.Image = imageList1.Images[9];
                pictureBox3.Image = imageList1.Images[10];
                pictureBox4.Image = imageList1.Images[11];
                randomLetter("e", "g", "g");
            }
            if (gLetter.Text == "egg")
            {
                score = score + 20;
                gLetter.Text = "";
                minutes = 0;
                seconds = 0;
                pictureBox1.Image = imageList1.Images[12];
                pictureBox2.Image = imageList1.Images[13];
                pictureBox3.Image = imageList1.Images[14];
                pictureBox4.Image = imageList1.Images[15];
                randomLetter("t", "o", "s");
            }
            if (gLetter.Text == "tools")
            {
                score = score + 20;
                gLetter.Text = "";
                minutes = 0;
                seconds = 0;
                pictureBox1.Image = imageList1.Images[16];
                pictureBox2.Image = imageList1.Images[17];
                pictureBox3.Image = imageList1.Images[18];
                pictureBox4.Image = imageList1.Images[19];
                randomLetter("z", "i", "p");
            }
            if (gLetter.Text == "zip")
            {
                score = score + 20;
                gLetter.Text = "";
                minutes = 0;
                seconds = 0;
                timer1.Stop(); timer2.Stop(); timer3.Stop(); timer4.Stop(); timer5.Stop();
                MessageBox.Show("Highest Score = 100 and Your Score: " + score);
                this.Close();
            }
        }
    }
}
