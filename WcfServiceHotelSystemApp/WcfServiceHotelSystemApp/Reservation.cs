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
        string _userLogin;
        int _roomId;
        string _beginDate;
        string _endDate;

        // konstruktor, potem save do db
        public Reservation(string userLogin, int roomId, string beginDate, string endDate)
        {
            _beginDate = beginDate;
            _endDate = endDate;
            _roomId = roomId;
            _userLogin = userLogin;

            saveResToDb();
            changeStatus(roomId);
        }

        // zapis rezerwacji do bazy
        void saveResToDb()
        { 
            string query = $"insert into rezerwacje (login, idpokoju, poczatek, koniec) values " +
                $"('{_userLogin}',{_roomId},'{_beginDate}','{_endDate}');";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = query;
            com.ExecuteNonQuery();
            
            conn.Close();
        }
        // update statusu pokoju
        void changeStatus(int id)
        {
            string query = $"update room set empty=0 where roomid={id}";

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