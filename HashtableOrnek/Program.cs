using System;
using System.Collections;

namespace HashtableOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Ankara");
            ht.Add(2, "İstanbul");
            ht.Add(3, "Bursa");
            ht.Add(4, "İzmir");
            ht.Add(5, "Çorum");
            ICollection anahtarlar = ht.Keys;
            foreach (var anahtar in anahtarlar)
            {
                Console.WriteLine(anahtar);
            }
            ht.Remove(3);
            ht.Add(3, "Samsun");
            Console.WriteLine();
            ICollection degerler = ht.Values;
            foreach (var deger in degerler)
            {
                Console.WriteLine(deger);
            }

            Console.Write("\nYazdırılacak key değerini giriniz : ");
            int key;
            key = Convert.ToInt32(Console.ReadLine());
            foreach (int anahtar in ht.Keys)
            {
                if (anahtar >= key)
                {
                    Console.WriteLine(ht[key].ToString());
                    break;
                }
                else
                {
                    Console.WriteLine("hata");
                    break;
                }

            }

            Console.ReadKey();
        }
    }
}
