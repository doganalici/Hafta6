using System;

namespace MetotOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //static metot içerisinden yalnızca static metot çağrılabilir.

            Console.WriteLine("Bu satır metot çağrılmadan önceki satır\n");
            for (int i = 0; i < 2; i++)
            {
                /// <summary>
                ///Bu metot ekrana mesaj yazdırır
                /// </summary>
                MerhabaYaz();
            }
            Console.WriteLine("\nBu satır metotdan dönüşten sonraki satır\n\n");

            /// <summary>
            ///Bu metot kullanıcıdan alınan iki sayının toplamını alır
            /// </summary>
            IkiSayiTopla();
            Console.ReadKey();
        }


        public static void MerhabaYaz()
        {
            Console.WriteLine("Merhaba, C# dünyasına hoş geldiniz.");
        }
        public static void IkiSayiTopla()
        {
            int sayi1, sayi2, toplam;
            try
            {

                Console.Write("Birinci sayıyı giriniz : ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz : ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                toplam = sayi1 + sayi2;
                Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Hata mesajı : {exc.Message}");
            }
        }

    }
}
