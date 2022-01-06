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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            String gender = "";
            bool isChecked = radioMale.Checked;
            if (isChecked)
            {
                gender = radioMale.Text;
            }
            else
            {
                gender = radioFemale.Text;
            }
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "insert into Teacher(fullName,gender,dob,mobile,email, username,password, semester,program, duration,address) values ('" + txtFullName.Text+"','" + gender+ "','" + dateTimePickerDOB.Text + "'," + txtMobile.Text + ",'" + txtEmail.Text + "','" + txtUsername.Text + "','" + txtUsername.Text + "','" + txtSemester.Text + "','" + txtProgram.Text+ "','" +txtDuration.Text+ "','" +txtAddress.Text + "')";
            con.ExecuteQueries(query);
            con.ShowDataInGridView(query);
            con.CloseConnection();
            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
    }
}
