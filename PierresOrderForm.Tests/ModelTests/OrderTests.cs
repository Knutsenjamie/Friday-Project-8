using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresOrderForm.Models;
using System;

namespace PierresOrderForm.Tests 
{
    [TestClass]
    public class OrdersTests : IDisposable
    {
        public void Dispose()
        {
            Orders.ClearAll();
        }
        [TestMethod]
        public void OrdersConstructor_CreatesInstanceOfOrderss_Orders()
        {
            Orders newOrders = new Orders("Test", "Test", "Test", "Test");
            Assert.AreEqual(typeof(Orders), newOrders.GetType());
        }
        [TestMethod]
        public void GetOrdersTitle_ReturnsOrdersTitle_String()
        {
            string ordersTitle = "Joe's Cafe Order";
            string ordersDescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersDate = "05/14/2021"; 
            string ordersPrice = "$185.50";
            
            Orders newOrders =  new Orders(ordersTitle, ordersDescription, ordersDate, ordersPrice);
            string result = newOrders.OrdersTitle;
            Assert.AreEqual(ordersTitle, result);
        }
        [TestMethod]
        public void GetOrdersDescription_ReturnsOrdersDescription_String()
        {
            string ordersTitle = "Joe's Cafe Order";
            string ordersDescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersDate = "05/14/2021"; 
            string ordersPrice = "$185.50";
            
            Orders newOrders =  new Orders(ordersTitle, ordersDescription, ordersDate, ordersPrice);
            string result = newOrders.OrdersDescription;
            Assert.AreEqual(ordersDescription, result);
        }
        [TestMethod]
        public void GetOrdersDate_ReturnsOrdersDate_String()
        {
            string ordersTitle = "Joe's Cafe Order";
            string ordersDescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersDate = "05/14/2021"; 
            string ordersPrice = "$185.50";
            
            Orders newOrders =  new Orders(ordersTitle, ordersDescription, ordersDate, ordersPrice);
            string result = newOrders.OrdersDate;
            Assert.AreEqual(ordersDate, result);
        }
        [TestMethod]
        public void GetOrdersPrice_ReturnsOrdersPrice_String()
        {
            string ordersTitle = "Joe's Cafe Order";
            string ordersDescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersDate = "05/14/2021"; 
            string ordersPrice = "$185.50";
            
            Orders newOrders =  new Orders(ordersTitle, ordersDescription, ordersDate, ordersPrice);
            string result = newOrders.OrdersPrice;
            Assert.AreEqual(ordersPrice, result);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {

            List<Orders> newList = new List<Orders> { };
            List<Orders> result = Orders.GetAll();
            CollectionAssert.AreEqual(newList, result);
            
        } 
        [TestMethod]
        public void GetAll_ReturnsOrders_OrdersList()
        {
            string ordersTitle = "Joe's Cafe Order";
            string ordersDescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersDate = "05/14/2021"; 
            string ordersPrice = "$185.50";
            string ordersTitle2 = "Pietro's Pizzeria Order";
            string ordersDescription2 = "Pietro's Pizzeria Order Invoice For 4 cases of pizza dough (50 per case)";
            string ordersDate2 = "05/20/2021"; 
            string ordersPrice2 = "$171.95";

            Orders newOrders1 = new Orders(ordersTitle, ordersDescription, ordersDate, ordersPrice);
            Orders newOrders2 = new Orders(ordersTitle2, ordersDescription2, ordersDate2, ordersPrice2);
            List<Orders> newOrders = new List<Orders> { newOrders1, newOrders2 };
            List<Orders> result = Orders.GetAll();
            CollectionAssert.AreEqual(newOrders, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectOrders_Orders()
        {
            string ordersTitle = "Joe's Cafe Order";
            string ordersDescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersDate = "05/14/2021"; 
            string ordersPrice = "$185.50";
            string ordersTitle2 = "Pietro's Pizzeria Order";
            string ordersDescription2 = "Pietro's Pizzeria Order Invoice For 4 cases of pizza dough (50 per case)";
            string ordersDate2 = "05/20/2021"; 
            string ordersPrice2 = "$171.95";

            Orders newOrders1 = new Orders(ordersTitle, ordersDescription, ordersDate, ordersPrice);
            Orders newOrders2 = new Orders(ordersTitle2, ordersDescription2, ordersDate2, ordersPrice2);
            Orders result = Orders.Find(2);
            Assert.AreEqual(newOrders2, result);
        }
    }
}