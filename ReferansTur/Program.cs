using System;

namespace ReferansTur
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Ankara", "İstanbul", "İzmir", "Çorum", "Kırşehir" };
            Console.WriteLine($"Main Degistir den önce : {sehirler[4]}");
            Degistir(sehirler);
            Console.WriteLine($"Main Degistir den sonra : {sehirler[4]}");

            Console.ReadKey();
        }

        public static void Degistir(string[] sehirler)
        {
            sehirler[4] = "Sungurlu";
            Console.WriteLine($"Main Degistir içersinde : {sehirler[4]}");

        }
    }
}
