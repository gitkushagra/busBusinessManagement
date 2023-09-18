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
    public partial class adminroutes : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
              "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cost_TextChanged(object sender, EventArgs e)
        {

        }

        protected void addroutebtnm_Click(object sender, EventArgs e)
        {
            string rnum = routeno.Text;
            string source = sourceloc.Text;
            string des = destination.Text;
            string c = cost.Text;


            SqlConnection conn = new SqlConnection(ConString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_addroute", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@routenum", Convert.ToInt32(rnum));
            cmd.Parameters.AddWithValue("@fromloc", source);
            cmd.Parameters.AddWithValue("@toloc", des);
            cmd.Parameters.AddWithValue("@cost", c);
            SqlDataAdapter sdaconn = new SqlDataAdapter(cmd);
            DataTable dtconn = new DataTable();
            sdaconn.Fill(dtconn);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Route Added Successfully.')", true);
        }

        protected void removeroutebtn_Click(object sender, EventArgs e)
        {
            string rnum = routeno.Text;
            


            SqlConnection connrem = new SqlConnection(ConString);
            connrem.Open();
            SqlCommand cmdrem = new SqlCommand("sp_removeroute", connrem);
            cmdrem.CommandType = CommandType.StoredProcedure;
            cmdrem.Parameters.AddWithValue("@routenum", Convert.ToInt32(rnum));
            SqlDataAdapter sdaconn = new SqlDataAdapter(cmdrem);
            DataTable dtconnrem = new DataTable();
            sdaconn.Fill(dtconnrem);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Route Removed Successfully..')", true);

        }
    }
}