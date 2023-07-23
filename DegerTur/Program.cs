using System;

namespace DegerTur
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 19;
            Console.WriteLine($"Main metodunda degistir metodundan önce : {sayi}");
            Degistir(ref sayi);
            Console.WriteLine($"Main metodunda degistir metodundan sonra : {sayi}");
            int sayi2;
            Degistir2(out sayi2);
            Console.WriteLine($"Main metodunda degistir2 metodundan sonra : {sayi2}");
            Console.ReadKey();
        }
        public static void Degistir(ref int sayi)
        {
            sayi = 40;
            Console.WriteLine($" degistir metodu içerisinde : {sayi}");
        }

        public static void Degistir2(out int sayi)
        {
            sayi = 100;
            Console.WriteLine($"\n degistir metodu içerisinde : {sayi}");
        }


    }
}
