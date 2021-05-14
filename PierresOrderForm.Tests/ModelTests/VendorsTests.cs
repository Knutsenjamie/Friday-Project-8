using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderForm.Models;

namespace PierresOrderForm.Tests 
{
    [TestClass]
    public class VendorsTests
    {
        [TestMethod]
        public void VendorsConstructor_CreatesInstanceOfVendors_Vendors()
        {
            Vendors newVendors = new Vendors();
            Assert.AreEqual(typeof(Vendors), newVendors.GetType());
        }
    }
}