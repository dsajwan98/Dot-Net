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
    public partial class MyFirstWebForm : System.Web.UI.Page
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
       
        protected void Page_Load(object sender, EventArgs e)
        {
            dbc obj = new dbc();
            if (!IsPostBack)
            {
                
                string sql = "spGetAllStateName";
                obj.connect(sql);
                if (obj.ds.Tables[0].Rows.Count > 0)
                {
                    DDstate.Items.Add("Select State");
                    for (int i = 0; i < obj.ds.Tables[0].Rows.Count; i++)
                    {
                        DDstate.Items.Add(obj.ds.Tables[0].Rows[i][0].ToString());
                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string emailid = txtEmailId.Text;
            string state = DDstate.SelectedValue;
            string city = DDcity.SelectedValue;
            string pincode = txtPin.Text;
            string gender = string.Empty;
            string programming = string.Empty;
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            else if(rdbFemale.Checked)
            {
                gender = "Female";
            }
            if (chbJava.Checked)
            {
                programming = chbJava.Text;
            }
            if (chbDotNet.Checked)
            {
                programming = programming + "," + chbDotNet.Text;
            }
            if (chbPython.Checked)
            {
                programming = programming + "," + chbPython.Text;
            }
            if (chbCpp.Checked)
            {
                programming =programming+","+ chbCpp.Text;
            }
            dbc obj = new dbc();

            if (String.IsNullOrEmpty(firstname))
            {
                lblSubmit.Text = "Please insert firstname";

            }
            else if (String.IsNullOrEmpty(lastname))
            {
                lblSubmit.Text += "Please insert lastname";
                return;
            }
            else if (String.IsNullOrEmpty(username))
            {
                lblSubmit.Text = "Please insert username";
                return;
            }
            else if (String.IsNullOrEmpty(password))
            {
                lblSubmit.Text = "Please insert password";
                return;
            }
            else if (String.IsNullOrEmpty(emailid))
            {
                lblSubmit.Text = "Please insert emailid";
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            // string sql = "insert into registration values('"+firstname+"','"+lastname+"','"+username+"','"+password+"','"+emailid+"')";
            string sql = "spInsertRegistrationData";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", firstname);
            cmd.Parameters.AddWithValue("@LastName", lastname);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@EmailId", emailid);
            cmd.Parameters.AddWithValue("@State",state);
            cmd.Parameters.AddWithValue("@City",city);
            cmd.Parameters.AddWithValue("@Pincode", pincode);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Programming", programming);

            int Result = cmd.ExecuteNonQuery();
            if (Result == 1)
            {
                lblSubmit.Text = "Registration done Successfully!";
                this.ClearTextBox();
            }
            else
            {
                lblSubmit.Text = "Error Occurred  !!! Response not generated....";
            }
            conn.Close();


        }
        public void ClearTextBox()
        {
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmailId.Text = String.Empty;
            
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RegistrationData.aspx");
        }

        protected void DDstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                DDcity.Items.Clear();
                DDcity.Items.Add("Select City");
            }
            string stateName = DDstate.SelectedValue;
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "GetAllCityName";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StateName", stateName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DDcity.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }

        }

        protected void DDcity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cityName = DDcity.SelectedValue;
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sql = "GetPinCode";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@city", cityName);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
                    txtPin.Text = ds.Tables[0].Rows[i][0].ToString();
            }

           
        }
    }
}