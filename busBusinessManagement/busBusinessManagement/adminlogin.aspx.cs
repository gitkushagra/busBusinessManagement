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
    public partial class adminlogin : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
                "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminpass_TextChanged(object sender, EventArgs e)
        {

        }

        protected void adloginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_adminlogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", adminuser.Text);
            cmd.Parameters.AddWithValue("@password", adminpass.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                Response.Redirect("Admin.aspx");
            }

            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Either username or password is incorrect.')", true);

            }
        }

        protected void homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home/Index");
        }

        protected void adminuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}