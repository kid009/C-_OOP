using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO_DEMO
{
    public partial class ex4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                con.Open();

                //Count Row
                //command.CommandText = "SELECT count(*) FROM Employees";
                //int TotalRows = (int)command.ExecuteScalar();
                //Response.Write("TotalRows = " + TotalRows.ToString());

                //Insert
                //command.CommandText = "INSERT INTO Categories VALUES ('test2', 'test2', '')";
                //int Total = command.ExecuteNonQuery();
                //Response.Write("Total Insert = " + Total.ToString());

                //Update
                //command.CommandText = "UPDATE Categories SET CategoryName = 'Computer', Description = 'Computer', Picture = '123456' WHERE CategoryID = '9'";
                //int Total = command.ExecuteNonQuery();
                //Response.Write("Total Update = " + Total.ToString());

                //delete
                command.CommandText = "DELETE FROM Categories WHERE CategoryID = '10'";               
                int Total = command.ExecuteNonQuery();
                Response.Write("Total Delete = " + Total.ToString());
            }
        }
    }
}