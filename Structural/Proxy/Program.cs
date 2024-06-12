// See https://aka.ms/new-console-template for more information
using Proxy;

Console.WriteLine("Hello, World!");

/*
 * Maliyetli bir nesneniz var her isteği doğrudan bu nesneye göndermek istemiyorsunuz. Nasıl çözersiniz?
 */

MathProxy math = new MathProxy(new Proxy.Math());
Console.WriteLine(math.Division(10, 2));
Console.WriteLine(math.Division(10, 0));