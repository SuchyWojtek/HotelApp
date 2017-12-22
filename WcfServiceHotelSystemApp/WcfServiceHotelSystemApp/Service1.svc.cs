using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

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
    }
}
