// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * Bellekteki bir koleksiyon içinde navigasyon yapmanız gerek(ileri, geri, başa dön veya sona git vs.).
 * Bu nedenle iterator tasarım deseni kullanılır.
 */

var words = new List<string> { "A", "B", "C", "D", "E", "F" };
//var items = words.Skip(3).Take(2).ToList();
//var rangeItems = words.Take(3..5);//3. ve 4. elemanlar alınır (5. eleman alınmaz)
//var rangeItems2 = words[^1];//sondan birinci eleman

IteratorClass iteratorClass = new IteratorClass(words);

var current = iteratorClass.Current;
Console.WriteLine(current);
while(iteratorClass.MoveNext())
{
    current = iteratorClass.Current;
    Console.WriteLine(current);
}

iteratorClass.First();
Console.WriteLine(iteratorClass.Current);
iteratorClass.Last();
Console.WriteLine(iteratorClass.Current);