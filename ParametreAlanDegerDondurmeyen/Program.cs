using System;

namespace ParametreAlanDegerDondurmeyen
{
    class Program
    {
        static void Main(string[] args)
        {

            Topla(5, 10);
            Cikar(15, 10);
            Carp(3, 5);
            Bol(20, 4);
            Mod(12, 5);
            Console.ReadKey();


        }
        ///<summary>
        /// Bu metot dışarıdan gelen int türünde
        /// iki tamsayının toplamını ekrana yazdırır
        /// </summary>
        /// <param name="x">int x</param>
        /// <param name="y">int y</param>
        public static void Topla(int x, int y)
        {
            int toplam = x + y;
            Console.WriteLine(toplam);
        }

        ///<summary>
        /// Bu metot dışarıdan gelen int türünde
        /// iki tamsayının farkını ekrana yazdırır
        /// </summary>
        public static void Cikar(int x, int y)
        {
            int fark = x - y;
            Console.WriteLine(fark);
        }

        ///<summary>
        /// Bu metot dışarıdan gelen int türünde
        /// iki tamsayının çarpımını ekrana yazdırır
        /// </summary>
        public static void Carp(int x, int y)
        {
            int carp = x * y;
            Console.WriteLine(carp);
        }

        ///<summary>
        /// Bu metot dışarıdan gelen int türünde
        /// iki tamsayının bölümünü ekrana yazdırır
        /// </summary>
        public static void Bol(int x, int y)
        {
            int bol = x / y;
            Console.WriteLine(bol);
        }

         ///<summary>
        /// Bu metot dışarıdan gelen int türünde
        /// iki tamsayının modunu ekrana yazdırır
        /// </summary>
        public static void Mod(int x, int y)
        {
            int mod = x % y;
            Console.WriteLine(mod);
        }

    }
}
