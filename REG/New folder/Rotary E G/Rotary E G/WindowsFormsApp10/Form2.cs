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
    public partial class Form2 : Form
    {
        private int hi;
        private string line;
        int k;

        public Form2(string s,int high)
        {
            InitializeComponent();
            label1.Text = "Welcome " + s;
            Form3 h = new Form3(high);
            hi = high;

        }
        


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 o = new Form3(hi);
            o.Show();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("highscore.txt");
            string[] names = File.ReadAllLines("usernames.txt");
            int[] array = lines.Select(str => int.Parse(str)).ToArray();
            using (StreamReader file = new StreamReader("usernames.txt"))
                while ((line = file.ReadLine()) != null)
                {
                    k++;

                }

            using (StreamReader file = new StreamReader("usernames.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    k++;
                }
            }

            bool didSwap;
            do
            {
                didSwap = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        string temp2 = names[i + 1];
                        names[i + 1] = names[i];
                        names[i] = temp2;
                        didSwap = true;
                    }
                }
            } while (didSwap);





            label2.Text= names[0];

            label3.Text= names[1];
            label4.Text = names[2];
            label5.Text = array[0].ToString();
            label6.Text = array[1].ToString();
            label7.Text = array[2].ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
