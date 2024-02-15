using System;
using System.Collections.Generic;
namespace uppgift6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två strängar");
            Console.Write("Sträng 1: ");
            string a = Console.ReadLine();
            Console.Write("Sträng 2: ");
            string b = Console.ReadLine();
            Längst(a, b);
        }
        static void Längst(string a, string b)
        {
            if (a.Length > b.Length)
            {
                Console.WriteLine($"Sträng 1 är den längsta strängen");
            }
            else if (b.Length > a.Length)
            {
                Console.WriteLine($"Sträng 2 är den längsta strängen");
            }
            else
            {
                Console.WriteLine("Båda strängarna är lika långa");
            }
        }
    }
}