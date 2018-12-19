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
    public partial class ex8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand command = new SqlCommand("select Name, Gender, Salary, (Salary * 0.5) + Salary as TotalSalary from tblEmployees", con);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //DataTable Table = new DataTable();
                    //Table.Columns.Add("ID");
                    //Table.Columns.Add("Name");
                    //Table.Columns.Add("Gender");
                    //Table.Columns.Add("Salary");

                    //while (reader.Read())
                    //{
                    //    DataRow dataRow = Table.NewRow();

                    //    dataRow["ID"] = reader["EmployeeId"];
                    //    dataRow["Name"] = reader["Name"];
                    //    dataRow["Gender"] = reader["Gender"];
                    //    dataRow["Salary"] = reader["Salary"];
                    //    Table.Rows.Add(dataRow);
                    //}

                    GridView.DataSource = reader;
                    GridView.DataBind();
                }                                  
            }
        }
    }
}