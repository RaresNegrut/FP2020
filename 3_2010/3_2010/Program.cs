using System;

namespace _3_2010
{
    class Program
    {
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
            int n,s=0;
            Console.WriteLine("enter a number for the Gaussian sum");
            n=int.Parse(Console.ReadLine());
            s = ((n + 1) * n) / 2;
            Console.Write($"The sum of numbers from 1 to {n} is:{s}");

        }
    }
}
