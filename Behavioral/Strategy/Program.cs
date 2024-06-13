// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * Bir iş için yazdığınız bir algoritma değişmesi gerekirse; minimum kod değişikliği ile bu güncellemeyi nasıl yaparsınız?
 */

ProductCollection productCollection = new ProductCollection();
productCollection.Sort(new BubbleSortAlgorithm());
productCollection.Sort(new HeapSortAlgorithm());