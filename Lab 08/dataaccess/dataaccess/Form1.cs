using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace dataaccess
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void connect1()
        {
            String oradb = "Data Source=ictorcl;Persist Security Info=True;User ID=cc3110;Password=student";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try 
            {
                connect1(); 
                OracleCommand cm = new OracleCommand(); 
                cm.Connection = conn; 
                cm.CommandText = "insert into demo values('" + textBox1.Text + "'," +
                    textBox2.Text + ")";
                // if the type is varchar preceede the value by quote '
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("Inserted!"); 
                conn.Close(); 
            } 
            catch (Exception esp) 
            { 
                MessageBox.Show("Caught"); 
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
                {
                    connect1();
                    OracleCommand cm = new OracleCommand();
                    cm.Connection = conn;
                    cm.CommandText = "DELETE FROM demo "+ " WHERE id " + " = " +
                    textBox2.Text ;
                    cm.CommandType = CommandType.Text;
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Deleted!");
                    conn.Close();
                }
            catch (Exception ew)
                {
                    Console.WriteLine("Error: " + ew);
                    // Console.WriteLine(ew.StackTrace);
                }
                
        }

        private void select_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from demo";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "demo");
            dt = ds.Tables["demo"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox2.Text = dr["id"].ToString();
            textBox1.Text = dr["name"].ToString();
            conn.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                OracleCommand cm = new OracleCommand();
                cm.Connection = conn;
                cm.CommandText = "UPDATE demo " + " SET NAME " + " = '" +
                textBox1.Text + "' WHERE ID =" + textBox2.Text;
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                MessageBox.Show("updated!");
                conn.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            textBox1.Text = dr["name"].ToString();
            textBox2.Text = dr["id"].ToString();
        }
    }
}
