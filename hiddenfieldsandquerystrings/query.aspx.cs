using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Querystrings
{
    public partial class Querystrings : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox1.Focus();
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Name" && TextBox2.Text == "Name")
                Response.Redirect("HomePage.aspx");
            else
                Label1.Text = "Login Failed";
            
        }
    }
}