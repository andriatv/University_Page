using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_System.Administrator;

namespace University_System
{
    public partial class AdministratorView : Form
    {
        public AdministratorView()
        {
            InitializeComponent();
        }

        private void newAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            New_Addmission na = new New_Addmission();
            na.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void removeTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveTeacher rs = new RemoveTeacher();
            rs.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

      

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourse mc = new ManageCourse();
            mc.Show();
        }
    }
}
