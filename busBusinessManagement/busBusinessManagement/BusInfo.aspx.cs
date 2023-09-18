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
    public partial class BusInfo : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
               "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                viewBusesInfo();
            }

        }
        public void viewBusesInfo()
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("sp_busInfo", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            businfogrid.DataSource = dt1;
            businfogrid.DataBind();
            SqlCommand cmd2 = new SqlCommand("sp_loadacbuses", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            acbuseslist.DataSource = dt2;
            acbuseslist.DataBind();
            con.Close();
        }

        protected void dispalyAllBuses_Click(object sender, EventArgs e)
        {
            
        }

        protected void businfogrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void acbuseslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        protected void loogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginPage.aspx");
        }

       
    }
}