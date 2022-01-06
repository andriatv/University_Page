using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static University_System.Connection_Class;

namespace University_System
{
    class StudentRepository
    {
        public StudentModel Login(string username, string password)
        {
            Connection_Query con = new Connection_Query();
            con.OpenConection();
            string query = "select * from Student where username = '" + username + "';";
            con.ExecuteQueries(query);
          
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = new SqlCommand(
                query, con.getConnection());
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.CloseConnection();
            string actualPassword = (string)DS.Tables[0].Rows[0]["password"];
            string actualUsername = (string)DS.Tables[0].Rows[0]["username"];
            string actualFirstName = (string)DS.Tables[0].Rows[0]["firstName"];
            string actualLastName= (string)DS.Tables[0].Rows[0]["lastName"];
            
            if (password == actualPassword)
            {
                StudentModel studentModel = new StudentModel(actualUsername, actualFirstName,actualLastName);
                return studentModel;
            }
            else
            {
                return null;
            }
        }

    }
}
