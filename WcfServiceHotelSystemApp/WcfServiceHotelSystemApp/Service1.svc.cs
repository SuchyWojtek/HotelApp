using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WcfServiceHotelSystemApp
{
    public class Service1 : IService1
    {
        public string DoWork() // test
        {
            return "";
        }
        public string hello() // test
        {
            return "hello world";
        }
        //tworzy obiekt user, potem konstruktor dodaje usera do db
        public void addUser(string login, string password, string firstName, string surname, string dateOfBirth,
            string male, string postCode, string address)
        {
            User u = new User(login, password, firstName, surname, dateOfBirth,
                male, postCode, address);
        }
        //tworzy obiekt reservation, a potem dodaje dane do bazy danych
        public void addReservation(string userLogin, int roomId, string beginDate, string endDate)
        {
            Reservation r = new Reservation(userLogin, roomId, beginDate, endDate);
        }
        //tworzy obiekt room, a potem tak jak dwa powyzsze
        public void addRoom(int roomId, int personNum, int floor, double price, bool vacancy)
        {
            Room r = new Room(roomId, personNum, floor, price, vacancy);
        }
        //weryfikacja logowania
        public bool verifyLogin(string log, string pass)
        {
            string query = $"select login from userr where login='{log}' and password='{pass}'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = query;
            SqlDataReader reader = com.ExecuteReader();

            string value = null;
            if(reader.Read())
            {
                value = reader.GetString(0);
            }

            reader.Close();

            query = $"update activelogin set active = '{log}' where id = 1";

            if (value!=null)
            {
                com.CommandText = query;
                com.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }

            conn.Close();
        }

        // zwroc id pokoi
        public int[][] getEmptyRooms()
        {
            int[][] arrRooms = new int[5][];
            arrRooms[0] = new int[200];
            arrRooms[1] = new int[200];
            arrRooms[2] = new int[200];
            arrRooms[3] = new int[200];
            arrRooms[4] = new int[200];

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "select * from room";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader reader = command.ExecuteReader();

            int i = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    arrRooms[0][i] = (int)reader[0];
                    arrRooms[1][i] = (int)reader[1];
                    arrRooms[2][i] = (int)reader[2];
                    arrRooms[3][i] = (int)reader[3];
                    arrRooms[4][i] = (int)reader[4];
                    i += 1;
                }
            }

            reader.Close();
            conn.Close();

            return arrRooms;
        }
        
        // pobiera login ktory jest zalogowany
        public string getActiveLogin()
        {
            string value = "";
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "select * from activelogin";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    value = (string)reader[0];

                }
            }

            reader.Close();
            conn.Close();

            return value;
        }

        // zwraca rezerwacje goscia
        public string[][] getReservations(string log)
        {
            string[][] arrRes = new string[3][];
            arrRes[0] = new string[50];
            arrRes[1] = new string[50];
            arrRes[2] = new string[50];

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            string query = $"select * from rezerwacje where login = '{log}'";

            SqlConnection conn = new SqlConnection(conString);
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

            SqlDataReader reader = command.ExecuteReader();

            int i = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    arrRes[0][i] = ((int)reader[1]).ToString();
                    arrRes[1][i] = (string)reader[2];
                    arrRes[2][i] = (string)reader[3];
                    i += 1;
                }
            }

            while(i<50)
            {
                arrRes[0][i] = "";
                arrRes[1][i] = "";
                arrRes[2][i] = "";
                i += 1;
            }

            reader.Close();
            conn.Close();

            return arrRes;
        }
    }
}
