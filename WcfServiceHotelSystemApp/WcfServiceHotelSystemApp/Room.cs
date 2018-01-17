using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WcfServiceHotelSystemApp
{
    public class Room
    {
        private int _roomId;
        private int _personNum;
        private int _floor;
        private double _price;
        private bool _vacancy;

        // konstruktor pokoju, po tym zapsujemy do bazy danych
        public Room(int roomId, int personNum, int floor, double price, bool vacancy)
        {
            _roomId = roomId;
            _personNum = personNum;
            _floor = floor;
            _price = price;
            _vacancy = vacancy;

            saveRoomToDb();
        }

        // zapis do db
        void saveRoomToDb()
        {
            string query = "insert into room set (roomid, personnum, floor, price, empty" +
                $"values ('{_roomId}','{_personNum}','{_floor}','{_price}','{_vacancy}')";

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