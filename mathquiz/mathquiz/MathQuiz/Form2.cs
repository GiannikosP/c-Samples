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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int num, sum,num1;
        bool plus = false;
        bool minus = false;
        bool mult = false;
        bool div = false;
        


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            if (plus == true)
            {
                
                sum = num + num1;
            }else if (minus == true)
            {
                sum = num - num1;
            }else if (mult == true)
            {
                sum = num * num1;
            }else if (div == true)
            {
                sum = num / num1;
            }
            textBox1.Clear();
            textBox1.Text = sum.ToString();
            button13.Enabled =true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
             plus = false;
             minus = false;
             mult = false;
            div = false;



        }

        private void button16_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            mult = true;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            textBox1.Clear();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            textBox1.Text = textBox1.Text + but.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            plus = true;
            button16.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            minus = true;
            button13.Enabled = false;
            button16.Enabled = false;
            button15.Enabled = false;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);
            div = true;
            button13.Enabled = false;
            button14.Enabled = false;
            button16.Enabled = false;
            textBox1.Clear();
        }
    }
}
