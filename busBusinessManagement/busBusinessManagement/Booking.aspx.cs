using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace busBusinessManagement
{
    public partial class Booking : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
                "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cascadinglist();
                storeprice.Enabled = false;
                submittostore.Enabled = false;
                sourcelist.Enabled = false;
                destinationList.Enabled = false;
                selectbus.Enabled = false;
                bustype.Enabled = false;
                storerouteid.Enabled = false;
                storebusid.Enabled = false;
                seatsavailable.Enabled = false;
            }
            
            


        }
        public void cascadinglist()
        {
            SqlConnection con = new SqlConnection(ConString);
            string sqlQuery1 = "select * from [dbo].[Route]";
            SqlDataAdapter sda1 = new SqlDataAdapter(sqlQuery1, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            sourcelist.DataSource = dt1;
            sourcelist.DataValueField = "From_Location";
            sourcelist.DataBind();
            sourcelist.Items.Insert(0, new ListItem("--select from--", "0"));


            
            

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        protected void fetch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_fetchData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username.Text);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    name.Value = srd.GetValue(2).ToString();
                    age.Value = srd.GetValue(3).ToString();
                    gender.Value = srd.GetValue(4).ToString();
                }
                con.Close();
                sourcelist.Enabled = true;
                destinationList.Enabled = true;
                selectbus.Enabled = true;
                bustype.Enabled = true;
                storerouteid.Enabled = true;
                storebusid.Enabled = true;
                seatsavailable.Enabled = true;
            }
            catch(Exception exc)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please enter valid username.')", true);
            }
        }

        protected void sourcelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fromLoc = sourcelist.SelectedValue;
            SqlConnection con1 = new SqlConnection(ConString);
            con1.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchDestination", con1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@From_Location", fromLoc);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            destinationList.DataSource = dt2;
            destinationList.DataValueField = "To_Location";
            destinationList.DataBind();

            destinationList.Items.Insert(0, new ListItem("--select to--", "0"));
            fetch.Enabled = false;
        }

        protected void destinationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fromLoc = sourcelist.SelectedValue;
            string toLoc = destinationList.SelectedValue;

            SqlConnection con2 = new SqlConnection(ConString);
            con2.Open();
            SqlCommand cmd = new SqlCommand("sp_loadBusName", con2);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fromLoc", fromLoc);
            cmd.Parameters.AddWithValue("@toLoc", toLoc);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            selectbus.DataSource = dt;
            selectbus.DataValueField = "Bus_Name";
            selectbus.DataBind();
            selectbus.Items.Insert(0, new ListItem("--select bus--", "0"));
        }

        

        protected void selectbus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string busName = selectbus.SelectedValue;
            string fromLoc = sourcelist.SelectedValue;
            string toLoc = destinationList.SelectedValue;

            SqlConnection con2 = new SqlConnection(ConString);
            con2.Open();
            SqlCommand cmd = new SqlCommand("sp_loadBusType", con2);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@busname", busName);
            cmd.Parameters.AddWithValue("@fromloc", fromLoc);
            cmd.Parameters.AddWithValue("@toloc", toLoc);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bustype.DataSource = dt;
            bustype.DataValueField = "bus_type";
            bustype.DataBind();
            bustype.Items.Insert(0, new ListItem("--select bus type--", "0"));
        }

        protected void price_Click(object sender, EventArgs e)
        {

        }

       

        protected void bustype_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_loadrouteid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fromLoc", sourcelist.SelectedValue);
            cmd.Parameters.AddWithValue("@toLoc", destinationList.SelectedValue);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            storerouteid.DataSource = dt;
            storerouteid.DataValueField = "RouteID";
            storerouteid.DataBind();
            storerouteid.Items.Insert(0, new ListItem("--Generated Route--", "0"));
        }

     



        protected void storerouteid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_loadbusnumber", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@busname", selectbus.SelectedValue);
            cmd.Parameters.AddWithValue("@fromLoc", sourcelist.SelectedValue);
            cmd.Parameters.AddWithValue("@toLoc", destinationList.SelectedValue);
            cmd.Parameters.AddWithValue("@bustype", bustype.SelectedValue);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            storebusid.DataSource = dt;
            storebusid.DataValueField = "BusID";
            storebusid.DataBind();
            storebusid.Items.Insert(0, new ListItem("--Choose Bus No--", "0"));
        }

        protected void storebusid_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                string busName = selectbus.SelectedValue;
                string fromLoc = sourcelist.SelectedValue;
                string toLoc = destinationList.SelectedValue;
            string btype = bustype.SelectedValue;

                SqlConnection con2 = new SqlConnection(ConString);
                con2.Open();
                SqlCommand cmd = new SqlCommand("sp_loadbusnumber", con2);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@busname", busName);
                cmd.Parameters.AddWithValue("@fromloc", fromLoc);
                cmd.Parameters.AddWithValue("@toloc", toLoc);
            cmd.Parameters.AddWithValue("@bustype", btype);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                seatsavailable.DataSource = dt;
                seatsavailable.DataValueField = "Available_Seats";
                seatsavailable.DataBind();
                seatsavailable.Items.Insert(0, new ListItem("--Availabe Seats--", "0"));
            
        }

        protected void seatsavailable_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
                string price="0";
                string fromLoc = sourcelist.SelectedValue;
                string toLoc = destinationList.SelectedValue;
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_loadrouteid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fromloc", fromLoc);
                cmd.Parameters.AddWithValue("@toloc", toLoc);
                SqlDataReader srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    price = srd.GetValue(3).ToString();
                   
                }
                con.Close();
                int cost = Convert.ToInt32(price);

                if (bustype.SelectedValue == "AC")
                {
                    cost += 1000;
                }
                storeprice.Text = cost.ToString();
                submittostore.Enabled = true;

            
        }

        protected void submittostore_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_inserttobookings", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@name", name.Value);
                cmd.Parameters.AddWithValue("@age", age.Value);
                cmd.Parameters.AddWithValue("@gender", gender.Value);
                cmd.Parameters.AddWithValue("@busid", storebusid.SelectedValue);
                cmd.Parameters.AddWithValue("@routeid", storerouteid.SelectedValue);
                cmd.Parameters.AddWithValue("@amount", storeprice.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Ticket Booked!')", true);
            }
            catch(Exception exc)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Please enter valid details.')", true);
            }
        }

        protected void viewbookings_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBookings.aspx");
        }
    }
}