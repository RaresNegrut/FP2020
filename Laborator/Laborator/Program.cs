using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator
{
    class Program
    {
        static void Main(string[] args)
        {
            //monoton
            monotonCrescator();
            monotonCrescatorRotit();
        }

        private static void monotonCrescatorRotit()
        {
            
        }

        /// <summary>
        /// Sa se determine daca o secventa de n(n>=1) numere este monoton crescator
        /// Secv monot=secventa monoton crescatoare
        /// </summary>
        private static void monotonCrescator()
        {
            int n, a, b;
            bool monotonCrescator = true;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b)
                    monotonCrescator = false;
                a = b;
            }
            if (monotonCrescator)
                Console.WriteLine("Secv este monot cresc");
            else
                Console.WriteLine("Secv nu e monot cresc");
        }
    }
}
