using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_DEMO
{
    public partial class ex11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using(SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("spGetData", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                da.Fill(ds);

                ds.Tables[0].TableName = "Product";
                ds.Tables[1].TableName = "Category";

                ProductGridView.DataSource = ds.Tables["Product"];
                ProductGridView.DataBind();

                CategoryGridView.DataSource = ds.Tables["Category"];
                CategoryGridView.DataBind();
            }
        }
    }
}