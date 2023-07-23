using System;

namespace tringMetotlariOrnek5
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "me-ta-fi-zik";
            string[] dizi = metin.Split('-');
            foreach (var elm in dizi)
            {
                Console.Write(elm);
            }
            Console.WriteLine();
            string parca = "Adem".Substring(0, 2);
            string parca2 = "Bilgisayar Mühendisi".Substring(0, 3);
            string sirketİsmi = parca.ToUpper() + " - " + parca2.ToUpper();
            Console.WriteLine($"Şirket ismi : {sirketİsmi}");


            string n1 = "Adem".Substring(0, 1);
            string n2 = "AKKUŞ".Substring(0, 1);
            string nickname = n1 + n2;
            Console.WriteLine(nickname);

            string n3 = "Kerem".Substring(0, 1);
            string n4 = "ALDEMİR".Substring(0, 1);
            string nickname2 = n3 + n4;
            Console.WriteLine(nickname2);

            Console.ReadKey();
        }
    }
}
