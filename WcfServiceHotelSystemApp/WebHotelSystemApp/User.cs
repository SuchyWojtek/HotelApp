using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHotelSystemApp
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
        }
    }
}