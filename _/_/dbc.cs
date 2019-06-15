using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace __
{
    public class dbc
    {
       
        
           public string connectionString = ConfigurationManager.ConnectionStrings["Lbuffer"].ConnectionString;
           public DataSet ds = new DataSet();
            public void connect(string sql)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
           

            
        
    }
}