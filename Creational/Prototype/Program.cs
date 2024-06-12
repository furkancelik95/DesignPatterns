// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * Bellekte oluşturulması çok zaman alan bir nesneniz var. Ama aynısından birkaç tane kullanmanız gerekiyor.
 * İlki hariç diğerlerinin hiç zaman almaması için yapabileceğimiz bir şey var mı?
 */

//Clone'da bir prototype desing patterns'dir. Bu pattern'de bir nesnenin kopyasını oluşturmak için kullanılır.
string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
var cloneLetters = (string[])letters.Clone();
cloneLetters[0] = "F";

Chair chair1 = new Chair();
Console.WriteLine(chair1);
//Chair chair2 = (Chair)chair1.Clone();
Chair chair2 = (Chair)chair1.Clone(true);
chair2.No = 2;
chair2.Cinema.Movie = "Poor Things";
Console.WriteLine(chair2);
Chair chair3 = (Chair)chair1.Clone();
chair3.No = 3;
Console.WriteLine(chair3);
Chair chair4 = (Chair)chair1.Clone();
chair4.No = 4;
Console.WriteLine(chair4);
Chair chair5 = (Chair)chair1.Clone();
chair5.No = 5;
Console.WriteLine(chair5);
Chair chair6 = (Chair)chair1.Clone();
chair6.No = 6;
Console.WriteLine(chair6);

Console.WriteLine($"DİKKAT Chair1 nesnesi: {chair1}");