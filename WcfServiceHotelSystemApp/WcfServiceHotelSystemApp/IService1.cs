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
    }
}
