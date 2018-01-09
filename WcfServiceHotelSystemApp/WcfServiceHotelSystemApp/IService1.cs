using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceHotelSystemApp
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string DoWork();
        [OperationContract]
        string hello();
        [OperationContract]
        void addUser(string login, string password, string firstName, string surname, string dateOfBirth,
            string male, string postCode, string address);
        [OperationContract]
        void addReservation(string userLogin, int roomId, string beginDate, string endDate);
        [OperationContract]
        void addRoom(int roomId, int personNum, int floor, double price, bool vacancy);
        [OperationContract]
        bool verifyLogin(string login, string password);
        [OperationContract]
        int[][] getEmptyRooms();
        [OperationContract]
        string getActiveLogin();
        [OperationContract]
        string[][] getReservations(string log);
    }
}
