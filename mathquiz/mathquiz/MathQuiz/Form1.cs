using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        int r;
        int c=0, cm;
        int l3;
        int l5;
        int l10;
        int l8;
        int l14;
        int l12 ;
        int l18 ;
        int l16;
        int in1;
        int in2;
        int in3;
        int in4;
        int r1, r2, r3, r4;
        int cal = 0;
        int show1, show2, show3, show4;
        

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press Start, when ready. Try to answer the question as fast as you can. Good Luck");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label21.Text = show1.ToString();
            label22.Text = show2.ToString();
            label23.Text = show3.ToString();
            label24.Text = show4.ToString();


        }

        int time,score;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             c++;
            
            if (cm > 60)
            {
                label1.ForeColor = Color.Green;
                label2.ForeColor = Color.Green;
            }
            else if (cm > 30)
            {
                label1.ForeColor = Color.Orange;
                label2.ForeColor = Color.Orange;
            }
            else if (cm > 0)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
            }
            if (cm ==1)
            {
                Form2 o = new Form2();
                o.Show();
            }
                   
           if (cm>0) cm--;

            label2.Text = cm.ToString();
                try {
                    in1 = Convert.ToInt32(domainUpDown1.Text);
                    in2 = Convert.ToInt32(domainUpDown2.Text);
                    in3 = Convert.ToInt32(domainUpDown3.Text);
                    in4 = Convert.ToInt32(domainUpDown4.Text);

                        if (in1 == (l3 + l5))
                        {
                        domainUpDown1.BackColor = Color.Green;
                        domainUpDown1.ReadOnly = true;
                        r1 = 1;

                        }
                        if (in2 == (l10 - l8))
                        {
                        domainUpDown2.BackColor = Color.Green;
                        domainUpDown2.ReadOnly = true;
                        r2 = 1;
                        }
                        if (in3 == (l14 * l12))
                        {
                        domainUpDown3.BackColor = Color.Green;
                        domainUpDown3.ReadOnly = true;
                        r3 = 1;
                        }
                        if (in4 == (l18 / l16))
                        {
                        domainUpDown4.BackColor = Color.Green;
                        domainUpDown4.ReadOnly = true;
                        r4 = 1;
                        }
                    r = r1 + r2 + r3 + r4;
                        label19.Text = r.ToString();
                    if (r == 4)
                        {
                        timer1.Stop();
                        time = c;
                        score = c * 120;
                        if (cm > 0)
                    {
                        MessageBox.Show("Time: " + time, "Score: " + score);
                    }else
                    {
                        MessageBox.Show("time: " + time, "Your time was more than 120sec, you lose");
                    }
                        }
                }catch { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            domainUpDown1.BackColor = Color.White;
            domainUpDown1.ReadOnly =false;
            domainUpDown2.BackColor = Color.White;
            domainUpDown2.ReadOnly = false;
            domainUpDown3.BackColor = Color.White;
            domainUpDown3.ReadOnly = false;
            domainUpDown4.BackColor = Color.White;
            domainUpDown4.ReadOnly = false;
            r1 = r2 = r3 = r4 = 0;
            r = 0;
            c = 0;
            cm = 120;
            timer1.Start();
            Random num = new Random();
             l3 = num.Next(100);
             l5 = num.Next(100);
             l10 = num.Next(100);
             l8 = num.Next(100);
             l14 = num.Next(100);
             l12 = num.Next(100);
             l18 = num.Next(100);
             l16 = num.Next(100);
            label3.Text = l3.ToString();
            label5.Text = l5.ToString();
            label10.Text = l10.ToString();
            label8.Text = l8.ToString();
            label14.Text = l14.ToString();
            label12.Text = l12.ToString();
            label18.Text = l18.ToString();
            label16.Text = l16.ToString();
             show1 = l3 + l5;
             show2 = l10 + l8;
             show3 = l14 + l12;
             show4 = l18 + l16;
            
        }
    }
}
