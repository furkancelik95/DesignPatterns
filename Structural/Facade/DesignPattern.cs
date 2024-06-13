using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Customer
    {
        public string Name { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }

    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class CartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

    public class OrderService
    {
        public void CreateOrder(string customerName, List<CartItem> cartItems)
        {
            Customer customer = new Customer { Name = customerName };
            Order order = new Order { Id = 1453, Customer = customer, OrderDate = DateTime.Now };

            var orderItems = cartItems.Select(ci => new OrderItem
            {
                OrderId = order.Id,
                ProductId = ci.ProductId,
                Quantity = ci.Quantity
            }).ToList();

            orderItems.ForEach(orderItem =>
            {
                order.OrderItems.Add(orderItem);
                Console.WriteLine($"{customer.Name} isimli müşteri, {order.OrderDate} tarihinde, {orderItem.ProductId} id'li üründen, {orderItem.Quantity} adet sipariş verdi.");
                Console.WriteLine($"ürünün stoğundan {orderItem.Quantity} kadar düşüldü");
            });

        }
    }

}
