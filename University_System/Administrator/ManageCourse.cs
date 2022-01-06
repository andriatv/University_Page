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
    public partial class ManageCourse : Form
    {
        public ManageCourse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string label5 = txtCourseName.Text;
            string label1 = txtteacherID.Text;
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "insert into Course(course_name, teacher_id ) values ('" + txtCourseName.Text + "','" + txtteacherID.Text + "')";
            con.ExecuteQueries(query);
            con.ShowDataInGridView(query);
            con.CloseConnection();
            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }

       

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "select CID,course_name, fullName  from Course LEFT JOIN Teacher ON Teacher.tID = Course.teacher_id";
            con.ExecuteQueries(query);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(
              query, con.getConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewCourses.DataSource = ds.Tables[0];
        }
    }
}
