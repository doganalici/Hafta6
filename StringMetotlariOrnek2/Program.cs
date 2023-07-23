using System;

namespace StringMetotlariOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //strA.IndexOf(strB) : strB nin indeksini strA içerisinde arar.
            string strA = "Ankara";
            string strB = "k";
            int result = strA.IndexOf(strB);
            Console.WriteLine(result);
            string strC = string.Empty;
            int result2 = strA.IndexOf(strC);
            //Console.WriteLine(result2);

            if (result2 == -1)
            {
                Console.WriteLine("Aranan string metinde yok");
            }
            else if (result2 == 0)
            {
                Console.WriteLine($"Aranan indeksi : {result2}");
            }
            else
            {
                Console.WriteLine($"aranan indeksi : {result2}");
            }

            Console.WriteLine();
            Console.WriteLine(strA.ToLower());
            Console.WriteLine(strA.ToUpper());

            Console.WriteLine();
            string isim = "Adem";
            string disim = "adem";
            Console.WriteLine(disim.Equals(isim.ToLower()));

            Console.WriteLine();
            string sehir = "Ankaram";
            int ilkIndex = sehir.IndexOf('a'), sonIndex = sehir.LastIndexOf('a');
            Console.WriteLine($"a nın ilk indeks : {ilkIndex}");
            Console.WriteLine($"a nın son indeks : {sonIndex}");
            Console.ReadKey();
        }
    }
}
