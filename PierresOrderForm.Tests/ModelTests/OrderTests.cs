using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderForm.Models;

namespace PierresOrderForm.Tests 
{
    [TestClass]
    public class OrdersTests
    {
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
    }
}