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
    public partial class ex12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] == null)
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from tblProductInventory", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Cache["Data"] = ds;

                    gvProduct.DataSource = ds;
                    gvProduct.DataBind();
                }
                lblMessage.Text = "Data loaded from the Database";
            }
            else
            {
                gvProduct.DataSource = (DataSet)Cache["Data"];
                gvProduct.DataBind();

                lblMessage.Text = "Data loaded from the Cache";
            }
        }

        protected void btnClearCache_Click(object sender, EventArgs e)
        {
            //remove cache form obj
            if (Cache["Data"] != null)
            {
                Cache.Remove("Data");
                lblMessage.Text = "The DataSet is Removed from the cache";

                gvProduct.DataSource = null;
                gvProduct.DataBind();
            }
            else
            {
                lblMessage.Text = "There is nothing in the cache to be removed";
            }
        }
    }
}