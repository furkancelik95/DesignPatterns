// See https://aka.ms/new-console-template for more information
using Decorator;
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Stream fStream = new FileStream("deneme.txt", FileMode.Create);
Stream mStream = new MemoryStream();
//Stream nStream = new NetworkStream(new TcpClient().Client);

GZipStream stream = new GZipStream(fStream, CompressionLevel.Optimal);
CryptoStream cryptoStream = new CryptoStream(stream, null, CryptoStreamMode.Write);

/*
 * Problem:
 * Hali hazırda bellekte bulunan bir nesneye yeni özellik ya da fonksiyon kazandırmak isterseniz, nasıl bir yol izlersiniz?
 */

Mail mail = new Mail();
SignedDecorator signedMail = new SignedDecorator(mail, "Furkan Enes Çelik");
CryptedDecorator cryptedMail = new CryptedDecorator(signedMail);
cryptedMail.Send();
