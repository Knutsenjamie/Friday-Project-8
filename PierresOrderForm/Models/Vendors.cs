using System.Collections.Generic;

namespace PierresOrderForm.Models 
{
    public class Vendors
    {
        public string VendorsName { get; set; }
        public string VendorDescription { get;  }

        public Vendors(string vendorsname, string vendordescription)
        {
            VendorsName = vendorsname;
            VendorDescription = vendordescription;
        }
    }
}