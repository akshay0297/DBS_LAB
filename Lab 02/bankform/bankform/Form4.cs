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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void conform_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            if (uname.Text == Form1.username && pname.Text == Form1.password)
            {
                if (npass.Text == chpass.Text && npass.Text.Length != 0)
                {
                    Form1.password = npass.Text;
                    MessageBox.Show("Password Changed Successfully ");
                    this.Hide();
                    frm1.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("New Password and Confirm Password did not match  ");
                    this.Show();
                }

            }
            else
            {
                MessageBox.Show("Username or Old Password did not match");
                frm1.ShowDialog();
            }
        }
    }
}
