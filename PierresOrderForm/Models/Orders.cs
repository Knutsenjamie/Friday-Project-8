using System.Collections.Generic;

namespace PierresOrderForm.Models 
{
    public class Orders
    {
        public string OrdersTitle { get; set; }
        public string OrdersDescription { get; set; }
        public string OrdersDate { get; set; }
        public int Id { get; }
        public string OrdersPrice  { get; set; }
        private static List<Orders> _instances = new() { };

        public Orders(string orderstitle, string ordersdescription, string ordersdate, string ordersprice)
        {
            OrdersTitle = orderstitle;
            OrdersDescription = ordersdescription;
            OrdersDate = ordersdate; 
            OrdersPrice = ordersprice;
            _instances.Add(this);
            Id = _instances.Count;
        }
        public static List<Orders> GetAll()
        {
            return ;
        }
    }
}