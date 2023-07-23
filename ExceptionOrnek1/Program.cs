using System;

namespace ExceptionOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1, sayi2;
            Console.Write("Birinci sayıyı giriniz : ");
            sayi1 = Convert.ToByte(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz : ");
            sayi2 = Convert.ToByte(Console.ReadLine());

            double bolme = sayi1 / sayi2;
            Console.WriteLine(bolme);

            int toplam = sayi1 - sayi2;
            Console.WriteLine(toplam);

            Console.ReadKey();
        }
    }
}
