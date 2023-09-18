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
    public partial class adminbus : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
              "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(ConString);
                string sqlQuery1 = "select * from [dbo].[Route]";
                SqlDataAdapter sda1 = new SqlDataAdapter(sqlQuery1, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                slocation.DataSource = dt1;
                slocation.DataValueField = "From_Location";
                slocation.DataBind();
                slocation.Items.Insert(0, new ListItem("--select from--", "0"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void slocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fromLoc = slocation.SelectedValue;
            SqlConnection con1 = new SqlConnection(ConString);
            con1.Open();
            SqlCommand cmd = new SqlCommand("sp_fetchDestination", con1);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@From_Location", fromLoc);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            dlocation.DataSource = dt2;
            dlocation.DataValueField = "To_Location";
            dlocation.DataBind();

            dlocation.Items.Insert(0, new ListItem("--select to--", "0"));
            
        }

        protected void deletebusbtn_Click(object sender, EventArgs e)
        {
            string busnum = busid.Text;
            SqlConnection connrem = new SqlConnection(ConString);
            connrem.Open();
            SqlCommand cmdrem = new SqlCommand("sp_rembus", connrem);
            cmdrem.CommandType = CommandType.StoredProcedure;
            cmdrem.Parameters.AddWithValue("@busid", Convert.ToInt32(busnum));
            SqlDataAdapter sdaconn = new SqlDataAdapter(cmdrem);
            DataTable dtconnrem = new DataTable();
            sdaconn.Fill(dtconnrem);
            connrem.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Bus Removed!')", true);
        }

        protected void addbusbtn_Click(object sender, EventArgs e)
        {
            string busnum = busid.Text;
            string bname = busname.Text;
            string cbus = capacity.Text;
            string sloc = slocation.SelectedValue;
            string dloc = dlocation.SelectedValue;
            string snum = seatsnumber.Text;
            string btype = bustype.SelectedValue;
         
            SqlConnection conn = new SqlConnection(ConString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_addbus", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@busid", Convert.ToInt32(busnum));
            cmd.Parameters.AddWithValue("@busname", bname);
            cmd.Parameters.AddWithValue("@capacity", Convert.ToInt32(cbus));
            cmd.Parameters.AddWithValue("@fromloc", sloc);
            cmd.Parameters.AddWithValue("@toloc", dloc);
            cmd.Parameters.AddWithValue("@aseats", snum);
            cmd.Parameters.AddWithValue("@bustype", btype);
            SqlDataAdapter sdaconn = new SqlDataAdapter(cmd);
            DataTable dtconn = new DataTable();
            sdaconn.Fill(dtconn);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Bus Added Successfully.')", true);
        }
    }
}