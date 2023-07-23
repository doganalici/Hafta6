using System;

namespace ParametreAlanDegerDonduren
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplama = Topla(12, 3);
            Console.WriteLine($"Toplama sonucu : {toplama}");

            int cikarma = Cikar(12, 3);
            Console.WriteLine($"Çıkarma sonucu : {cikarma}");

            string gelen = ParcaAl("Bilgisayar Mühendisi");
            Console.WriteLine(gelen);

            Console.WriteLine(Bul("Merhaba Dünya."));

            int kelimeSayisi = KelimeBul("Merhaba c# dünyasına hoş geldiniz. Bu ders metotlar işlendi");
            Console.WriteLine($"Kelime sayısı : {kelimeSayisi}");

            Console.ReadKey();
        }

        /// <summary>
        /// Dışarıdan gelen int türünde
        /// iki tamsayının toplamını geriye döndürür
        /// </summary>
        /// <param name="x">int x</param>
        /// <param name="y">int y</param>
        /// <returns>Dönüş değeri : int toplam</returns>
        public static int Topla(int x, int y)
        {
            int toplam = x + y;
            return toplam;
            //return x+y;
        }

        /// <summary>
        /// Dışarıdan gelen int türünde
        /// iki tamsayının farkını geriye döndürür
        /// </summary>
        /// <param name="x">int x</param>
        /// <param name="y">int y</param>
        /// <returns>Dönüş değeri : int fark</returns>
        public static int Cikar(int x, int y)
        {
            int fark = x - y;
            return fark;

        }

        /// <summary>
        /// Dışarıdan verilen metnin 
        /// ilk dört karakterini döndrür
        /// </summary>
        /// <param name="metin">string metin</param>
        /// <returns>string türünde parça</returns>
        public static string ParcaAl(string metin)
        {
            string parca = metin.Substring(0, 4);
            return parca;
        }

        public static int Bul(string metin)
        {
            int uzunluk = metin.Length;
            return uzunluk;
        }


        public static int KelimeBul(string metin)
        {
            string[] dizi = metin.Split(" ");
            //foreach (var eleman in dizi)
            //{
            //    Console.WriteLine(eleman);
            //}

            int kelimeSayisi = dizi.Length;

            return kelimeSayisi;
        }

    }
}
