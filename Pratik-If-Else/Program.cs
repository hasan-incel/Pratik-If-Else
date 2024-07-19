// Kullanıcıdan sayı girişi alınıyor
Console.Write("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

// 10'a eşit mi, 10'dan küçük mü, 10'dan büyük mü kontrolü
if (sayi == 10)
{
    Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
}
else if (sayi < 10)
{
    Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");
}

// Çift mi, tek mi kontrolü
if (sayi % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}
