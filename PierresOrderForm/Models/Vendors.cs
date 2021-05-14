using System.Collections.Generic;

namespace PierresOrderForm.Models 
{
    public class Vendors
    {
        public string VendorsName { get; }
        public Vendors(string vendorsname)
        {
            VendorsName = vendorsname;
        }
    }
}