using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static University_System.Connection_Class;

namespace University_System.Administrator
{
    public partial class SearchTeacher : Form
    {
        public SearchTeacher()
        {
            InitializeComponent();
        }

        private void SearchTeacher_Load(object sender, EventArgs e)
        {
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "select * from Teacher";
            con.ExecuteQueries(query);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(
                query, con.getConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "select * from Teacher where tID = " + textBox1.Text + "";
            con.ExecuteQueries(query);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(
               query, con.getConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
