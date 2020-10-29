using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

using System.Configuration;

namespace Binddatatable
{
    public partial class index : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = "Registration Sucessfully!!!"; 
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ServerConnectionString"].ConnectionString);
            connect.Open();
            var insertQuery = "insert into Server(UserName,Email,Password,Gender,City)values(@UserName,@Email,@Password,@Gender,@City)";
            SqlCommand cmd = new SqlCommand(insertQuery, connect);
            cmd.Parameters.AddWithValue("@UserName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Gender", RadioButton2.Text);
            cmd.Parameters.AddWithValue("@City", DropDownList1.SelectedItem.ToString());

            cmd.ExecuteNonQuery();
            connect.Close();

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admina.aspx");
        }
    }
}
