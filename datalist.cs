using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class datalistex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add("FirstName");
            Table.Columns.Add("LastName");
            Table.Columns.Add("Designation");
            Table.Columns.Add("Location");
            Table.Columns.Add("Country");


            Table.Rows.Add( "Haritha","Yelleti", "s/w Engineer","Vizag","India");
            Table.Rows.Add("Sruthi", "Kupplili", "s/w Engineer", "Bangalore", "India");
            Table.Rows.Add("Pavan ", "Venkat", "Testing Engineer", "Hyderabad", "India");
            Table.Rows.Add("Satya", "Vastav", "Database Adminstrator", "Chennai", "India");
            Table.Rows.Add("Pawan", "Gandepalli", ".Net DEveloper", "California", "U.S");
            Table.Rows.Add("Aditya", "Kotari", "s/w Engineer", "Pune", "India");
           

            DataList1.DataSource = Table;
            DataList1.DataBind();
        }
    }
}
