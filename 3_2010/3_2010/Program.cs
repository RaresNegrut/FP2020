using System;

namespace _3_2010
{
    class Program
    {
        static int Gauss(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += i;
            }
            return s;
        }
        Ordonare3V2(int a, int b,int c)
        {

        }
        static void Main(string[] args)
        {
            //programare structurata
            //structura liniara sau secventiala
            //executarea unor instructiuni una dupa alta

            //structura alternativa sau de decizie
            //ramificarea executiei programului in functie de o conditie

            //structura repetitiva sau iterativa
            //repetarea uneia/mai multor instructiuni de mai multe ori
            //cat timp o conditie este adevarata

            //programare procedurala
            //organizarea codului sub forma de proceduri/functii(metode)

            //gaussian sum
            int n;
            Console.WriteLine("enter a number for the Gaussian sum");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine(Gauss(n));
            //s = ((n + 1) * n) / 2;
            Console.Write($"The sum of numbers from 1 to {n} is:{s}");
            //sb
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            //if(a<b)
            //{
            //    if (a < c)
            //    {
            //        Console.Write(a);

            //    }
                

            //}

        }
    }
}
