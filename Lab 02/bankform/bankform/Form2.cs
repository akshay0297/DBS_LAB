using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = "Welcome " + Form1.username.ToUpper() +
                "\n Your Account Balance is " + Form1.bal +
                "\n Your Last Five Transactions are \n ";
            for (int i = 0; i < 5; i++)
            {
                label2.Text = label2.Text + "\n " + (i+1) + ". : " +
                    Form1.trans[i, 0] +" " + Form1.trans[i, 1]; 
            }
                                                                                                                    
        }

        private void fund_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            if (frm3.ShowDialog() == DialogResult.Cancel)
            {
                label2.Text = "Welcome " + Form1.username.ToUpper() +
                "\n Your Account Balance is " + Form1.bal +
                "\n Your Last Five Transactions are \n ";
                for (int i = 0; i < 5; i++)
                {
                    label2.Text = label2.Text + "\n " + (i + 1) + ". : " + 
                        Form1.trans[i, 0] + " " + Form1.trans[i, 1];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
