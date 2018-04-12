using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculator
{
    public partial class Form1 : Form
    {
        string inp = string.Empty;
        string op1 = string.Empty;
        string op2 = string.Empty;
        char op;
        double res = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "1";
            this.textBox1.Text += inp;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "2";
            this.textBox1.Text += inp;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "3";
            this.textBox1.Text += inp;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "4";
            this.textBox1.Text += inp;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "5";
            this.textBox1.Text += inp;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "6";
            this.textBox1.Text += inp;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "7";
            this.textBox1.Text += inp;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "8";
            this.textBox1.Text += inp;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "9";
            this.textBox1.Text += inp;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            inp = inp + "0";
            this.textBox1.Text += inp;
        }

        private void add_Click(object sender, EventArgs e)
        {
            op1 = inp;
            op = '+';
            inp = string.Empty;
        }

        private void subt_Click(object sender, EventArgs e)
        {
            op1 = inp;
            op = '-';
            inp = string.Empty;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            op1 = inp;
            op = '*';
            inp = string.Empty;
        }

        private void divd_Click(object sender, EventArgs e)
        {
            op1 = inp;
            op = '/';
            inp = string.Empty;
        }
        
        private void equl_Click(object sender, EventArgs e)
        {
            op2 = inp;
            double n1, n2;
            double.TryParse(op1, out n1);
            double.TryParse(op2, out n2);
            if (op== '+')
                {
                    res = n1 + n2;
                    this.textBox1.Text = res.ToString();
                }
            else if (op == '-')
                {
                    res = n1 - n2;
                    textBox1.Text = res.ToString();
                }
            else if (op == '*')
                {
                    res = n1 * n2;
                    textBox1.Text = res.ToString();
                }
            else if (op == '/')
                    {
                         if (n2 != 0)
                            {
                                res = n1 / n2; textBox1.Text =
                                res.ToString();
                             }
                         else
                            {
                               textBox1.Text = "Division byZero!";
                            }
                    }
                inp = string.Empty;
            
          }

        

        private void sin_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * 
                (Convert.ToDouble(textBox1.Text))));
        }

        private void cos_Click(object sender, EventArgs e)
        {
           textBox1.Text =  Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * 
                (Convert.ToDouble(textBox1.Text))));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text)));
        }

        private void tan_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * 
                (Convert.ToDouble(textBox1.Text))));
        }

        private void pi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592654";
        }
    }
    }

