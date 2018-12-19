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
    public partial class ex9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using(SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("select * from Customers; select * from Employees", con);
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    CustomersGridView.DataSource = reader;
                    CustomersGridView.DataBind();

                    while (reader.NextResult())
                    {
                        EmployeesGridView.DataSource = reader;
                        EmployeesGridView.DataBind();
                    }
                    
                }
            }
        }
    }
}