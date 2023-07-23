using System;

namespace TupleOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, string, double) demet = new("Adem AKKUŞ", "Bilg. Müh.", 15000);
  
            Console.WriteLine($"demet tipi : {demet.GetType().Name}");
            Console.WriteLine($"demet : {demet}");
            Console.WriteLine($"demet birinci eleman : {demet.Item1}");
            Console.WriteLine($"demet ikinci eleman : {demet.Item2}");
            Console.WriteLine($"demet üçüncü eleman : {demet.Item3}");

            Console.WriteLine("------------------------------------------");
            (string ad, string meslek, double maas) demet2 = new("Doğan ALICI", "Bilg. Müh.", 30000);
            Console.WriteLine($"demet : {demet2}");
            Console.WriteLine($"demet birinci eleman : {demet2.ad}");
            Console.WriteLine($"demet ikinci eleman : {demet2.meslek}");
            Console.WriteLine($"demet üçüncü eleman : {demet2.maas}");


            Console.ReadKey();
        }
    }
}
