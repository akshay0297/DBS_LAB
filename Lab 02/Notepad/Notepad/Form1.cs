using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Notepad.Form1 n = new Form1();
            n.Show();
        }

       // private string from_close()
        //{
         //   throw new NotImplementedException();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fnme.Length == 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text Document(*.txt)|*.txt|HTML Document(*.html)|*.html|All Files(*.*)|*.*";
                saveFileDialog1.ShowDialog();
                string fName = saveFileDialog1.FileName;
                fnme = fName;
                try
                {
                    StreamWriter sw = new StreamWriter(fName);
                    sw.Write(richTextBox1.Text);
                    sw.Flush();
                    sw.Close();
                } 
                catch (Exception g) { }
                this.Text = fnme;
            }
            else
            {
                StreamWriter sw = new StreamWriter(fnme);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open kar";
            dlg.Filter = "Text Document(*.txt)|*.txt|HTML Document(*.html)|*.html|All Files(*.*)|*.*";
            dlg.ShowDialog();
            string fName = dlg.FileName;
            fnme = fName;
            this.Text = fnme;
            try
                {
                    StreamReader sr = new StreamReader(fName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch(Exception f)
            {
                //MessageBox.Show(""+f);
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Document(*.txt)|*.txt|HTML Document(*.html)|*.html|All Files(*.*)|*.*";
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            fnme = fName;
            try
            {
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
            }
            catch (Exception g) { }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            //change_Pest();
        }

        private void change_Pest()
        {
            throw new NotImplementedException();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
            //change_Pest();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            //change_Pest();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = richTextBox1.SelectionColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad.Form1 x = new Form1();
            x.richTextBox1.Text = "This is an simple copy of notepad";
            x.Show();


        }
    }
}
