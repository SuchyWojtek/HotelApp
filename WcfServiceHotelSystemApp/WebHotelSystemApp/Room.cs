using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHotelSystemApp
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
    }
}