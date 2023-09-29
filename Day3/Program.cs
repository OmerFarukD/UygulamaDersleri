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
int[] sayilar = { 1,2,3,4,5,6,7,8,9};
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}





