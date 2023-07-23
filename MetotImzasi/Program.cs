using System;

namespace MetotImzasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overload : metot aşırı yükleme
            //aynı isimde parametre listesi değiştirilerek
            //metotlar tanımlama işlemine denir.
            Topla(12, 23);
            Topla(12, 23, 34);
            Topla(12.33, 23.44);
            Topla(11.2, 22.3, 4);

            Console.ReadKey();
        }

        public static void Topla(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static void Topla(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        public static void Topla(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }

        public static void Topla(double x, double y, int z)
        {
            Console.WriteLine(x + y + z);
        }



    }
}
