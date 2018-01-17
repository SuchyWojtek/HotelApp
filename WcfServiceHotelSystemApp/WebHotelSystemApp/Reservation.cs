using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHotelSystemApp
{
    public class Reservation
    {
        string _userLogin;
        int _roomId;
        string _beginDate;
        string _endDate;

        public Reservation(string userLogin, int roomId, string beginDate, string endDate)
        {
            _beginDate = beginDate;
            _endDate = endDate;
            _roomId = roomId;
            _userLogin = userLogin;
        }
    }
}