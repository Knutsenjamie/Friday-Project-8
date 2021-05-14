using System.Collections.Generic;

namespace PierresOrderForm.Models 
{
    public class Vendors
    {
        private static List<Vendors> _instances = new() { };
        public string VendorsName { get; set; }
        public string VendorDescription { get; set; }
        public int Id { get; }
        private static List<Orders> Orders { get; set; }



        public Vendors(string vendorsname, string vendordescription)
        {
            VendorsName = vendorsname;
            VendorDescription = vendordescription;
            Id = _instances.Count;
            _instances.Add(this);
            Orders = new List<Orders>{};
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}