using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static University_System.Connection_Class;

namespace University_System.Teacher
{
    class TeacherRepository
    {
        public TeacherModels Login(string username, string password)
        {
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "select * from Teacher where username = '" + username + "';";
            con.ExecuteQueries(query);

            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = new SqlCommand(
                query, con.getConnection());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.CloseConnection();
            string actualPassword = (string)DS.Tables[0].Rows[0]["password"];
            string actualUsername = (string)DS.Tables[0].Rows[0]["username"];
            string actualFullName = (string)DS.Tables[0].Rows[0]["fullName"];
            
            if (password == actualPassword)
            {
                TeacherModels teacherModel = new TeacherModels(actualUsername, actualFullName);
                return teacherModel;
            }
            else
            {
                return null;
            }
        }
    }
}
