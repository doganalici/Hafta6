using System;

namespace ExceptionOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int ogrNotu;
                Console.Write("Öğrenci notunu giriniz : ");
                ogrNotu = Convert.ToInt32(Console.ReadLine());
                if (ogrNotu < 0 || ogrNotu > 100)
                {
                    throw new OverflowException();
                }
                Console.WriteLine(ogrNotu);
            }
            catch (OverflowException oexc)
            {

                Console.WriteLine("Öğrenci notu 0 dan küçük 100 den büyük olamaz !");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Message : {oexc.Message}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"ToString : {oexc.ToString()}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"StackTrace : {oexc.StackTrace}");

            }


            Console.ReadKey();
        }
    }
}
