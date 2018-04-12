using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;
using System.Threading;

namespace Q2
{
    public partial class Form1 : Form
    {
        //MySqlConnection conn;
       // MySqlCommand comm;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;

        public void connect1()
        {
            server = "localhost";
            database = "lab3";
            uid = "root";
            password = "akshay";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void q1_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");
                
                cm.Connection = connection;
                cm.CommandText = "update parti set dam_amt = 30000 where regno = 22 ";
                Console.WriteLine(cm.CommandText);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                cm.CommandText = "select * from lab3.parti ";
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
                DataTable dts = new DataTable();
                sda.Fill(dts);
                BindingSource bs = new BindingSource();

                bs.DataSource = dts;
                dataGridView1.DataSource = bs;
                sda.Update(dts);
               
                Console.WriteLine("yolo");
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void q7_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");

                cm.Connection = connection;
                cm.CommandText = "select name as Owner_Name , count(report_num) as Num_Of_Acci , sum(dam_amt) as Total_Damage from parti , person" +
                    " where parti.driverid = person.driverid" +
                    " group by (name) order by Total_Damage desc";
                Console.WriteLine(cm.CommandText);
                cm.CommandType = CommandType.Text;

                ds = new DataSet();
                da = new MySqlDataAdapter(cm.CommandText, connection);
                da.Fill(ds, "sql2");
                dt = ds.Tables["sql2"];
                dr = dt.Rows[0];

               // MessageBox.Show(dr["Num_Of_Acci"].ToString());
                cm.ExecuteNonQuery();

                cm.CommandText = "select name as Owner_Name , count(report_num) as Num_Of_Acci , sum(dam_amt) as Total_Damage from parti , person" +
                    " where parti.driverid = person.driverid" +
                    " group by (name) order by Total_Damage desc";
                cm.CommandType = CommandType.Text;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
                DataTable dts = new DataTable();
                sda.Fill(dts);

                BindingSource bs = new BindingSource();

                bs.DataSource = dts;
                dataGridView1.DataSource = bs;
                sda.Update(dts);
                //cm.ExecuteNonQuery();
                Console.WriteLine("yolo");
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void q2_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");

                cm.Connection = connection;
                cm.CommandText = "delete from accident where extract(year from acci_date) = 2010";
                Console.WriteLine(cm.CommandText);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();

                cm.CommandText = "select * from lab3.parti ";
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
                DataTable dts = new DataTable();
                sda.Fill(dts);
                BindingSource bs = new BindingSource();

                bs.DataSource = dts;
                dataGridView1.DataSource = bs;
                sda.Update(dts);
                //cm.ExecuteNonQuery();
                Console.WriteLine("yolo");
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void q3_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");

                cm.Connection = connection;
                cm.CommandText = "alter table car add brand varchar(20)";
                Console.WriteLine(cm.CommandText);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                
                cm.CommandText = "select * from lab3.car ";
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
                DataTable dts = new DataTable();
                sda.Fill(dts);
                BindingSource bs = new BindingSource();

                bs.DataSource = dts;
                dataGridView1.DataSource = bs;
                sda.Update(dts);
                
                Console.WriteLine("yolo");
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }



        }


        private void q3d_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");

                cm.Connection = connection;
                cm.CommandText = "alter table car drop column brand";
                Console.WriteLine(cm.CommandText);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();

                cm.CommandText = "select * from lab3.car ";
                MySqlDataAdapter sda2 = new MySqlDataAdapter();
                sda2.SelectCommand = cm;
                DataTable dts2 = new DataTable();
                sda2.Fill(dts2);
                BindingSource bs2 = new BindingSource();

                bs2.DataSource = dts2;
                dataGridView1.DataSource = bs2;
                sda2.Update(dts2);
                Console.WriteLine("yolo");
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void q5_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");

                cm.Connection = connection;
                cm.CommandText = "select count(regno) as p from parti" + 
                    " where parti.report_num in (select report_num from accident where extract(year from acci_date) = 2010)";
                Console.WriteLine(cm.CommandText);
                cm.CommandType = CommandType.Text;

                ds = new DataSet();
                da = new MySqlDataAdapter(cm.CommandText, connection);
                da.Fill(ds, "sql1");
                dt = ds.Tables["sql1"];
                dr = dt.Rows[0];
                
                MessageBox.Show(dr["p"].ToString());
                cm.ExecuteNonQuery();

                cm.CommandText = "select count(regno) as p from parti" +
                    " where parti.report_num in " + 
                    "(select report_num from accident where extract(year from acci_date) = 2010)";
                cm.CommandType = CommandType.Text;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
                DataTable dts = new DataTable();
                sda.Fill(dts);
                
                BindingSource bs = new BindingSource();

                bs.DataSource = dts;
                dataGridView1.DataSource = bs;
                sda.Update(dts);
                //cm.ExecuteNonQuery();
                Console.WriteLine("yolo");
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void q6_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");

                cm.Connection = connection;
                cm.CommandText = "select count(report_num) as x from parti" +
                    " where parti.regno in " +
                    "(select regno from car where model like 'honda%')";
                Console.WriteLine(cm.CommandText);
                cm.CommandType = CommandType.Text;

                ds = new DataSet();
                da = new MySqlDataAdapter(cm.CommandText, connection);
                da.Fill(ds, "sql2");
                dt = ds.Tables["sql2"];
                dr = dt.Rows[0];

                MessageBox.Show(dr["x"].ToString());
                cm.ExecuteNonQuery();

                cm.CommandText = "select count(report_num) as x from parti" +
                    " where parti.regno in " +
                    "(select regno from car where model like 'honda%')";
                cm.CommandType = CommandType.Text;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
                DataTable dts = new DataTable();
                sda.Fill(dts);

                BindingSource bs = new BindingSource();

                bs.DataSource = dts;
                dataGridView1.DataSource = bs;
                sda.Update(dts);
                //cm.ExecuteNonQuery();
                Console.WriteLine("yolo");
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void q9_Click(object sender, EventArgs e)
        {
            try
            {
                connect1();
                MySqlCommand cm = new MySqlCommand("");

                cm.Connection = connection;
                cm.CommandText = "select name from person" +
                    " where driverid in" +
                    "(select driverid from person left join parti on person.driverid <> parti.driverid)";
                Console.WriteLine(cm.CommandText);
                cm.CommandType = CommandType.Text;

                ds = new DataSet();
                da = new MySqlDataAdapter(cm.CommandText, connection);
                da.Fill(ds, "sql2");
                dt = ds.Tables["sql2"];
                dr = dt.Rows[0];

               // MessageBox.Show(dr["x"].ToString());
                cm.ExecuteNonQuery();

                cm.CommandText = "select name from person" +
                    " where driverid in" +
                     "(select driverid from person left join parti on person.driverid <> parti.driverid)";
                cm.CommandType = CommandType.Text;
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
                DataTable dts = new DataTable();
                sda.Fill(dts);

                BindingSource bs = new BindingSource();

                bs.DataSource = dts;
                dataGridView1.DataSource = bs;
                sda.Update(dts);
                //cm.ExecuteNonQuery();
                Console.WriteLine("yolo");
                connection.Close();
            }
            catch (Exception ew)
            {
                Console.WriteLine("Error: " + ew);
                // Console.WriteLine(ew.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
