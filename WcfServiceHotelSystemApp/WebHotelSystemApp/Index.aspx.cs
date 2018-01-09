using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfServiceHotelSystemApp;

namespace WebHotelSystemApp
{
    public partial class Index : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // button sign up
        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        // button sign in 
        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            // metoda verify login do zrobienia(wiadmo co robi)
            if (client.verifyLogin(TextBox1.Text.ToString(),TextBox2.Text.ToString())==true)
            { 
                Response.Redirect(@"C:\Users\Wojtek\Desktop\HotelApp\WcfServiceHotelSystemApp\WebHotelSystemApp\SignIn.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Błędny login lub hasło')</script>");
            }

            client.Close();
        }
    }
}