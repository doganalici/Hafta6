using System;
using System.Collections.Generic;

namespace DictionaryOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirler = new Dictionary<int, string>();
            sehirler.Add(06, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(19, "Çorum");
            sehirler.Add(44, "Malatya");
            sehirler.Add(66, "Yozgat");
            sehirler.Add(7, "Mersin");

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine("\n--- key value ---");
            foreach (KeyValuePair<int, string> sehir in sehirler)
            {
                Console.WriteLine($"{sehir.Key} ---> {sehir.Value}");
            }

            //7 plakasını Antalya olarak değiştirelim
            sehirler[7] = "Antalya";
            Console.WriteLine("\n--- Değişiklikten sonra ---");
            foreach (KeyValuePair<int, string> sehir in sehirler)
            {
                Console.WriteLine($"{sehir.Key} ---> {sehir.Value}");
            }


            Console.ReadKey();
        }
    }
}
