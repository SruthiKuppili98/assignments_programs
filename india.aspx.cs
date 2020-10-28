using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class Datagriddatatable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            using (SqlConnection Connect = new SqlConnection("data source=. ; database = Asp.net;integrated security=SSPI"))
            {
              SqlDataAdapter SDA = new SqlDataAdapter("Select * from employee",Connect); 
                SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from student", Connect);
                SqlDataAdapter SDA2 = new SqlDataAdapter("Select * from IndianCricketTeam", Connect);
                SqlDataAdapter SDA3 = new SqlDataAdapter("Select * from BanKTable", Connect);
                SqlDataAdapter SDA4 = new SqlDataAdapter("Select * from IndianRailwaySystem", Connect);
                DataSet ds = new DataSet();

                SDA.Fill(ds);
                SDA1.Fill(ds);
                SDA2.Fill(ds);
                SDA3.Fill(ds);
                SDA4.Fill(ds);

                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();


            }
        }

        protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
