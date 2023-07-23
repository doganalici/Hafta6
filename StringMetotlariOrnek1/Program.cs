using System;

namespace StringMetotlariOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Metotlar";
            string metin;
            Console.Write("Bir metin giriniz : ");
            metin = Console.ReadLine();
            int uzunluk = metin.Length;
            Console.WriteLine($"girilen metnin karakter sayısı {uzunluk}");

            //Clone(): bir stringin kopyasını alır.
            string klon = (string)metin.Clone();
            string klon2 = Convert.ToString(metin.Clone());
            string klon3 = metin.Clone().ToString();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(klon);

            //Compare : iki stringi karşılaştırmak için kullanılır.
            Console.WriteLine();
            string isim = "Mehmet";
            string disim ="mehmet";
            int sonuc = isim.CompareTo(disim);
            if (sonuc==0)
            {
                Console.WriteLine("İkisi aynı string");
            }
            else
            {
                Console.WriteLine("İkisi farklı string");
            }

            Console.WriteLine();
            //str1.Contains(str2) : str2 yi str1 in içerisine aktar
            bool varMi=metin.Contains(isim);

            if (varMi)
            {
                Console.WriteLine("İsim metnin içerisinde VAR");
            }
            else
            {
                Console.WriteLine("İsim metnin içerisinde YOK");
            }

            //str1.Equals(str2) : iki stringi karşılaştırır.
            //aynı ise true, farklı ise false döndürür

            Console.WriteLine(isim.Equals(disim)); 


            Console.ReadKey();
        }
    }
}
