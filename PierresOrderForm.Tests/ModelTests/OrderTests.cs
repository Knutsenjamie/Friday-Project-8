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
            string orderstitle = "Joe's Cafe Order";
            string ordersdescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersdate = "05/14/2021"; 
            string ordersprice = "$185.50";
            
            Orders newOrders =  new Orders(orderstitle, ordersdescription, ordersdate, ordersprice);
            string result = newOrders.OrdersTitle;
            Assert.AreEqual(orderstitle, result);
        }
        [TestMethod]
        public void GetOrdersDescription_ReturnsOrdersDescription_String()
        {
            string orderstitle = "Joe's Cafe Order";
            string ordersdescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersdate = "05/14/2021"; 
            string ordersprice = "$185.50";
            
            Orders newOrders =  new Orders(orderstitle, ordersdescription, ordersdate, ordersprice);
            string result = newOrders.OrdersDescription;
            Assert.AreEqual(ordersdescription, result);
        }
        [TestMethod]
        public void GetOrdersDate_ReturnsOrdersDate_String()
        {
            string orderstitle = "Joe's Cafe Order";
            string ordersdescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersdate = "05/14/2021"; 
            string ordersprice = "$185.50";
            
            Orders newOrders =  new Orders(orderstitle, ordersdescription, ordersdate, ordersprice);
            string result = newOrders.OrdersDate;
            Assert.AreEqual(ordersdate, result);
        }
        [TestMethod]
        public void GetOrdersPrice_ReturnsOrdersPrice_String()
        {
            string orderstitle = "Joe's Cafe Order";
            string ordersdescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersdate = "05/14/2021"; 
            string ordersprice = "$185.50";
            
            Orders newOrders =  new Orders(orderstitle, ordersdescription, ordersdate, ordersprice);
            string result = newOrders.OrdersPrice;
            Assert.AreEqual(ordersprice, result);
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
            string orderstitle = "Joe's Cafe Order";
            string ordersdescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersdate = "05/14/2021"; 
            string ordersprice = "$185.50";
            string orderstitle2 = "Pietro's Pizzeria Order";
            string ordersdescription2 = "Pietro's Pizzeria Order Invoice For 4 cases of pizza dough (50 per case)";
            string ordersdate2 = "05/20/2021"; 
            string ordersprice2 = "$171.95";

            Orders newOrders1 = new Orders(orderstitle, ordersdescription, ordersdate, ordersprice);
            Orders newOrders2 = new Orders(orderstitle2, ordersdescription2, ordersdate2, ordersprice2);
            List<Orders> newOrders = new List<Orders> { newOrders1, newOrders2 };
            List<Orders> result = Orders.GetAll();
            CollectionAssert.AreEqual(newOrders, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectOrders_Orders()
        {
            string orderstitle = "Joe's Cafe Order";
            string ordersdescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersdate = "05/14/2021"; 
            string ordersprice = "$185.50";
            string orderstitle2 = "Pietro's Pizzeria Order";
            string ordersdescription2 = "Pietro's Pizzeria Order Invoice For 4 cases of pizza dough (50 per case)";
            string ordersdate2 = "05/20/2021"; 
            string ordersprice2 = "$171.95";

            Orders newOrders1 = new Orders(orderstitle, ordersdescription, ordersdate, ordersprice);
            Orders newOrders2 = new Orders(orderstitle2, ordersdescription2, ordersdate2, ordersprice2);
            Orders result = Orders.Find(2);
            Assert.AreEqual(newOrders2, result);
        }
    }
}