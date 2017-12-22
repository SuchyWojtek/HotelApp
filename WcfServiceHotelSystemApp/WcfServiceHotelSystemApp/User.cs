using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WcfServiceHotelSystemApp
{
    public class User
    {
        string login
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }
        string password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        string firstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        string surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                this.surname = value;
            }
        }
        string dateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                this.dateOfBirth = value;
            }
        }
        string male
        {
            get
            {
                return this.male;
            }
            set
            {
                this.male = value;
            }
        }
        string postCode
        {
            get
            {
                return this.postCode;
            }
            set
            {
                this.postCode = value;
            }
        }
        string address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
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

        // zapisuje usera do bazy danych
        void saveUsrToDb()
        {
            string connectionString = @"";
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "insert into user set (login, password, firstName, surname, dateOfBirth," +
                "male, postCode, address) values (" + login + "," + password + "," + firstName + ","
                + surname + "," + dateOfBirth + "," + male + "," + postCode + "," + address + ")";
            SqlCommand com = new SqlCommand(query);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }

    }
}