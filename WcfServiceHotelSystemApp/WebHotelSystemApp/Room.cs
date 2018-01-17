using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHotelSystemApp
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
        }
    }
}