using System;

namespace MetotDiziOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = DiziOlustur();
            DiziYazdir(sayilar);
            Console.ReadKey();
        }



        public static void DiziYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }
            Console.WriteLine($"\nDizinin eleman sayısı : {dizi.Length}");
        }

        public static int[] DiziOlustur()
        {
            int[] sayilar = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = rnd.Next(1,100);
            }
            return sayilar;
        }
    }
}
