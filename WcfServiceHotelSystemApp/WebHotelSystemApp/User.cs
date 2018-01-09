using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHotelSystemApp
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

        public User(string login)
        {
            this.login = login;
        }
        public string getLogin()
        {
            return this.login;
        }
    }
}