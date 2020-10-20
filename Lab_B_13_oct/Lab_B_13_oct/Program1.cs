using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_B_13_oct
{
    class Program1
    {
        static void Main(string[] args)
        {
            float a, b, c;
            float p, S;
            Console.WriteLine("Care este prima latura?");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Care este a doua latura?");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Care este a treia latura?");
            c = int.Parse(Console.ReadLine());

            p = (a + b + c) / 2;
            S = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Perimetrul triunghiului este {p}, iar aria este {S}");
        }
    }
}
