using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO_DEMO
{
    public partial class ex6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(CS))
            {
                string command = "SELECT * FROM Categories WHERE CategoryName like @CategoryName";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.Parameters.AddWithValue("@CategoryName", txtSearch.Text + "%");
                con.Open();
                GridView.DataSource = cmd.ExecuteReader();
                GridView.DataBind();
            }
        }
    }
}