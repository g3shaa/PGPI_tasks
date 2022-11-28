using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true; label4.Visible = true;
            textBox3.Visible = false; label3.Visible = false;
            textBox2.Visible = false; label2.Visible = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true; label4.Visible = true;
            textBox3.Visible = true; label3.Visible = true;
            textBox2.Visible = false; label2.Visible = false;
        }
        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true; label4.Visible = true;
            textBox3.Visible = true; label3.Visible = true;
            textBox2.Visible = true; label2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                a = 0;
                textBox1.Text = "0";
            }
            try
            {
                b = int.Parse(textBox3.Text);
            } 
            catch (FormatException)
            {
                b = 0;
                textBox3.Text = "0";
            }
            try
            {
                c = int.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                c = 0;
                textBox2.Text = "0";
            }
            double S, P, p;
            if (radioButton1.Checked)
            {
                S = a * a; P = 4 * a;
            }
            else if (radioButton2.Checked) {
                S = a * b; P = 2 * (a + b);
            }
            else
            {
                P = a + b + c;  p = P / 2;
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            textBox4.Text = P.ToString();
            textBox5.Text = S.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            textBox4.Text = " 0";
            textBox5.Text = " 0";
            textBox1.Focus();
        }
    }
}
