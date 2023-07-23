using System;

namespace MetotParamsKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Topla();
            Topla(11);
            Topla(12, 11);
            Topla(13, 14, 15);
            Topla(13, 14, 15, 16);
            Topla(13, 14, 15, 16, 17);


            Console.ReadKey();
        }

        public static void Topla(params int[] sayilar)
        {
            int toplam = 0;
            if (sayilar.Length==0)
            {
                Console.WriteLine("Değer yok");
                return;
            }
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            Console.WriteLine(toplam);
        }
    }
}
