using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCalendarSystem_Tier1.Data
{
    [TestClass]
    public class OnlineCalendarServiceTests
    {
        OnlineCalendarService service = new OnlineCalendarService();

        [TestMethod]
        public void test_login()
        {
            Console.WriteLine(service.login("fogo", "guess"));
        }

        [TestMethod]
        public void test_createUser()
        {
            Console.WriteLine(service.createUser("fogo", "guess"));
        }

        [TestMethod]
        public void test_updateUser()
        {
            Console.WriteLine(OnlineCalendarService.updateUser("Bernardo", "Cool", 2));
        }

        [TestMethod]
        public void test_deleteUser()
        {
            Console.WriteLine(OnlineCalendarService.deleteUser(2));
        }
    }
}
