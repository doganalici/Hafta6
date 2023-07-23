using System;
using System.Collections;

namespace QueueOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue sira = new Queue();
            sira.Enqueue("Adem");
            sira.Enqueue("Ankara");
            sira.Enqueue(1000);
            sira.Enqueue(true);

            foreach (var elm in sira)
            {
                Console.WriteLine(elm);
            }
            var tepe = sira.Peek();
            Console.WriteLine($"\nkuyruğun tepesindeki eleman : {tepe}");
            var silinen = sira.Dequeue();
            Console.WriteLine($"\nkuyruktan silinen eleman : {silinen}");
            Console.WriteLine("\n--- dequeue işleminden sonra ---");
            foreach (var elm in sira)
            {
                Console.WriteLine(elm);
            }
            Console.ReadKey();
        }
    }
}
