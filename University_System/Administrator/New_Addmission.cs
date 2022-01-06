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

namespace University_System
{
    public partial class New_Addmission : Form
    {
        public New_Addmission()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String firstname = txtFirstlName.Text;
            String lastName = txtLastName.Text;
            String gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }

            String dob = dateTimePickerDOB.Text;
            String mobile = txtMobile.Text;
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String semester = txtSemester.Text;
            String program = txtProgram.Text;
            String groupe = txtGroup.Text;
            String duration = txtDuration.Text;
            String address = txtAddress.Text;

          
            Connection_Query con = new Connection_Query();
            con.OpenConection();

            string query = "insert into Student(firstname,lastName,gender,dob,mobile,email, username,password, semester,program, groupe,duration,address) values ('" + firstname + "','" + lastName + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + password + "','" + semester + "','" + program + "','" + groupe + "','" + duration + "','" + address + "')";
            con.ExecuteQueries(query);
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = new SqlCommand( query, con.getConnection());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.CloseConnection();
            MessageBox.Show("Data Saved. Remember the Regsitration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            /*  cmd.CommandText = select max(NAID) from Student;


              Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
              label15.Text = (abc + 1).ToString();*/
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstlName.Clear();
            txtLastName.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtSemester.ResetText();
            txtProgram.ResetText();
            txtGroup.ResetText();
            txtDuration.ResetText();
            txtAddress.Clear();
        }

        private void New_Addmission_Load(object sender, EventArgs e)
        {
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "select max(NAID) from Student";
            con.ExecuteQueries(query);
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = new SqlCommand(
                query, con.getConnection());
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label15.Text = (abc + 1).ToString();
        }
    }
}
