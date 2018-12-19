using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADO_DEMO
{
    public partial class ex10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using(SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Customers", con);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                GridView.DataSource = ds;
                GridView.DataBind();
            }
        }
    }
}