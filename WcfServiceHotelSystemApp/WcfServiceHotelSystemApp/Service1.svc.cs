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
    }
}
