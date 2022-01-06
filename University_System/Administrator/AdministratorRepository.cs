using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System.Administrator
{
    class AdministratorRepository
    {
        public AdministratorModel Login(string username, string password)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-PO3M6CR9\\DATACAMP_SQL; database = University_page; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "select * from Administrator where username = '" + username + "';";
            cmd.CommandText = query;

            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = new SqlCommand(query, con);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            string actualPassword = (string)DS.Tables[0].Rows[0]["password"];
            string actualUsername = (string)DS.Tables[0].Rows[0]["username"];
         

            if (password == actualPassword)
            {
                AdministratorModel adminModel = new AdministratorModel(actualUsername, actualPassword);
                return adminModel;
            }
            else
            {
                return null;
            }
        }

    }
}
