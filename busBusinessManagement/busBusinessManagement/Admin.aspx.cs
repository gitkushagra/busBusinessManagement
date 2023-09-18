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
    public partial class Admin : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
              "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            earningstxt.Enabled = false;
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string sqlQuery1 = "select * from [dbo].[Bookings]";
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlQuery1, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            showbookings.DataSource = dt1;
            showbookings.DataBind();
            con.Close();
            con.Open();
            string sqlQuery2 = "select * from [dbo].[bus_details]";
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlQuery2, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            showbusesinfo.DataSource = dt2;
            showbusesinfo.DataBind();
            con.Close();
            con.Open();
            string sqlQuery3 = "select * from [dbo].[feedbacks]";
            SqlDataAdapter sda3 = new SqlDataAdapter(sqlQuery3, con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            feedbackshow.DataSource = dt3;
            feedbackshow.DataBind();
            con.Close();
            con.Open();
            string sqlQuery4 = "select * from [dbo].[route]";
            SqlDataAdapter sda4 = new SqlDataAdapter(sqlQuery4, con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            routesview.DataSource = dt4;
            routesview.DataBind();
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SUM([amount]) from [dbo].[userbank]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader srd = cmd.ExecuteReader();
            while (srd.Read())
            {
                earningstxt.Text = srd.GetValue(0).ToString();
            }

            con.Close();
        }

        protected void deletebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBookings.aspx");
        }

        protected void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void showbookings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void showbusesinfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void deletefeedbackbtn_Click(object sender, EventArgs e)
        {
            string user = feedbackuser.Text;
          

            SqlConnection con2 = new SqlConnection(ConString);
            con2.Open();
            SqlCommand cmd = new SqlCommand("sp_deletefeedback", con2);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", user);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home/Index");
        }

        protected void managebuses_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbus.aspx");
        }

        protected void manageroutesbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminroutes.aspx");
        }

        protected void admincreateaccount_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("so_addadmin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Welcome to Bus Yatra ADMIN!')", true);
                con.Close();
            }
            catch (Exception exc)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please enter valid info.')", true);
            }
        }

        protected void deleteAdmin_Click(object sender, EventArgs e)
        {
            string adminuser = username.Text;
            SqlConnection con3 = new SqlConnection(ConString);
            con3.Open();
            SqlCommand cmd = new SqlCommand("sp_deleteAdmin", con3);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", adminuser);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Admin updated. Please login again.')", true);
        }
    }
}