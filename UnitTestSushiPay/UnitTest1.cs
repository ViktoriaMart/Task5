using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using System.Windows.Automation;
using System.Windows.Media;
using Models;
using DAO;
using BUS;

namespace UnitTestSushiPay
{
    [TestClass]
    public class UnitTest1
    {
        OrderBUS orderBUS;
        OrderDAO orderDAO;

        public UnitTest1()
        {
            orderBUS = new OrderBUS();
            orderDAO = new OrderDAO();
        }

        [TestMethod]
        public void OrderConstructorTest1()
        {
            var order = new OrderProduct();
            Assert.IsTrue(String.Empty == order.ProductName);
        }

        [TestMethod]
        public void OrderConstructorTest2()
        {
            var order = new Requst(145, "hanabi", 2, 145.5);
            Assert.IsTrue(145 == order.ProductId && "hanabi" == order.ProductName);
        }

        [TestMethod]
        public void RemoveAllTest()
        {
            var order = new Requst(145, "hanabi", 2, 145.5);
            var order1 = new Requst(145, "sakura", 2, 145.5);
            var order2 = new Requst(145, "kotuko", 2, 145.5);
            var collection = new ObservableCollection<Requst>();
            collection.Add(order);
            collection.Add(order1);
            collection.Add(order2);

            orderBUS.RemoveAll(collection);

            int expected = 0;
            int actual = collection.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOrderTest()
        {
            var order = orderBUS.GetOrder();

            int collectionCountExpected = 1;
            int collectionCountActual = order.Count;

            Assert.AreEqual(collectionCountExpected, collectionCountActual);
        }

        [TestMethod]
        public void GetSumTest()
        {
            var collection = orderBUS.GetOrder();

            double sumExpected = 750;
            double sumActual = orderBUS.GetSum(collection);

            Assert.AreEqual(sumExpected, sumActual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetSumExceptionTest()
        {
            var order = new Requst(145, "hanabi", 2, 0);
            var order1 = new Requst(145, "sakura", 2, 0);
            var order2 = new Requst(145, "kotuko", 2, 0);
            var collection = new ObservableCollection<Requst>();

            double sumActual = orderBUS.GetSum(collection);
        }

        [TestMethod]
        public void IsTextAllowedTest_WhenDataIsCorrect()
        {
            string textData = "9565";

            bool expectedResult = true;
            bool actualResult = Rules.IsTextAllowed(textData);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsTextAllowedTest_WhenDataIsUncorrect()
        {
            string textData = "9565s";

            bool expectedResult = false;
            bool actualResult = Rules.IsTextAllowed(textData);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsCreditDataValid_WhenCreditDataIsCorrect()
        {
            string creditNumberData = "9565456695654566";
            string creditPasswordData = "0000";

            bool expectedResult = true;
            bool actualResult = Rules.IsCreditDataValid(creditNumberData, creditPasswordData);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IsCreditDataValid_WhenCreditNumberIsUncorrect()
        {
            string creditNumberWrongData = "8";
            string creditPasswordData = "0000";

            Rules.IsCreditDataValid(creditNumberWrongData, creditPasswordData);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IsCreditDataValid_WhenCreditDataIsUncorrect()
        {
            string creditNumberWrongData = "8";
            string creditPasswordWrongData = "00";

            Rules.IsCreditDataValid(creditNumberWrongData, creditPasswordWrongData);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IsCreditDataValid_WhenCreditPasswordIsUncorrect()
        {
            string creditNumberData = "9565456695654566";
            string creditPasswordWrongData = "000";

            Rules.IsCreditDataValid(creditNumberData, creditPasswordWrongData);
        }

        [TestMethod]
        public void IsInputCashDataValid_WhenInputCashDataIsCorrect()
        {
            string inputCash = "100";
            double sum = 90;

            bool expectedResult = true;
            bool actualResult = Rules.IsInputCashDataValid(inputCash, sum);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IsCreditDataValid_WhenInputCashEmpty()
        {
            string inputCash = "";
            double sum = 90;

            Rules.IsInputCashDataValid(inputCash, sum);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IsCreditDataValid_WhenInputCashEmptyLessThanSum()
        {
            string inputCash = "80";
            double sum = 90;

            Rules.IsInputCashDataValid(inputCash, sum);
        }
    }
}
