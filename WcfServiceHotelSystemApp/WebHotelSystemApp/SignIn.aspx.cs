using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHotelSystemApp
{
    public partial class SignIn : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // search room
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        // history of reservation
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HistoryOfReservation.aspx");
        }
    }
}