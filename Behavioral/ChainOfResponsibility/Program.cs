// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * Bir istek birden fazla işlemden geçerek bir sonuca ulaşıyor. Her bir işlem benzer standartlar ve aynı amaç için çalışıyor.
 * (Örnek: Asp.net Core'da http request pipeline ya da ATM'deki para analojisi).
 * Hangi işlemin nasıl yapılacağını en ideal nasıl tasarlarsınız?
 */

ReservationRequest reservationRequest = new ReservationRequest
{
    Owner = "Furkan Enes Çelik",
    CheckIn = new DateOnly(2024, 6, 18),
    CheckOut = new DateOnly(2024, 6, 19),
    Country = "Italy"
};

CheckOwnerHandler checkOwnerHandler = new CheckOwnerHandler();
CheckInAndOutHandler checkInAndOutHandler = new CheckInAndOutHandler();
IsAvailableHandler isAvailableHandler = new IsAvailableHandler();
IsCountryTurkeyHandler isCountryTurkeyHandler = new IsCountryTurkeyHandler();
IsCountryItalyHandler isCountryItalyHandler = new IsCountryItalyHandler();

checkOwnerHandler.Next = checkInAndOutHandler;
checkInAndOutHandler.Next = isAvailableHandler;
isAvailableHandler.Next = isCountryTurkeyHandler;
isCountryTurkeyHandler.Next = isCountryItalyHandler;

checkOwnerHandler.Handler(reservationRequest);
Console.WriteLine("Rezervasyon yapıldı");