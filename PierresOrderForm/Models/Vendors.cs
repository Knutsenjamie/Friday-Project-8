using System.Collections.Generic;

namespace PierresOrderForm.Models 
{
    public class Vendors
    {
        public string VendorsName { get; set; }
        public string VendorDescription { get; set; }
        private static List<Orders> Orders { get; set; }


        public Vendors(string vendorsname, string vendordescription)
        {
            VendorsName = vendorsname;
            VendorDescription = vendordescription;
            Orders = new List<Orders>{};
        }

    }
}