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
    public partial class ViewBookings : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
                "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }

        protected void bookingslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void displaybookings_Click(object sender, EventArgs e)
        {
            
               SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_loadBookings", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", usernametext.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            bookingslist.DataSource = dt;
            bookingslist.DataBind();
            con.Close();
        }

        protected void cancelbookingbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_cancelbooking", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", usernametext.Text);
                cmd.Parameters.AddWithValue("@fromcity", sourcecity.Text);
                cmd.Parameters.AddWithValue("@tolocation", destinationcity.Text);


                SqlDataReader srd = cmd.ExecuteReader();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Trip Cancelled!')", true);
            }
            catch(Exception exc)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please enter valid details. If multiple bookings, all same bookings are vanished!')", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home/Index");
        }
    }
}