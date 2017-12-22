using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WcfServiceHotelSystemApp
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

        // konstruktor, potem save do db
        public Reservation(string userLogin, int roomId, string beginDate, string endDate)
        {
            this.beginDate = beginDate;
            this.endDate = endDate;
            this.roomId = roomId;
            this.userLogin = userLogin;

            saveResToDb();
        }

        // zapis rezerwacji do bazy
        void saveResToDb()
        {
            string connectionString = @"";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "insert into reservation set (userlogin, roomid, begindate, enddate" +
                " values (" + userLogin + "," + roomId + "," + beginDate + ","
                + endDate + ")";
            SqlCommand com = new SqlCommand(query);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}