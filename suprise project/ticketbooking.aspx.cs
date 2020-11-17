using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Surprise_pro
{
    public partial class TicketBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("Choose the Flight,Happy Day!!!!!!!!!!!!!!!!!!!");
            //Establish the connection to the database
            using (SqlConnection Connect = new SqlConnection("data Source=.; database=Asp.Net; integrated security=SSPI"))
            {

                SqlDataAdapter SD = new SqlDataAdapter("select * from Flight", Connect);//To retrive the data from database
                DataSet ds = new DataSet();//to convert the data into the grid.
                SD.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string gender = " ";
            if (RadioButton1.Checked)
                gender = RadioButton1.Text;
            else
               gender = RadioButton2.Text;

            string Tic = "Your Ticket has been generated:"+"<br/>" + "Passenger Name: " + TextBox1.Text + "<br/>" +
                "Age: " + TextBox2.Text + "<br/>" + "Gender:" + gender + "<br/>" + "FlightID:" + TextBox3.Text + "<br/>" + "Flight Number:" + TextBox4.Text + "<br/>"+
                "Flight Name:" + TextBox5.Text + "<br/>" + "Source:" + TextBox6.Text+ "<br/>" + "Destination:" + TextBox7.Text;
            Label1.Text = Tic;
        }
    }
}