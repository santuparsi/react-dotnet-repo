using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    internal class Order
    {
        public string product;
        public DateTime orderDate;
        private Order() //privat constructor
        {

        }
        public static Order GetOrder()
        {
            var order = new Order();
            return order;
        }
    }
    class Test_Order
    {
        static void Main()
        {
            //Order o = new Order(); not able to create object
            Order order = Order.GetOrder();
            order.product = "Water bottle";
            order.orderDate = new DateTime(2024, 4, 12);
            order.orderDate = DateTime.Parse("4/12/23");
        }
    }
}
