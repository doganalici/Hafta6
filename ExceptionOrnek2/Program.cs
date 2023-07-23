using System;

namespace ExceptionOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //öğrenci 0 dan küçük ya da 100 den büyük olursa
            //hata fırlatsın

            int ogrNotu;
            Console.Write("Öğrenci notunu giriniz : ");
            ogrNotu = Convert.ToInt32(Console.ReadLine());
            if (ogrNotu<0 || ogrNotu>100)
            {
                throw new Exception("Öğrenci notu 0 dan küçük 100 den büyük olamaz !");
            }
            Console.WriteLine(ogrNotu);

            Console.WriteLine("\n\n--- Yaş Örnek ---");
            byte yas;
            Console.Write("Yaşınızı giriniz : ");
            yas = Convert.ToByte(Console.ReadLine());
            if (yas<18 || yas>35)
            {
                throw new Exception("Yaşınız 18-35 aralığında olmalıdır.");
            }
            Console.WriteLine("Şartlarınız sağlanmaktadır");
            Console.ReadKey();
        }
    }
}
