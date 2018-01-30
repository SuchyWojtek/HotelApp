using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHotelSystemApp
{
    public partial class HistoryOfReservation : System.Web.UI.Page
    {
        string[][] arr = new string[3][];
        string activeUsr;

        public string[][] returnRes()
        {
            activeUsr = getUsr();
            string[][] arrRes = new string[3][];
            arrRes[0] = new string[50];
            arrRes[1] = new string[50];
            arrRes[2] = new string[50];

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            arrRes = client.getReservations(activeUsr);

            return arrRes;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            arr[0] = new string[50];
            arr[1] = new string[50];
            arr[2] = new string[50];
            arr = returnRes();
        }

        string getUsr()
        {
            string log;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            log = client.getActiveLogin();
            client.Close();
            return log;
        }

        public string ids()
        {
            string id = "";

            for (int i = 0; i < 50; i++)
            {
                id += arr[0][i] + "</br>";
            }
            return id;
        }
        public string begin()
        {
            string b = "";

            for (int i = 0; i < 50; i++)
            {
                b += arr[1][i] + "</br>";
            }
            return b;
        }
        public string end()
        {
            string e = "";

            for (int i = 0; i < 50; i++)
            {
                e += arr[2][i] + "</br>";
            }
            return e;
        }

    }
}