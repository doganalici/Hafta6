using System;

namespace StruckOrnek2
{
    struct Ogrenci
    {
        public string Ad;
        public int Yas;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Kerem AKKUŞ";
            ogrenci.Yas = 15;

            Console.WriteLine(ogrenci.Ad);
            Console.WriteLine(ogrenci.Yas);

            Console.ReadKey();
        }
    }
}
