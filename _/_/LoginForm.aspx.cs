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
    public partial class LoginForm : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Lbuffer"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string Emailid = txtEmail.Text;
            string Password = txtPassword.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("splogin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", Emailid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (Emailid == ds.Tables[0].Rows[0][0].ToString() &&
                    Password == ds.Tables[0].Rows[0][1].ToString())
                {
                    Session["Emailid"] = Emailid;
                    Response.Redirect("~/RegistrationData.aspx");
                }
                else
                {
                    Lblmessage.Text = "wrong email id and password";
                }
            }
            else
            {
                Lblmessage.Text = "wrong emailid and password";
            }
        }

        protected void Btnsignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RegistrationData.aspx");
        }
    }
}