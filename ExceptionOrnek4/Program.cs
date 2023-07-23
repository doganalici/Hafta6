using System;

namespace ExceptionOrnek4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi1, sayi2;
            double bolme;

            //throw new NullReferenceException();

            try
            {
                Console.Write("Birinci sayıyı giriniz : ");
                sayi1 = Convert.ToByte(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz : ");
                sayi2 = Convert.ToByte(Console.ReadLine());
                bolme = sayi1 / sayi2;
                Console.WriteLine(bolme);
            }
            catch (OverflowException oexc)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Deger olarak 0-255 aralığında giriniz.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Message : {oexc.Message}");
            }
            catch (DivideByZeroException dexc)
            {
                Console.WriteLine("Sıfıra bölme hatası.");
            }
            catch (FormatException fexc)
            {
                Console.WriteLine("Lütfen sayısal değer giriniz.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Source : {fexc.Source}");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Diğer exceptionlarda buraya düşecek");
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Finally bloğu her halükarda çalışır.");
            }




            Console.ReadKey();
        }
    }
}
