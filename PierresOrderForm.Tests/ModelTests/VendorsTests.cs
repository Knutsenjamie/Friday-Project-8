using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresOrderForm.Models;
using System;

namespace PierresOrderForm.Tests 
{
    [TestClass]
    public class VendorsTests : IDisposable
    {
        public void Dispose()
        {
            Vendors.ClearAll();
        }
        
        [TestMethod]
        public void VendorsConstructor_CreatesInstanceOfVendors_Vendors()
        {
            Vendors newVendors = new Vendors("Test Vendor", "Test Description");
            Assert.AreEqual(typeof(Vendors), newVendors.GetType());
        }
        
        [TestMethod]
        public void GetVendorsName_ReturnsVendorsName_String()
        {
            string vendorsname = "Joe's Cafe";
            string vendordescription = "Test";
            
            Vendors newVendors =  new Vendors(vendorsname, vendordescription);
            string result = newVendors.VendorsName;
            Assert.AreEqual(vendorsname, result);
        }
        
        [TestMethod]
        public void GetVendorsDescription_ReturnsVendorsDescription_String()
        {
            string vendordescription = "Joe's Cafe - a small and quaint cafe serving fresh coffee and french pastries";
            string vendorsname = "Joe's Cafe";
            Vendors newVendors =  new Vendors(vendordescription, vendorsname);
            string result = newVendors.VendorDescription;
            Assert.AreEqual(vendorsname, result);
        }
        
        [TestMethod]
        public void GetId_ReturnsVendorsId_Int()
        {
            string vendordescription = "Joe's Cafe - a small and quaint cafe serving fresh coffee and french pastries";
            string vendorsname = "Joe's Cafe";
            Vendors newVendors = new Vendors(vendordescription, vendorsname);
            int result = newVendors.Id;
            Assert.AreEqual(1, result);
        }

    }
}