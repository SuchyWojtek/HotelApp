using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WcfServiceHotelSystemApp
{
    public class Room
    {
        private int roomId
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
        private int personNum
        {
            get
            {
                return this.personNum;
            }
            set
            {
                this.personNum = value;
            }
        }
        private int floor
        {
            get
            {
                return this.floor;
            }
            set
            {
                this.floor = value;
            }
        }
        private double price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        private bool vacancy
        {
            get
            {
                return this.vacancy;
            }
            set
            {
                this.vacancy = value;
            }
        }

        // konstruktor pokoju, po tym zapsujemy do bazy danych
        public Room(int roomId, int personNum, int floor, double price, bool vacancy)
        {
            this.roomId = roomId;
            this.personNum = personNum;
            this.floor = floor;
            this.price = price;
            this.vacancy = vacancy;

            saveRoomToDb();
        }

        // zapis do db
        void saveRoomToDb()
        {
            string connectionString = @"";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "insert into room set (roomid, personnum, floor, price, empty" +
                "values (" + roomId + "," + personNum + "," + floor + ","
                + price + "," + vacancy + ")";
            SqlCommand com = new SqlCommand(query);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}