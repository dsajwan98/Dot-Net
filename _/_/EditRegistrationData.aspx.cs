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
    public partial class EditRegistrationData : System.Web.UI.Page
    {
        static int result = 0;
        
        string connectionString = ConfigurationManager.ConnectionStrings["Lbuffer"].ConnectionString;
        DataSet ds = new DataSet();
        protected registration regListObj = new registration();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //if (result == 0)//
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                int id = Convert.ToInt32(Request.Params["Id"]);
                String sql = "spEditRegistrationData";
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtFirstName.Text = ds.Tables[0].Rows[0]["first_name"].ToString();
                    txtLastName.Text = ds.Tables[0].Rows[0]["last_name"].ToString();
                    txtUserName.Text = ds.Tables[0].Rows[0]["user_name"].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0]["password"].ToString();
                    txtEmailId.Text = ds.Tables[0].Rows[0]["email_id"].ToString();
                    txtPin.Text = ds.Tables[0].Rows[0]["pincode"].ToString();
                    
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                        {
                            DDstate.Items.Add(ds.Tables[1].Rows[i][0].ToString());
                        }
                    }
                    
                    string statename = ds.Tables[0].Rows[0]["state"].ToString();
                    DDstate.SelectedValue = statename;
                    string Gender = ds.Tables[0].Rows[0]["gender"].ToString();
                    string CityName = ds.Tables[0].Rows[0]["city"].ToString();
                    string programming = ds.Tables[0].Rows[0]["programming"].ToString();
                    ds.Tables.Clear();
                    sql = "GetAllCityName";

                    cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StateName",statename);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DDcity.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                        }
                    }
                    
                    DDcity.SelectedValue = CityName;
                    if (Gender == "Male")
                    {
                        rdbMale.Checked = true;
                    }
                    else if (Gender == "Female")
                    {
                        rdbFemale.Checked = true;
                    }
                    string[] str = programming.Split(',');
                    for (int i = 0; i < str.Count(); i++)
                    {
                        if (str[i] == "Java")
                        {
                            chbJava.Checked = true;
                        }
                        else if (str[i] == "DotNet")
                        {
                            chbDotNet.Checked = true;
                        }
                        else if (str[i] == "Cpp")
                        {
                            chbCpp.Checked = true;
                        }
                        else if (str[i] == "Python")
                        {
                            chbPython.Checked = true;
                        }
                        
                    }
                    //result++;
                }
                else
                {

                }
            }                                                                  
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            String FirstName = txtFirstName.Text;
            String LastName = txtLastName.Text;
            String UserName = txtUserName.Text;
            String Password = txtPassword.Text;
            String EmailId = txtEmailId.Text;
            string state = DDstate.SelectedValue;
            string city = DDcity.SelectedValue;
            string pincode = txtPin.Text;
            string gender = string.Empty;
            string programming = string.Empty;
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            else if (rdbFemale.Checked)
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
                programming = programming + "," + chbCpp.Text;
            }

            int i = Convert.ToInt32(Request.Params["Id"]);
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //String sql = "update registration set first_name='" + FirstName+ "',last_name='" + LastName+ "',user_name='" + UserName+ "',password='" + Password+ "',email_id='" + EmailId+ "'where id='"+i+"'" ;
            String sql = "spUpdateRegistrationData";
            
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@EmailId", EmailId);
            cmd.Parameters.AddWithValue("@State", state);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Pincode", pincode);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Programming", programming);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Response.Redirect("~/RegistrationData.aspx");
            }
            else {
                lblUpdate.Text = "There is any problem please check.";
            }

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
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    txtPin.Text = ds.Tables[0].Rows[i][0].ToString();
            }

        }

    }
}