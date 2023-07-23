using System;

namespace StringMetotlariOrnek3_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            Console.Write("Email adresi giriniz : ");
            email = Console.ReadLine();
            int konum = email.IndexOf("@");
            int konum2 = email.LastIndexOf("@");
            if (konum >1 && konum==konum2)
            {
                Console.WriteLine("geçerli email adresi");
            }
            else
            {
                Console.WriteLine("hatalı email adresi");
            }

            Console.ReadKey();
        }
    }
}
