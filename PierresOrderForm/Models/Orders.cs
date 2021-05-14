using System.Collections.Generic;

namespace PierresOrderForm.Models 
{
    public class Orders
    {
        public string OrdersTitle { get; set; }
        public string OrdersDescription { get; set; }
        public string OrdersDate { get; set; }
        public int Id { get; }
        public decimal OrdersPrice  { get; set; }
        private static List<Orders> _instances = new() { };
    }
}