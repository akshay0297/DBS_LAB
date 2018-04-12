using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text.Equals("admin") && pass.Text.Equals("asdfg"))
            {
                MessageBox.Show("Hello " + user.Text + "  Login Successful");
            }
            else
            {
                MessageBox.Show("Login Unsuccessful");
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = '*' ;
             
        }
    }
}
