using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_System
{
    class Connection_Class
    {
        public class Connection_Query
        {

            string ConnectionString = "data source = LAPTOP-PO3M6CR9\\DATACAMP_SQL; database = University_page; integrated security = True";
            SqlConnection con { get; set; }

            public SqlConnection getConnection()
            {
                return con;
            }

            public void OpenConection()
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
            }


            public void CloseConnection()
            {
                con.Close();
            }


            public void ExecuteQueries(string Query_)
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                cmd.ExecuteNonQuery();
            }


            public SqlDataReader DataReader(string Query_)
            {
                SqlCommand cmd = new SqlCommand(Query_, con);
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }


            public object ShowDataInGridView(string Query_)
            {
                Connection_Query con = new Connection_Query();
                SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
                dr.SelectCommand = new SqlCommand(Query_,
                                                  con.getConnection());
                DataSet ds = new DataSet();
                dr.Fill(ds);
                // object dataum = ds.Tables[0];
                // return dataum;
                return ds;
            }
        }
    }
}
