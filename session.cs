using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text == "P@ssword")
            {
                //Storing an email to te session
                Session["email"] = Email.Text;
                Session["mobile"] = Email.Text;
                Session["refrence"] = Email.Text;
                
            }
            //Checking  if session variable is empty
            if(Session["email"]!=null)
            {
                //Display the stored email
                Label1.Text = "This email is stored in session";
                Label2.Text = Session["email"].ToString();
            }
        }
    }
}
