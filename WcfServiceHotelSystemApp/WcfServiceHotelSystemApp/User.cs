using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WcfServiceHotelSystemApp
{
    public class User
    {
        string login;
        string password;
        string firstName;
        string surname;
        string dateOfBirth;
        string male;
        string postCode;
        string address;

        // zapisuje usera do bazy danych
        void saveUsrToDb()
        {
            string query = $"insert into Userr (login, password, firstName, surname, dateOfBirth,male, postCode, address) values" +
                $" ('{login}','{password}','{firstName}','{surname}','{dateOfBirth}','{male}','{postCode}','{address}')";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = query;
            com.ExecuteNonQuery();

            conn.Close();
        }

        // konstruktor
        public User(string login, string password, string firstName, string surname, string dateOfBirth,
            string male, string postCode, string address)
        {
            this.login = login;
            this.password = password;
            this.firstName = firstName;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.male = male;
            this.postCode = postCode;
            this.address = address;

            saveUsrToDb();
        }

    }
}