using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bob = 0;
        private void radioButton1_Click(object sender, EventArgs e)
        {
            bob = 1;
            radioButton1.Click += button1_Click;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            bob = 2;
            radioButton2.Click += button1_Click;         
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            bob = 3;
            radioButton3.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rng = new Random();
            int ted = rng.Next(1, 4);
            if (bob == 1)
            {
                if (ted == 1)
                {
                    richTextBox1.Text = "com choose rock";
                    MessageBox.Show("ITS A TIE");
                }
                else if (ted == 2)
                {
                    richTextBox1.Text = "com choose paper";
                    MessageBox.Show("YOU LOSE");
                }
                else if (ted == 3)
                {
                    richTextBox1.Text = "com choose scissor";
                    MessageBox.Show("YOU WIN");
                }
            }
            else if (bob == 2)
            {
                if (ted == 1)
                {
                    richTextBox1.Text = "com choose rock";
                    MessageBox.Show("YOU WIN");
                }
                else if (ted == 2)
                {
                    richTextBox1.Text = "com choose paper";
                    MessageBox.Show("ITS A TIE");
                }
                else if (ted == 3)
                {
                    richTextBox1.Text = "com choose scissor";
                    MessageBox.Show("YOU LOSE");
                }

            }
            if (bob == 3)
            {
                if (ted == 1)
                {
                    richTextBox1.Text = "com choose rock";
                    MessageBox.Show("YOU LOSE");
                }
                else if (ted == 2)
                {
                    richTextBox1.Text = "com choose paper";
                    MessageBox.Show("YOU WIN");
                }
                else if (ted == 3)
                {
                    richTextBox1.Text = "com choose scissor";
                    MessageBox.Show("ITS A TIE");
                }
            }
            else
            {
                MessageBox.Show("please choose again");
            }
        }
    }
}

