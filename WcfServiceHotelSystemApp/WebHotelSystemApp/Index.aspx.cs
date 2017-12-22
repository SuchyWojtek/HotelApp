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
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
             TextBox1.Text = client.hello();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}