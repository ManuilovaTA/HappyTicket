using System;
using HappyTicket;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_FindHappyTicket
{
    [TestClass]
    public class Test_FindHappyTicket
    {
        [TestMethod]
        public void Test_SimpleWay()
        {
            int expectedResult = 28;

            FindHappyTicket actualResult = new FindHappyTicket();

            Assert.AreEqual(expectedResult, actualResult.SimpleWay(321000, 322000));
        }

        [TestMethod]
        public void Test_DifficultWay()
        {
            int expectedResult = 21;

            FindHappyTicket actualResult = new FindHappyTicket();

            Assert.AreEqual(expectedResult, actualResult.DifficultWay(321000, 322000));
        }
    }
}
