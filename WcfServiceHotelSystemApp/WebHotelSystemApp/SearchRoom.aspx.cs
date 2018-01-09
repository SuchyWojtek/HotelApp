using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebHotelSystemApp
{
    public partial class SearchRoom : System.Web.UI.Page
    {
        int index;
        int[][] arr = new int[5][];

        public int[][] returnIndex()
        {
            int[][] arrRooms = new int[5][];
            arrRooms[0] = new int[200];
            arrRooms[1] = new int[200];
            arrRooms[2] = new int[200];
            arrRooms[3] = new int[200];
            arrRooms[4] = new int[200];

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            arrRooms = client.getEmptyRooms();

            return arrRooms;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            index = -1;
            arr[0] = new int[200];
            arr[1] = new int[200];
            arr[2] = new int[200];
            arr[3] = new int[200];
            arr[4] = new int[200];
            arr = returnIndex();
        }

        public int returnId()
        {
            index += 1;
            return arr[0][index];
        }
        public int returnFloor()
        {
            return arr[2][index];
        }
        public int returnPrice()
        {
            return arr[3][index];
        }
        public int returnPersonNum()
        {
            return arr[1][index];
        }
        public string returnSatus()
        {
            string status;
            if (arr[4][index] == 1)
                status = "wolny";
            else
                status = "zajety";
            return status;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            if(arr[4][int.Parse(DropDownList1.Text.ToString())-1]==1)
            {
                client.addReservation(TextBox1.Text.ToString(), int.Parse(DropDownList1.Text.ToString()),
                Calendar2.Text.ToString(), Calendar1.Text.ToString());
                Response.Redirect(@"http://localhost:34097/SearchRoom.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Ten pokój jest zajęty')</script>");
            }
        }
    }
}