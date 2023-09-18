using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace busBusinessManagement
{
    
    public partial class userRegistration : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
                "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                password.Enabled = false;
                name.Enabled = false;
                age.Enabled = false;
                gender.Enabled = false;
                createaccount.Enabled = false;

            }
        }

        protected void checkusername_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_isUserNameExist", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username",username.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Already Taken!')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Yay! You can use this username.')", true);
                password.Enabled = true;
                name.Enabled = true;
                age.Enabled = true;
                gender.Enabled = true;
                createaccount.Enabled = true;
            }
            con.Close();

        }

        protected void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void createaccount_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_getUserInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@age", age.Text);
                cmd.Parameters.AddWithValue("@gender", gender.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Welcome to Bus Yatra!')", true);
                con.Close();
            
           

            
        }

        protected void deleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Terminated! Account removed.')", true);
                con.Close();
            }
            catch (Exception exc)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please enter valid info.')", true);
            }
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginPage.aspx");
        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}