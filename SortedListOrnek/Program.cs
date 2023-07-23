using System;
using System.Collections;

namespace SortedListOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "Ankara");
            sortedList.Add(5, "İstanbul");
            sortedList.Add(3, "Bursa");
            sortedList.Add(4, "İzmir");
            sortedList.Add(2, "Çanakkale");
            Console.WriteLine("--- Sorted List Anahtarlar ---");

            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\n---Sorted List Anahtarlar ---");

            foreach (var val in sortedList.Values)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine($"\n5'in indexi : {sortedList.IndexOfKey(5)}");
            Console.WriteLine($"\nÇanakkele indexi : {sortedList.IndexOfValue("Çanakkale")}");
            bool keyVarmi = sortedList.ContainsKey(6);
            if (keyVarmi)
            {
                Console.WriteLine("Var");
            }
            else
            {
                Console.WriteLine("Yok");
            }
            Console.ReadKey();
        }
    }
}
