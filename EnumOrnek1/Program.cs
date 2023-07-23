using System;

namespace EnumOrnek1
{
    class Program
    {
        public enum SehirPlakalari
        {
            Adana = 01,
            Ankara = 06,
            Çorum = 19,
            Kırşehir = 40,
            Samsun = 55,
            Yozgat = 66
        }
        public enum Gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Şehir : {SehirPlakalari.Adana}");
            int plakaKodu = (int)SehirPlakalari.Çorum;
            Console.WriteLine($"Çorum Plaka Kodu : {plakaKodu}");
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine();
            string[] gunler = Enum.GetNames(typeof(Gunler));
            foreach (var gun in gunler)
            {
                Console.Write(gun + " ");
            }
            Console.WriteLine("\n\n--- gün değerleri ---\n");
            int[] degerler =(int[]) Enum.GetValues(typeof(Gunler));
            foreach (var deger in degerler)
            {
                Console.Write(deger + " ");
            }

            Console.WriteLine("\n\n--- plaka değerleri ---\n");
            int[] degerler2 =(int[]) Enum.GetValues(typeof(SehirPlakalari));
            foreach (var deger in degerler2)
            {
                Console.Write(deger + " ");
            }

            Console.ReadKey();
        }
    }
}
