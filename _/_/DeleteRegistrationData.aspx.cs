using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace __
{
    public partial class DeleteRegistrationData : System.Web.UI.Page
    {
        
        string connectionString = ConfigurationManager.ConnectionStrings["Lbuffer"].ConnectionString;
        DataSet ds = new DataSet();
        protected registration regListObj = new registration();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { 
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                int i = Convert.ToInt32(Request.Params["Id"]);
                //String sql = "select * from Registration where id='" + i + "'";
                String sql = "spEditRegistrationData";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", i);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblFirstName.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
                    lblLastName.Text = ds.Tables[0].Rows[0]["last_name"].ToString();
                    lblUserName.Text = ds.Tables[0].Rows[0]["user_name"].ToString();
                    lblPassword.Text = ds.Tables[0].Rows[0]["password"].ToString();
                    lblEmailId.Text = ds.Tables[0].Rows[0]["email_id"].ToString();
                    
                }
                else
                {

                }
            }         

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string EmailId = lblEmailId.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            //String sql= "delete from Registration where email_id='"+EmailId+"'";
            String sql = "spDeleteRegistrationData";
           
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmailId",EmailId);
            int Result = cmd.ExecuteNonQuery();
            if (Result == 1)
            {
                Response.Redirect("~/RegistrationData.aspx");
            }
            else {
                lblMessage.Text = "Any error Please Check.";
            }
        }

        
    }
}