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
            Vendors newVendors = new Vendors("Test Vendor", "Test Description");
            Assert.AreEqual(typeof(Vendors), newVendors.GetType());
        }
        [TestMethod]
        public void GetVendorsName_ReturnsVendorsName_String()
        {
            string vendorsname = "Joe's Ingredient Warehouse";
            string vendordescription = "Test";
            
            Vendors newVendors =  new Vendors(vendorsname, vendordescription);
            string result = newVendors.VendorsName;
            Assert.AreEqual(vendorsname, result);
        }
        [TestMethod]
        public void GetVendorsDescription_ReturnsVendorsDescription_String()
        {
            string vendordescription = "The #1 place for your wholesale baking needs!";
            string vendorsname = "Joe's Ingredient Warehouse";
            Vendors newVendors =  new Vendors(vendordescription, vendorsname);
            string result = newVendors.VendorDescription;
            Assert.AreEqual(vendorsname, result);
        }
    }
}