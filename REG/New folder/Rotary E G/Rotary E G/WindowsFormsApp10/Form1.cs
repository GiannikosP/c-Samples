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
    public partial class Form1 : Form
    {
        public  int high = 0; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("please enter correct username");
            }
            else
            {

                string line;
                int exists = 0;
                using (StreamReader file = new StreamReader("usernames.txt"))
                    while ((line = file.ReadLine()) != null)
                    {

                        if (textBox1.Text == line)
                        {
                            exists = 0;
                            this.Hide();
                            Form2 obj = new Form2("Back " + textBox1.Text,high);
                            obj.Show();
                            exists = 1;
                        }
                        high++;
                    }
                if (exists == 0)
                {
                    using (StreamWriter w = new StreamWriter("usernames.txt", append: true))
                        w.WriteLine(textBox1.Text);
                    this.Hide();
                    Form2 obj = new Form2(textBox1.Text,high);
                    obj.Show();
                    
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
