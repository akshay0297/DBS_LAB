using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string g = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            check();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Show();
                contact.Visible = false;
                email.Visible = false;
                addr.Visible = false;
            }
            else
            {
                groupBox1.Hide();
                contact.Visible = true;
                email.Visible = true;
                addr.Visible = true;
            }
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dob.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string f = fname.Text;
            string l = lname.Text;
            string d = dob.Text;
            string a = age.Text;
            string c = contact.Text;
            string em = email.Text;
            string ad = addr.Text;
            string co = course.Text;
            if (f.Length == 0 || l.Length == 0 || d.Length == 0 || a.Length == 0 || c.Length == 0 || em.Length == 0 || ad.Length == 0 || co.Length == 0)
            {
                MessageBox.Show("Error! Please Fill all the details");
            }

            else if (co.Length == 0)
            {
                MessageBox.Show("Error! Please Fill all the details");
            }
            else if (g.Length == 0)
            {
                MessageBox.Show("Error! Please Fill all the details");
            }
            else
            {
                MessageBox.Show(" Registration Successful \n Name : " + f + " " + l + "\n Thank You ! ");
            }
        }

        private void dob_TextChanged(object sender, EventArgs e)
        {
            string[] spt = dob.Text.Split(' ');
            string date = spt[0];
            dob.Text = date;
            dob.ReadOnly = true;
        }

       

        private void tandc_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
            submit.Enabled = tandc.Checked;
        }

        private void fbut_CheckedChanged(object sender, EventArgs e)
        {
            g = "Female";
        }

        private void mbut_CheckedChanged(object sender, EventArgs e)
        {
            g = "Male";
        }
    }
}
