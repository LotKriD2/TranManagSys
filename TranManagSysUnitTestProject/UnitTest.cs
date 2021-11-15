using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TranManagSysLibrary;

namespace TranManagSysUnitTestProject
{
    [TestClass()]
    public class UnitTest
    {
        [TestMethod()]
        public void AddEntryTest()
        {
            string login = "Admin";
            string password = "admin";
            string city = "Тверь";
            User.Athorization(login, password, city);
            Assert.AreEqual(User.AuthorizationSuccessful, true);
            try
            {
                string nameTable = "Города";
                string condition = "( Код_города  , Название_города )";
                string values = "( 100, 'TestCity' )";
                condition = condition + " values " + values;
                DBConnection.AddEntry(nameTable, condition);
                Assert.AreEqual(0, 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        [TestMethod()]
        public void UpdateEntryTest()
        {
            string login = "Admin";
            string password = "admin";
            string city = "Тверь";
            User.Athorization(login, password, city);
            Assert.AreEqual(User.AuthorizationSuccessful, true);
            try
            {
                string nameTable = "Города";
                string condition = "Название_города = 'UpdatedTestCity'";
                condition = "set " + condition + " where Код_города = 2";
                DBConnection.UpdateEntry(nameTable, condition);
                Assert.AreEqual(0, 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        [TestMethod()]
        public void DeleteEntryTest()
        {
            string login = "Admin";
            string password = "admin";
            string city = "Тверь";
            User.Athorization(login, password, city);
            Assert.AreEqual(User.AuthorizationSuccessful, true);
            try
            {
                string nameTable = "Города";
                string condition = "Код_города = 3";
                DBConnection.DeleteEntry(nameTable, condition);
                Assert.AreEqual(0, 0);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
