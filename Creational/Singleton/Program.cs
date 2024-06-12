// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * Uygulamanızda SADECE 1 adet olmasını istediğiniz bir instance var. Bunu nasıl sağlarsınız?
 */
MailConfigurator mailConfigurator = MailConfigurator.CreateInstance();
mailConfigurator.Host = "smtp.gmail.com";

MailConfigurator mailConfigurator2 = MailConfigurator.CreateInstance();
mailConfigurator2.Host = "smtp.yandex.com";
Console.WriteLine(mailConfigurator2.Host);