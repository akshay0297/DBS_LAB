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
    public partial class Form1 : Form
    {
        public static String username = "akshay";
        public static String password = "akshay";
        public static String lstacc = DateTime.Now.ToString();
        public static double bal = 1000000.00;
        public static string[,] trans = new string[5,2];

            

        public Form1()
        {
            InitializeComponent();
            trans[0, 0] = "Amit";
            trans[0, 1] = "5000";
            trans[1, 0] = "Pranit";
            trans[1, 1] = "6000";
            trans[2, 0] = "Mahesh";
            trans[2, 1] = "7000";
            trans[3, 0] = "Pandit";
            trans[3, 1] = "8000";
            trans[4, 0] = "Sachin";
            trans[4, 1] = "9000";

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void login_Click(object sender, EventArgs e)
        {
            if (user.Text == username && pass.Text == password)
            {
                lstacc = DateTime.Now.ToString();
                MessageBox.Show("Login Successful");
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please Try Again");  
            }
        }

        private void cpass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
            
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            pass.PasswordChar = '*';
        }
    }
}
