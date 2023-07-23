using System;

namespace StringMetotlariOrnek4
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Merhaba ";
            string yenimetin = metin.Insert(8,"Dünyaam");
            Console.WriteLine(metin);
            Console.WriteLine(yenimetin);
            string silinen = yenimetin.Remove(10,2);
            Console.WriteLine(silinen);
            string metin2 = "Merhaba";
            Console.WriteLine("\n---- StartWith() ----");
            Console.WriteLine(metin2.StartsWith("M"));
            Console.WriteLine(metin2.StartsWith("m"));
            Console.WriteLine(metin2.StartsWith("Mer"));
            Console.WriteLine(metin2.StartsWith("mer"));

             Console.WriteLine("\n---- EndWith() ----");
            Console.WriteLine(metin2.EndsWith("A"));
            Console.WriteLine(metin2.EndsWith("a"));
            Console.WriteLine(metin2.EndsWith("abba"));
            Console.WriteLine(metin2.EndsWith("aba"));

            Console.WriteLine();
            string deger = "katap";
            string yeni = deger.Replace("ka", "ki");
            Console.WriteLine(yeni);

            Console.WriteLine();
            char[] harfler = yeni.ToCharArray();
            foreach (var harf in harfler)
            {
                Console.WriteLine(harf);
            }

            Console.ReadKey();
        }
    }
}
