using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5

{
    public partial class cookiesin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //creating cookie
            //creating http cookie instance by specifying name
            HttpCookie cookie = new HttpCookie("student");
            HttpCookie cookie1 = new HttpCookie("Employee");
            HttpCookie cookie2 = new HttpCookie("salary");
            HttpCookie cookie3 = new HttpCookie("Profession");
            HttpCookie cookie4 = new HttpCookie("Place");
            HttpCookie http = new HttpCookie("Cookie");

            //Assign value to the created coookie
            cookie.Value = "Park";
            cookie1.Value = "Jimin";
            cookie2.Value = "80,000";
            cookie3.Value = "Artist";
            cookie4.Value = "Seoul";
            http.Value = "This is cookies";
            //add cookie to the response Instance
            Response.Cookies.Add(cookie);
            Response.Cookies.Add(cookie1);
            Response.Cookies.Add(cookie2);
            Response.Cookies.Add(cookie3);
            Response.Cookies.Add(cookie4);
            Response.Cookies.Add(http);
            //Fetch the cookie created
            var cookie_Value = Response.Cookies["student"].Value;
            Label1.Text = cookie_Value;
            var cookie1_Value = Response.Cookies["Employee"].Value;
            Label2.Text = cookie1_Value;
            var cookie2_Value = Response.Cookies["salary"].Value;
            Label3.Text = cookie2_Value;
            var cookie3_Value = Response.Cookies["Profession"].Value;
            Label4.Text = cookie3_Value;
            var cookie4_Value = Response.Cookies["Place"].Value;
            Label4.Text = cookie4_Value;
            var http_Value = Response.Cookies["Cookie"].Value;
            Label5.Text = http_Value;
        }
    }
}
