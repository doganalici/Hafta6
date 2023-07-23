using System;

namespace StrucktOrnek
{
    struct Koordinatlar
    {
        public int X { get; }
        public int Y { get; }
    
        public Koordinatlar(int x,int y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Koordinatlar koordinatlar = new Koordinatlar(10,20);
            Console.WriteLine($"X koordinatı : {koordinatlar.X}");
            Console.WriteLine($"Y koordinatı : {koordinatlar.Y}");

            Console.ReadKey();
        }
    }
}
