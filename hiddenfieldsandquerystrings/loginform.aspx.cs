using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Querystrings
{
    public partial class loginform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox3.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text == "Haritha" && TextBox2.Text == "Haritha123")
            {
                Response.Write("Login Successful");

                Response.Redirect("HomePage.aspx?name" + TextBox3.Text + "&pwd" + TextBox2.Text);

            }
            else
                Label1.Text = "Invalid User";

            if (TextBox3.Text == "Kavya" && TextBox2.Text == "Vegi")
            {
                Response.Write("Login Successful");

                Response.Redirect("HomePage.aspx?name" + TextBox3.Text + "&pwd" + TextBox2.Text);

            }
            else
                Label1.Text = "Invalid User";
            if (TextBox3.Text == "Sruthi" && TextBox2.Text == " ")
            {
                Response.Write("Login Successful");

                Response.Redirect("HomePage.aspx?name" + TextBox3.Text + "&pwd" + TextBox2.Text);

            }
            else
                Label1.Text = "Invalid User";
            if (TextBox3.Text == "Pratyshusha" && TextBox2.Text == "Voletti")
            {
                Response.Write("Login Successful");

                Response.Redirect("HomePage.aspx?name" + TextBox3.Text + "&pwd" + TextBox2.Text);

            }
            else
                Label1.Text = "Invalid User";
            if (TextBox3.Text == "Aditi" && TextBox2.Text == "AditiSingh")
            {
                Response.Write("Login Successful");

                Response.Redirect("HomePage.aspx?name" + TextBox3.Text + "&pwd" + TextBox2.Text);

            }
            else
                Label1.Text = "Invalid User";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
