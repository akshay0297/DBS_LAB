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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bname.Text == "")
            {
                MessageBox.Show("Enter Beneficiary Name ");
            }
            else if (amt.Text == "")
            {
                MessageBox.Show("Enter Amount");
            }
            else if (double.Parse(amt.Text) > Form1.bal)
            {
                MessageBox.Show("Insufficient Balance ");
            }
            else
            {
                Form1.bal -= double.Parse(amt.Text);
                for(int i = 4 ; i>0 ; i--)
                {
                    Form1.trans[i , 0] = Form1.trans[i-1, 0];
                    Form1.trans[i , 1] = Form1.trans[i-1, 1];
                }
                Form1.trans[0, 0] = bname.Text;
                Form1.trans[0, 1] = amt.Text;
                MessageBox.Show("Amount transferred is " + 
                    amt.Text + "\n Your new balance is " + Form1.bal);
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
            }

        }
    }
}
