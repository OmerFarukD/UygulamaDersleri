using System.Threading.Channels;

Console.WriteLine("Hello, World!");

// Değer tipler
// int , bool, char , double , float
// Değer tipler null değerler alamazlar
// Hafızanın stack kısmında depolanır

// Referans tipler
// string , ArrayList, List, Map, enum , class ve interface
// referans tipler null değer alabilir

//string ad = "Gülsu Doğan";
//Console.WriteLine($" ad metninde ğ harfi var mı : {ad.Contains("ğ")}");
//Console.WriteLine(ad.ToUpper());

// Collections 
string[] sehirler = { "Elazığ", "KahramanMaraş", "Malatya","Ankara" };

//Console.WriteLine(sehirler[0]);
//Console.WriteLine(sehirler[1]);
//Console.WriteLine(sehirler[2]);

// 1. Yöntem  For döngüsü ile
for (int i=0;i<sehirler.Length;i++)
{
    Console.WriteLine(sehirler[i]);
}

Console.WriteLine("Sayılar dizisi");
// Foreach yöntemi ile
// Seed Data
int[] sayilar = { 1,2,3,4,5,6,7,8,9};
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
// Listeler 
// 1. Yöntem
List<string> meyveler = new List<string>() { 

"Karpuz","Çilek","Elma"
};

meyveler.Add("Kavun");
meyveler.Add("Armut");
List<string> eklenecekMeyveler = new List<string>()
{
    "Ejderha Meyvesi","Mango"
};
meyveler.AddRange(eklenecekMeyveler);

//foreach (string meyve in meyveler)
//{
//    Console.WriteLine(meyve);
//}

// predicate , lambda
meyveler.ForEach(meyve => Console.WriteLine(meyve));
List<int> numbers = new()
{
    1,4,2,3,7,6,8,9,11,10
};

numbers.Sort(); // küçükten üyüğe sıralar
numbers.Reverse(); // üyükten küçüğe sıralar
// 11 10 9 8 7 6 5 4 3 2 1
numbers.Remove(7); // Listede 7 olan elemanı siler.
// 11 10 9 8 6 5 4 3 2 1

numbers.ForEach(number => Console.WriteLine(number));

Console.WriteLine($" listedeki 3 olan değerin indexi : {numbers.IndexOf(3)}");
Console.WriteLine($"listedeki tüm elemanların toplamı : {numbers.Sum()}");
Console.WriteLine($"listedeki en küçük sayı : {numbers.Min()}");
Console.WriteLine($"listedeki en büyük  sayı : {numbers.Max()}");

// 1. Yöntem 
List<int> numbers1 = new()
{
    1,4,2,3,7,6,8,9,11,10
};

List<int> evenNumers = new();
// ************** For Yöntem **************

//for (int i = 0; i<numbers1.Count; i++)
//{
//    if (numbers1[i]%2==0)
//    {
//        evenNumers.Add(numbers1[i]);
//    }
//}

//for(int i = 0; i<evenNumers.Count; i++)
//{
//    Console.WriteLine(evenNumers[i]);
//}

//foreach (int number in numbers1)
//{
//    if (number %2 ==0)
//    {
//        evenNumers.Add(number);
//    }
//}
//// ************** Foreach Yöntem **************
//foreach (int ciftsayi in evenNumers)
//{
//    Console.WriteLine(ciftsayi);
//}

evenNumers = numbers1.FindAll(even => even % 2 ==0);
evenNumers.ForEach(number => Console.WriteLine(number));

// Sebzeler listesine 3 tane eleman ekleyin ve u 3 elemanı listele
// bu listede 2. İndexteki sebze adını ekrana bastırın
// Bu listede küçük harflerle yazılan sebzeleri büüyük harfle yazsın.





List<string> sebzeler = new();