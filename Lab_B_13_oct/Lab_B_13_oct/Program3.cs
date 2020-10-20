using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_B_13_oct
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This next program will take hours, minutes and seconds separately");
            Console.WriteLine("and convert them all into seconds, then display the total of seconds elapsed");

            int h, m, s;

            Console.WriteLine("Enter the number of hours desired to be converted");
            h = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of minutes desired to be converted");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of seconds desired to be converted");
            s = int.Parse(Console.ReadLine());

            s = s + h * 3600 + m * 60;
            Console.WriteLine("The total amount of seconds is {0}",s);


        }
    }
}
