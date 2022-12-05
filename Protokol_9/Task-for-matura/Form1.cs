using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_for_matura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Желаете ли да излезете от приложението?", "Потвърждаване на изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            txtInput.Text = " ";
            lblResult.Text = " ";
            txtInput.Focus();

        }

        private void cmdres_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == " ")
            {
                MessageBox.Show("Грешка при въвеждане! Няма нищо :(");
                cmdNew_Click(sender, e);
            } else
            {
                bool flag = false;
                int br = 0;
                int m = 0;
                if (radioButton2.Checked) flag = true;
                if (radioButton1.Checked)
                {
                    for (int i = 0; i < txtInput.Text.Length; i++)
                    {
                        if ((System.Char.IsDigit(txtInput.Text, i) == true) || (txtInput.Text[i] == ',')) ;
                        br = br + 1;
                        if (txtInput.Text[i] == ',') m = m + 1;
                        if (m <= 1 && ((br == txtInput.Text.Length) || ((br == txtInput.Text.Length - 1) && (txtInput.Text[0] == '-')))) flag = true;
                        if (flag == true)
                        {
                            if (ButtonKV.Checked == true)
                            {
                                double a;
                                a = double.Parse(txtInput.Text);
                                if (a >= 0)
                                {
                                    a = Math.Sqrt(a);
                                    lblResult.Text = a.ToString();

                                } else if (a < 0) {
                                    MessageBox.Show("Въвели сте отрицателно число!", "Грешка при въвеждане!");
                                    cmdNew_Click(sender, e);
                                }
                                if (ButtonStepen.Checked == true)
                                {
                                    double x, n;
                                    x = double.Parse(txtInput.Text);
                                    n = double.Parse(TxtStepen.Text);
                                    a = Math.Pow(x, n);
                                    lblResult.Text = a.ToString();
                                } else
                                {
                                    MessageBox.Show("Не сте въвели числова стойност!", "Грешка при въвеждане!");
                                }
                                cmdNew_Click(sender, e);

                            }
                        }
                    }
                }

            }
            int p = 0;
            int p1 = 0;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e, ref int p, ref int p1)
        {
            if ((radioButton2.Checked == true) && (ButtonKV.Checked == true))
            {
                if (((e.KeyChar < (char)Keys.D0) || (e.KeyChar > (char)Keys.D9)) && (!(e.KeyChar == (char)',')) && !(e.KeyChar == (char)'-') && (!(e.KeyChar == (char)Keys.Back))) e.KeyChar = (char)0;
            }
            if (e.KeyChar == (char)',') p = p + 1;
            if (e.KeyChar == (char)'-') p1 = p1 + 1;
            if ((e.KeyChar == (char)',') && (p > 1)) e.KeyChar = (char)0;
            if ((e.KeyChar == (char)'-') && (p1 > 1)) e.KeyChar = (char)0;
        }

    }
}

