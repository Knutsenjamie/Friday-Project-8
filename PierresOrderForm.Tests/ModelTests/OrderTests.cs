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
            Orders newOrders = new Orders();
            Assert.AreEqual(typeof(Orders), newOrders.GetType());
        }
    }
}