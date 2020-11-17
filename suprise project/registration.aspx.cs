using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Surprise_pro
{
    public partial class Registration : System.Web.UI.Page
    {

        protected System.Web.UI.HtmlControls.HtmlInputFile File1;
        protected System.Web.UI.HtmlControls.HtmlInputButton Register;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = "Registration Sucessfully!!!"; 
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationTableConnectionString"].ConnectionString);
            connect.Open();
            var insertQuery = "insert into Registration(UserName,Age,Gender)values (@UserName,@Age,@Gender)";
            SqlCommand cmd = new SqlCommand(insertQuery, connect);
            cmd.Parameters.AddWithValue("@UserName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
            cmd.Parameters.AddWithValue("Age",TextBox4.Text);
            cmd.Parameters.AddWithValue("@Gender", RadioButton2.Text);


            cmd.ExecuteNonQuery();
            
            connect.Close();
            //Response.Write("Thank u for ur Info!!!!!!!!!!!!!!!!!");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("Admin.aspx");
        }
    }
}