using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHotelSystemApp
{
    public class Reservation
    {
        string userLogin
        {
            get
            {
                return this.userLogin;
            }
            set
            {
                this.userLogin = value;
            }
        }
        int roomId
        {
            get
            {
                return this.roomId;
            }
            set
            {
                this.roomId = value;
            }
        }
        string beginDate
        {
            get
            {
                return this.beginDate;
            }
            set
            {
                this.beginDate = value;
            }
        }
        string endDate
        {
            get
            {
                return this.endDate;
            }
            set
            {
                this.endDate = value;
            }
        }

        Reservation()
        {

        }
    }
}