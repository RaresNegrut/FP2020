using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemePropuse
{
    class Program
    {
        //programe cu functii si tablouri
        //40. sa se scrie o functie care calculeaza patratul elementelor memorate intr-un tablou
        static void patrateVector()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < v.Length; i++)
                v[i] *= v[i];
            //functia afiseaza rezultatul prelucrarii vectorului
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine($"{v[i]} ");

        }
        //45. sa se scrie un program care aduna doua matrici de dimensiune nxn
        static void adunareMatrici()
        {
            int n = int.Parse(Console.ReadLine());
            string input;
            int[,] matr1 = new int[n, n];
            string[] split;
            Console.WriteLine("Introduceti matricea 1");
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                split = input.Split(new Char[] { ' ' });
                for (int j = 0; j < n; j++)
                {
                    matr1[i, j] = int.Parse(split[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Introduceti matricea 2");
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                split = input.Split(new Char[] { ' ' });
                for (int j = 0; j < n; j++)
                {
                    matr1[i, j] += int.Parse(split[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Rezultatul adunarii celor doua matrici este:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{matr1[i, j]} ");
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            patrateVector();
            adunareMatrici();
        }
    }
}
