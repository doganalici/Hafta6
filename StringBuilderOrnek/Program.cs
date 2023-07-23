using System;
using System.Text;

namespace StringBuilderOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Adem");
            sb.Append("AKKUŞ");
            sb.Append(25.45);
            sb.Append(10000);
            sb.Append(Environment.NewLine);
            sb.Append(true);
            sb.Append('A');
            Console.WriteLine(sb);

            Console.WriteLine("\n--------------------\n");
            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine("Adem");
            sb2.AppendLine("AKKUŞ");
            sb2.AppendLine(25.45.ToString());
            sb2.AppendLine(10000.ToString());
            sb2.AppendLine(Environment.NewLine);
            sb2.AppendLine(true.ToString());
            sb2.AppendLine('A'.ToString());
            Console.WriteLine(sb2);

            Console.WriteLine("\n--------------------\n");
            string mesaj = "Selam Dünyası.gereksiz";
            StringBuilder yenisb = new StringBuilder();
            yenisb.Append(mesaj);
            yenisb.Insert(6, "C# ");
            Console.WriteLine(yenisb);
            yenisb.Remove(17,8);
            Console.WriteLine(yenisb);

            Console.ReadKey();
        }
    }
}
