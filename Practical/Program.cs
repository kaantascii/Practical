using System;

class Antremanlar
{
    static void Main(string[] args)
    {
        //Kullanıcıdan sayı alıyoruz.
        Console.WriteLine("Lütfen bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());

        //10 'dan büyük mü, küçük mü, eşit mi kontrolü yapıyoruz.
        if (sayi > 10)
        {
            Console.WriteLine("sayı 10 dan büyüktür.");
        }
        else if (sayi < 10)
        {
            Console.WriteLine("sayı 10 dan küçüktür.");
        }
        else
        {
            Console.WriteLine("sayı 10 a eşittir.");
        }
        //çift mi tek mi kontrolü yapıyoruz.
        if (sayi % 2 == 0)
        {
            Console.WriteLine("sayı çifttir.");
        }
        else
        {
            Console.WriteLine("sayı tektir.");
        }


    }
}