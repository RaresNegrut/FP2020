using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemsPool.Functions;

namespace ProblemsPool
{
    class Program
    {
        static Dictionary<int, Action> pool1Ex = new Dictionary<int, Action>
        {
            {1,()=>Pool1.exercise1() },
            {2,()=>Pool1.exercise2() },
            {3,()=>Pool1.exercise3() },
            {4,()=>Pool1.exercise4() },
            {5,()=>Pool1.exercise5() },
            {6,()=>Pool1.exercise6() },
            {7,()=>Pool1.exercise7() },
            {8,()=>Pool1.exercise8() },
            {9,()=>Pool1.exercise9() },
            {10,()=>Pool1.exercise10() },
            {11,()=>Pool1.exercise11() },
            {12,()=>Pool1.exercise12() },
            {13,()=>Pool1.exercise13() },
            {14,()=>Pool1.exercise14() },
            {15,()=>Pool1.exercise15() },
            {16,()=>Pool1.exercise16() },
            {17,()=>Pool1.exercise17() },




        };

        static void Main(string[] args)
        {
            //ca sa pot afisa caractere subscript si superscript unde era nevoie, am schimbat formatarea consolei ca sa suporte unicode
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                System.IO.StreamReader f = new System.IO.StreamReader(@"..\..\Cerinte\cerinte.txt");
                string line;
                while ((line = f.ReadLine()) != null)
                    Console.WriteLine(line);
                Console.WriteLine();
                Console.WriteLine("Introduceti numarul problemei pe care doriti sa o rulati");
                int n = int.Parse(Console.ReadLine());
                pool1Ex[n]();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
