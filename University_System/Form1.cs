using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_System.Teacher;

namespace University_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            wrongLabel.Visible = false;
            wrongLabelT.Visible = false;
            wrongLabelA.Visible = false;

        }

        private void txtSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSelectUser.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;

            }
            else if (txtSelectUser.SelectedIndex == 1)
            {
                panel2.Visible = true;
                panel1.Visible = false;
                panel3.Visible = false;
            }
            else if (txtSelectUser.SelectedIndex == 2)
            {
                panel3.Visible = true;
                panel2.Visible = false;
                panel1.Visible = false;
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txbTeacherPwrd.PasswordChar = '\0';
                checkBox1.Text = "Hide Password";

            }
            else
            {
                txbTeacherPwrd.PasswordChar = '*';
                checkBox1.Text = "Show Password";
            }
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                checkBoxShowHide.Text = "Hide Password";

            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Password";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtStudentpwrd.PasswordChar = '\0';
                checkBox2.Text = "Hide Password";

            }
            else
            {
                txtStudentpwrd.PasswordChar = '*';
                checkBox2.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txtUserName.Text == "Administrator" && txtPassword.Text == "admin123")

            //{
               // wrongLabelA.Visible = false;
                AdministratorView ad = new AdministratorView();
                ad.Show();
                this.Hide();
           //}
            //else {
              //  wrongLabelA.Visible = true;
           // }
           
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            StudentRepository sr = new StudentRepository();
            string username = txtStudentID.Text;
            string password = txtStudentpwrd.Text;
             StudentModel student =  sr.Login(username, password);
            if (student == null)
            {
                wrongLabel.Visible = true;

            }
            else {
                wrongLabelA.Visible = false;
                StudentView ad = new StudentView();
                ad.Show();
                this.Hide();
            }
    
        }

        private void btnTeachrLogin_Click(object sender, EventArgs e)
        {
           // TeacherRepository tr = new TeacherRepository();
            //string username = txtTeacherID.Text;
           // string password = txbTeacherPwrd.Text;
            //TeacherModels teacher = tr.Login(username, password);
           // if (teacher == null)
           // {
            //    wrongLabel.Visible = true;

          //  }
           // else
           // {
                wrongLabelA.Visible = false;
                TeacherView ad = new TeacherView();
                ad.Show();
                this.Hide();
            }
        }

 
    
}
