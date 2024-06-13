// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * Çok fazla nesne kullanarak çok karmaşık işler yapmanız gereken bir senaryonuz var.
 * Geliştiricinin en kolay biçimde bu işlemi yapması için ne  yapmalısınız?
 */

OrderService orderService = new OrderService();
var cartItems = new List<CartItem>
{
    new CartItem { ProductId = 1, Quantity = 8 },
    new CartItem { ProductId = 2, Quantity = 5 }
};
orderService.CreateOrder("Furkan", cartItems);