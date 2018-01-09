﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebHotelSystemApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoWork", ReplyAction="http://tempuri.org/IService1/DoWorkResponse")]
        string DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoWork", ReplyAction="http://tempuri.org/IService1/DoWorkResponse")]
        System.Threading.Tasks.Task<string> DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/hello", ReplyAction="http://tempuri.org/IService1/helloResponse")]
        string hello();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/hello", ReplyAction="http://tempuri.org/IService1/helloResponse")]
        System.Threading.Tasks.Task<string> helloAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        void addUser(string login, string password, string firstName, string surname, string dateOfBirth, string male, string postCode, string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        System.Threading.Tasks.Task addUserAsync(string login, string password, string firstName, string surname, string dateOfBirth, string male, string postCode, string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addReservation", ReplyAction="http://tempuri.org/IService1/addReservationResponse")]
        void addReservation(string userLogin, int roomId, string beginDate, string endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addReservation", ReplyAction="http://tempuri.org/IService1/addReservationResponse")]
        System.Threading.Tasks.Task addReservationAsync(string userLogin, int roomId, string beginDate, string endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addRoom", ReplyAction="http://tempuri.org/IService1/addRoomResponse")]
        void addRoom(int roomId, int personNum, int floor, double price, bool vacancy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addRoom", ReplyAction="http://tempuri.org/IService1/addRoomResponse")]
        System.Threading.Tasks.Task addRoomAsync(int roomId, int personNum, int floor, double price, bool vacancy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/verifyLogin", ReplyAction="http://tempuri.org/IService1/verifyLoginResponse")]
        bool verifyLogin(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/verifyLogin", ReplyAction="http://tempuri.org/IService1/verifyLoginResponse")]
        System.Threading.Tasks.Task<bool> verifyLoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getEmptyRooms", ReplyAction="http://tempuri.org/IService1/getEmptyRoomsResponse")]
        int[][] getEmptyRooms();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getEmptyRooms", ReplyAction="http://tempuri.org/IService1/getEmptyRoomsResponse")]
        System.Threading.Tasks.Task<int[][]> getEmptyRoomsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebHotelSystemApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebHotelSystemApp.ServiceReference1.IService1>, WebHotelSystemApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DoWork() {
            return base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task<string> DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string hello() {
            return base.Channel.hello();
        }
        
        public System.Threading.Tasks.Task<string> helloAsync() {
            return base.Channel.helloAsync();
        }
        
        public void addUser(string login, string password, string firstName, string surname, string dateOfBirth, string male, string postCode, string address) {
            base.Channel.addUser(login, password, firstName, surname, dateOfBirth, male, postCode, address);
        }
        
        public System.Threading.Tasks.Task addUserAsync(string login, string password, string firstName, string surname, string dateOfBirth, string male, string postCode, string address) {
            return base.Channel.addUserAsync(login, password, firstName, surname, dateOfBirth, male, postCode, address);
        }
        
        public void addReservation(string userLogin, int roomId, string beginDate, string endDate) {
            base.Channel.addReservation(userLogin, roomId, beginDate, endDate);
        }
        
        public System.Threading.Tasks.Task addReservationAsync(string userLogin, int roomId, string beginDate, string endDate) {
            return base.Channel.addReservationAsync(userLogin, roomId, beginDate, endDate);
        }
        
        public void addRoom(int roomId, int personNum, int floor, double price, bool vacancy) {
            base.Channel.addRoom(roomId, personNum, floor, price, vacancy);
        }
        
        public System.Threading.Tasks.Task addRoomAsync(int roomId, int personNum, int floor, double price, bool vacancy) {
            return base.Channel.addRoomAsync(roomId, personNum, floor, price, vacancy);
        }
        
        public bool verifyLogin(string login, string password) {
            return base.Channel.verifyLogin(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> verifyLoginAsync(string login, string password) {
            return base.Channel.verifyLoginAsync(login, password);
        }
        
        public int[][] getEmptyRooms() {
            return base.Channel.getEmptyRooms();
        }
        
        public System.Threading.Tasks.Task<int[][]> getEmptyRoomsAsync() {
            return base.Channel.getEmptyRoomsAsync();
        }
    }
}
