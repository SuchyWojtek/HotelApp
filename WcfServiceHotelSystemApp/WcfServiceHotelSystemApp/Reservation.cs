using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WcfServiceHotelSystemApp
{
    public class Reservation
    {
        string userLogin;
        int roomId;
        string beginDate;
        string endDate;

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
            string query = $"insert into Reservation (userLogin, roomId, beginDate, endDate) values " +
                $"('{userLogin}',{roomId},'{beginDate}','{endDate}');";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = query;
            com.ExecuteNonQuery();
            
            conn.Close();
        }
    }
}