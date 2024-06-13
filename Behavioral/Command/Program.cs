// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * İstemciden sürekli olarak aksiyon alan (dosya işlemleri, db işlemleri, hesaplamalar vs.) bir uygulamada bu aksiyonları düzenli bir biçimde
   yönetmek istiyorsanız, nasıl bir tasarım oluşturursunuz? 
 */

DatabaseCommandReceiver commandReceiver = new DatabaseCommandReceiver();
DiscountProductCommand discountProductCommand = new DiscountProductCommand(8, 0.25m, commandReceiver);
RaiseProductCommand raiseProductCommand = new RaiseProductCommand(16, 0.53m, commandReceiver);

CommandInvoker invoker = new CommandInvoker();
invoker.Add(discountProductCommand);
invoker.Add(raiseProductCommand);
invoker.Execute();