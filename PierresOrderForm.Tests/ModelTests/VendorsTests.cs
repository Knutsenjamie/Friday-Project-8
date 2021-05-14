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
            string vendorsName = "Joe's Cafe";
            string vendorDescription = "Test";
            
            Vendors newVendors =  new Vendors(vendorsName, vendorDescription);
            string result = newVendors.VendorsName;
            Assert.AreEqual(vendorsName, result);
        }
        
        [TestMethod]
        public void GetVendorsDescription_ReturnsVendorsDescription_String()
        {
            string vendorDescription = "Joe's Cafe - a small and quaint cafe serving fresh coffee and french pastries";
            string vendorsName = "Joe's Cafe";
            Vendors newVendors =  new Vendors(vendorDescription, vendorsName);
            string result = newVendors.VendorDescription;
            Assert.AreEqual(vendorsName, result);
        }
        
        [TestMethod]
        public void GetId_ReturnsVendorsId_Int()
        {
            string vendorDescription = "Joe's Cafe - a small and quaint cafe serving fresh coffee and french pastries";
            string vendorsName = "Joe's Cafe";
            Vendors newVendors = new Vendors(vendorDescription, vendorsName);
            int result = newVendors.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorsObjects_VendorsList()
        {
            string vendorDescription1 = "Joe's Cafe - a small and quaint cafe serving fresh coffee and french pastries";
            string vendorsName1 = "Joe's Cafe";
            string vendorDescription2 = "Pietro's Pizzeria - local american/italian pizzeria serving hand-tossed pies daily";
            string vendorsName2 = "Pietro's Pizzeria";
            Vendors newVendors1 = new Vendors(vendorDescription1, vendorsName1);
            Vendors newVendors2 = new Vendors(vendorDescription2, vendorsName2);
            List<Vendors> newList = new List<Vendors> { newVendors1, newVendors2 };
            List<Vendors> result = Vendors.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectVendors_Vendors()
        {
            string vendorDescription1 = "Joe's Cafe - a small and quaint cafe serving fresh coffee and french pastries";
            string vendorsName1 = "Joe's Cafe";
            string vendorDescription2 = "Pietro's Pizzeria - local american/italian pizzeria serving hand-tossed pies daily";
            string vendorsName2 = "Pietro's Pizzeria";
            Vendors newVendors1 = new Vendors(vendorDescription1, vendorsName1);
            Vendors newVendors2 = new Vendors(vendorDescription2, vendorsName2);
            Vendors result = Vendors.Find(2);
            Assert.AreEqual(newVendors2, result);
        }

        [TestMethod]
        public void AddOrders_AssociatesOrdersWithVendors_OrdersList()
        {
            string ordersTitle = "Joe's Cafe Order";
            string ordersDescription = "Joe's Cafe Order Invoice For x50 Pan Au Chocolat and x120 Traditional Croissants";
            string ordersDate = "05/14/2021"; 
            string ordersPrice = "$185.50";
            Orders newOrders = new Orders(ordersTitle, ordersDescription, ordersDate, ordersPrice);
            List<Orders> newList = new List<Orders> { newOrders };
            string vendorDescription = "Joe's Cafe - a small and quaint cafe serving fresh coffee and french pastries";
            string vendorsName = "Joe's Cafe";
            Vendors newVendors = new Vendors(vendorDescription, vendorsName);
            newVendors.AddOrders(newOrders);
            List<Orders> result = newVendors.Orders;
            CollectionAssert.AreEqual(newList, result);
        }
    }
}