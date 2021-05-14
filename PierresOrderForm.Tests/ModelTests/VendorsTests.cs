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
        [TestMethod]
        public void GetVendorsName_ReturnsVendorsName_String()
        {
            string vendorsname = "Joe's Ingredient Warehouse";
            Vendors newVendors =  new Vendors(vendorsname);
            string result = newVendors.VendorsName;
            Assert.AreEqual(vendorsname, result);
        }
    }
}