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
    public partial class loginPage : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
                "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_authenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    
                    Response.Redirect("Booking.aspx");
                }
            
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Either username or password is incorrect.')", true);
                   
                }
            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home/Index");
        }
    }
}