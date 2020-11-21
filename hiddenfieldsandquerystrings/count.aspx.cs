using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace statemanagemetdemoonweb
{
    public partial class count : System.Web.UI.Page
    {
         
         int Count;//Global Declaration
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //logic to demonstrate for count on button click
            Count = int.Parse(hfCount1.Value);
            Count += 1;
            Response.Write(" no.of hit counts are:" + Count);
            hfCount1.Value = Count.ToString();
        }
    }
}
