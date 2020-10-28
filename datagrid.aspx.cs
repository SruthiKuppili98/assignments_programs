using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DataGrid
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();

            Table.Columns.Add("ID");
            Table.Columns.Add("name");
            Table.Columns.Add("Email");

           
            Table.Rows.Add(101,"sruthi","sruthi.kuppili1998@gmail.com");
            Table.Rows.Add(101, "sruthi", "sruthi.kuppili1998@gmail.com");
            Table.Rows.Add(101, "sruthi", "sruthi.kuppili1998@gmail.com");
            Table.Rows.Add(101, "sruthi", "sruthi.kuppili1998@gmail.com");

            DataGrid1.DataSource = Table;
            DataGrid1.DataBind();
        }
    }
}