using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebHotelSystemApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // test poprawnosci logowania
        // tylko poprawny login
        [TestMethod]
        public void TestVerfyLoginWithProperLoginOnly()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            client.Open();
            bool result = client.verifyLogin("admin", "BadPassword");
            client.Close();

            Assert.IsFalse(result);
        }

        // tylko poprawne haslo
        [TestMethod]
        public void TestVerfyLoginWithProperPassOnly()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            client.Open();
            bool result = client.verifyLogin("BadLogin", "admin");
            client.Close();

            Assert.IsFalse(result);
        }

        // poprawne logowanie
        [TestMethod]
        public void TestVerfyLoginWithProperData()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            client.Open();
            bool result = client.verifyLogin("admin", "admin");
            client.Close();

            Assert.IsTrue(result);
        }

        // sprawdzam konstrutktory
        [TestMethod]
        public void TestReservation()
        {
            Reservation r = new Reservation("admin", 1, "2018-02-02", "2018-02-03");

            Assert.IsNotNull(r);
        }

        [TestMethod]
        public void TestRoom()
        {
            Room r = new Room(1, 2, 3, 200.50, true);

            Assert.IsNotNull(r);
        }

        [TestMethod]
        public void TestUser()
        {
            User u = new User("login", "password", "firstName", "surname", "1901-01-01",
                "M", "99-999", "address");

            Assert.IsNotNull(u);
        }
    }
}
