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
    public partial class RoutesDisplay : System.Web.UI.Page
    {
        string ConString = "Data Source=LP-TZD-0X110724;" +
               "Initial Catalog=busBusinessDatabase;User Id=sa; Password=cfg@1234; Integrated Security=SSPI";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                viewRoutes();
            }

        }

        protected void routesGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void viewRoutes()
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_displayRoutes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            routesGrid.DataSource = dt;
            routesGrid.DataBind();
        }

        

        protected void Home_Click(object sender, EventArgs e)
        {
            
        }

        protected void displayRoutes_Click(object sender, EventArgs e)
        {

        }
    }
}