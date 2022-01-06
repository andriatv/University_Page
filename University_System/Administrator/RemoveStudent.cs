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
    public partial class RemoveStudent : Form
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "select * from Student";
            con.ExecuteQueries(query);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(
              query, con.getConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewDeleteStudent.DataSource = ds.Tables[0];
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE Your Data.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Connection_Query con = new Connection_Query();
                con.OpenConection();
                string query = "delete from NewAddmission where NAID = " + txtRegID.Text + "";
                con.ExecuteQueries(query);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(
                query, con.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Account Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
