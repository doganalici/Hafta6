using System;

namespace TupleDegerDonduren
{
    class Program
    {
        static void Main(string[] args)
        {
            var donen = TupleDondur();
            Console.WriteLine($"araba modeli : {donen.model}\naraba kilometresi : {donen.kilometre}\naraba motor hacmi : {donen.motor}");

            Console.WriteLine("---------------------------");

            (string mdl, int klm, double mtr) otomobil = TupleDondur();
            Console.WriteLine($"araba modeli : {otomobil.mdl}\naraba kilometresi : {otomobil.klm}\naraba motor hacmi : {otomobil.mtr}");
            Console.ReadKey();
        }
        public static (string model,int kilometre,double motor) TupleDondur()
        {
            var araba = ("Opel Corsa", 100000, 1.6);
            return araba;
        }
    }
}
