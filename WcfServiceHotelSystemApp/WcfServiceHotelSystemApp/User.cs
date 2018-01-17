using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WcfServiceHotelSystemApp
{
    public class User
    {
        string _login;
        string _password;
        string _firstName;
        string _surname;
        string _dateOfBirth;
        string _male;
        string _postCode;
        string _address;

        // zapisuje usera do bazy danych
        void saveUsrToDb()
        {
            string query = $"insert into Userr (login, password, firstName, surname, dateOfBirth,male, postCode, address) values" +
                $" ('{_login}','{_password}','{_firstName}','{_surname}','{_dateOfBirth}','{_male}','{_postCode}','{_address}')";

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
            _login = login;
            _password = password;
            _firstName = firstName;
            _surname = surname;
            _dateOfBirth = dateOfBirth;
            _male = male;
            _postCode = postCode;
            _address = address;

            saveUsrToDb();
        }

    }
}