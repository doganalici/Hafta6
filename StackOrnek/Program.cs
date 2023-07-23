using System;
using System.Collections;

namespace StackOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push("Adem");
            stk.Push("Ankara");
            stk.Push(1000);
            stk.Push(true);
            foreach (var elm in stk)
            {
                Console.WriteLine(elm);
            }

            var tepe = stk.Peek();
            Console.WriteLine($"\ntepe eleman : {tepe}");

            stk.Pop();
            var silinen=stk.Pop();
            Console.WriteLine($"\nsilinen eleman : {silinen}");
            Console.WriteLine("\n---Pop işleminden sonra");
            foreach (var elm in stk)
            {
                Console.WriteLine(elm);
            }



            Console.ReadKey();
        }
    }
}
