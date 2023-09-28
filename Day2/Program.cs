//Console.WriteLine("Lütfen yaşınızı giriniz.");
//int yas = Convert.ToInt32(Console.ReadLine());

//if (yas < 18)
//{
//    Console.WriteLine("Ehliyet alamaz");
//}
//else
//{
//    Console.WriteLine("Ehliyet alailir.");
//}
// Yorum satırı için Ctrl + K+ C


// ************************* if else *************************
//if (islem == "+")
//{
//    int toplam = sayi1 + sayi2;
//    // String interpolation
//    Console.WriteLine($"{sayi1} ve {sayi2} nin toplamı : {toplam}");
//}
//else if(islem == "-")
//{
//    int sonuc = sayi1 - sayi2;
//    Console.WriteLine($" {sayi1} ve {sayi2} nin farkı : {sonuc}");
//}
//else
//    Console.WriteLine("Yanlış karkater girdiniz.");
//Console.WriteLine("uygulama bitti.");

//************************* Switch case *************************

//try
//{

//    Console.WriteLine("1 . Sayıyı giriniz: ");
//    int sayi1 = Convert.ToInt32(Console.ReadLine());


//    Console.WriteLine("+, - bunlardan birini seçiniz.");
//    string islem = Console.ReadLine();

//    Console.WriteLine("2. Sayıyı giriniz.");
//    int sayi2 = Convert.ToInt32(Console.ReadLine());

//    switch (islem)
//    {
//        case "+":
//            {
//                int toplam = sayi1 + sayi2;
//                Console.WriteLine("sayıların toplamı: " + toplam);
//                break;
//            }
//        case "-":
//            {
//                int sonuc = sayi1 - sayi2;
//                Console.WriteLine("Sayıların farkı: " + sonuc);
//                break;
//            }

//        default:
//            {
//                Console.WriteLine("Yanlış Karakter girdiniz");
//                break;
//            }
//    }

//}catch (FormatException e)
//{
//    Console.WriteLine(e.Message);
//}
// Pascal Case
int ilkDeger = 0;
Console.WriteLine("While Döngüsü ile");
while (ilkDeger<=10)
{
    Console.WriteLine(ilkDeger);
    // 1. Yöntem
    ilkDeger+=3;
}

Console.WriteLine("For döngüsü ile");
for (int i =0; i<=10;i+=5)
{
    Console.WriteLine(i);
}
























