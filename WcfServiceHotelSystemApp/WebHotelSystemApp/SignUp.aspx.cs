using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHotelSystemApp
{
    public partial class SignUp : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string s (TextBox t) // textbox do stringa, zeby bylo krocej
        {
            return t.Text.ToString();
        }

        protected void btnConfirmData_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
             client.addUser(s(txbLog), s(txbPass), s(txbName), s(txbSurname), s(txbDate),
             s(txbMale), s(txbPostCode), s(txbAddress));
            client.Close();
        }
    }
}