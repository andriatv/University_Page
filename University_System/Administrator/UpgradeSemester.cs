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

namespace University_System.Administrator
{
    public partial class UpgradeSemester : Form
    {
        public UpgradeSemester()
        {
            InitializeComponent();
        }

      

        private void btnUpgrate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Semester Update Warning!", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-PO3M6CR9\\DATACAMP_SQL; database=University_page; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update Student set semester ='" + comboBoxTo.Text + "' where semester='" + comboBoxFrom.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Upgrade Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Upgrate Cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
