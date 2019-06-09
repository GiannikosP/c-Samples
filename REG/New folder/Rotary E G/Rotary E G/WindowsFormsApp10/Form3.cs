using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp10
{
    public partial class Form3 : Form
    {
        
        
        private int c = 60;
        private int score = 0;
        private int p = 1;
        private int highscore = 0;

        private int high;
        private string l;
        private int counter = 1;
       



        public Form3(int h)
        {
            InitializeComponent();
            high = h;
            using (StreamReader f = new StreamReader("usernames.txt"))
            {
                while ((l = f.ReadLine()) != null)
                {
                    counter++;
                }
            }
        }

        
       

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                Random r = new Random();
                int x = r.Next(3, 593);
                int y = r.Next(3, 174);
                pictureBox1.Location = new Point(x, y);
                score += 10;
                label4.Text = score.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c--;
            if (p == 0)
            {
                Random r = new Random();
                int x = r.Next(3, 593);
                int y = r.Next(3, 174);
                pictureBox1.Location = new Point(x, y);
                System.Threading.Thread.Sleep(500);
                r = new Random();
                 x = r.Next(3, 593);
                 y = r.Next(3, 174);
                pictureBox1.Location = new Point(x, y);
            }
            if (p == 1)
            {
                Random r = new Random();
                int x = r.Next(3, 593);
                int y = r.Next(3, 174);
                pictureBox1.Location = new Point(x, y);
            }
            if (c <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Good Job, your Score is: " + label4.Text);
            
                
                
                

               

                string[] lines = File.ReadAllLines("highscore.txt");
                int[] array = lines.Select(str => int.Parse(str)).ToArray();
                highscore = array[high];


                

                if (score > highscore)
                {
                    lines[high] = score.ToString();
                    highscore = score;
                }
                label5.Text = highscore.ToString();
                File.WriteAllLines("highscore.txt", lines);
            }

            label2.Text = c.ToString();
        }
            
            
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            c = 60;
            score = 0;
            string[] lines = File.ReadAllLines("highscore.txt");
            label5.Text = lines[high].ToString();
            label2.Text = c.ToString();
            label4.Text = score.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            p = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
                label2.Text = c.ToString();
            }
            string[] lines = File.ReadAllLines("highscore.txt");
            label5.Text = lines[high].ToString();
            c = 60;
            score = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            p = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
