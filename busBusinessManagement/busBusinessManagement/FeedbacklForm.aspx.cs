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
    public partial class FeedbacklForm : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
                "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitfeedback_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_isUserNameExist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    con.Close();
                    con.Open();
                    SqlCommand feedbackvar = new SqlCommand("sp_isUserNameExist", con);
                    feedbackvar.CommandType = CommandType.StoredProcedure;
                    feedbackvar.Parameters.AddWithValue("@username", username.Text);
                    feedbackvar.Parameters.AddWithValue("@feedback", feedback.Text);
                    SqlDataAdapter sdafeedback = new SqlDataAdapter(feedbackvar);
                    DataTable dtfeed = new DataTable();
                    sda.Fill(dtfeed);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Success.!')", true);

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('User Not Found!')", true);
                }
                con.Close();
            }
            catch (Exception exc)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Exception')", true);
            }
        }
    }
}