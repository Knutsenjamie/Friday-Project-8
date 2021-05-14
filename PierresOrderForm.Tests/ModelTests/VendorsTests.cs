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

        [TestMethod]
        public void GetAll_ReturnsAllVendorsObjects_VendorsList()
        {
            string vendordescription1 = "Joe's Cafe - a small and quaint cafe serving fresh coffee and french pastries";
            string vendorsname1 = "Joe's Cafe";
            string vendordescription2 = "Pietro's Pizzeria - local american/italian pizzeria serving hand-tossed pies daily";
            string vendorsname2 = "Pietro's Pizzeria";
            Vendors newVendors1 = new Vendors(vendordescription1, vendorsname1);
            Vendors newVendors2 = new Vendors(vendordescription2, vendorsname2);
            List<Vendors> newList = new List<Vendors> { newVendors1, newVendors2 };
            List<Vendors> result = Vendors.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

    }
}