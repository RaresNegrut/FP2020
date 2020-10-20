using System;

namespace Lab_B_13_oct
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, does this work?\nIT DOES :D");
            int a, b, x;

            Console.WriteLine("Enter the first value to be interchanged");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0}", a);


            Console.WriteLine("Enter the second value to be interchanged");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("b={0}", b);

            x = a;
            a = b;
            b = x;

            Console.WriteLine("Your values are now interchanged!");
            Console.Write("a is now {0}, b is now {1}\n", a, b);
        }
    }
}
