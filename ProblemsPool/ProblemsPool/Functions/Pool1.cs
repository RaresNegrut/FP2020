using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProblemsPool.Functions
{
    static class Pool1
    {
        public static void exercise1()
        {
            double a, b;
            Console.WriteLine("Ecuatie de forma: ax+b=0");
            Console.WriteLine("Introduceti a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b:");
            b = double.Parse(Console.ReadLine());
            if (a == 0 && b != 0)
                throw new Exception("Ecuatia nu are solutii deoarece a este nul");
            if (a == 0 && b == 0)
                throw new Exception("Ecuatia are o infinitate de solutii, deoarece a si b au valori nule");
            Console.WriteLine($"Rezultatul este: {-b / a}");
        }
        public static void exercise2()
        {
            double a, b, c;
            // \xb2 sau \u00b2 este codul pentru 2 superscript in unicode
            Console.WriteLine($"Ecuatie de forma:ax\xb2+bx+c ");

            Console.WriteLine("Introduceti a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti c:");
            c = double.Parse(Console.ReadLine());

            double delta = (b * b - 4 * a * c);
            if (delta > 0)
            {
                Console.WriteLine("Doua solutii cu delta pozitiv:");
                //  \u2081 este unicode pentru 1 subscript
                Console.WriteLine($"x\u2081= {(-b + Math.Sqrt(delta)) / (2 * a)}");
                Console.WriteLine($"x\u2082= {(-b - Math.Sqrt(delta)) / (2 * a)}");
            }
            if (delta == 0)
                Console.WriteLine(-b / (2 * a));
            if (delta < 0)
            {
                Console.WriteLine("Doua solutii cu delta negativ:");
                delta = Math.Abs(delta);
                delta = Math.Sqrt(delta);
                Console.WriteLine($"x\u2081= {-b / (2 * a)} + {delta / (2 * a)}i");
                Console.WriteLine($"x\u2082= {-b / (2 * a)} - {delta / (2 * a)}i");
            }
        }
        public static void exercise3()
        {
            int n, k;
            Console.WriteLine("Se divide n cu k?");
            Console.WriteLine("Introduceti n de la tastatura");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k de la tastatura");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("n se divide cu k");
            else
                Console.WriteLine("n nu se divide cu k");
        }
        public static void exercise4()
        {
            int n;
            Console.WriteLine("Este anul bisect?");
            Console.WriteLine("Introduceti anul pe care doriti sa-l verificati");
            n = int.Parse(Console.ReadLine());
            if (n > 1582)
            {
                if (n % 100 == 0)
                    if (n % 400 == 0)
                        Console.WriteLine("Anul e bisect");
                    else
                        Console.WriteLine("Anul nu e bisect");
                else
                {
                    if (n % 4 == 0)
                        Console.WriteLine("Anul e bisect");
                    else
                        Console.WriteLine("Anul nu e bisect");
                }
            }
            else
                Console.WriteLine("Anul nu apartine calendarului gregorian");

        }

        public static void exercise5()
        {
            int n, k;
            Console.WriteLine("A k-a cifra a unui numar n de la dreapta la stanga");
            Console.WriteLine("Introduceti n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k");
            k = int.Parse(Console.ReadLine());
            int i = 1;
            int result = 0;

            while (i <= k)
            {
                result = n % 10;
                n /= 10;
                i++;
            }
            Console.WriteLine($"A {k}-a cifra a numarului n este {result}");
        }
        public static void exercise6()
        {
            Console.WriteLine("Pot a, b si c forma un triunghi?");
            uint a, b, c;
            Console.WriteLine("Introduceti pe cate un rand o valoare pentru a, b si c");
            a = uint.Parse(Console.ReadLine());
            b = uint.Parse(Console.ReadLine());
            c = uint.Parse(Console.ReadLine());
            if (a + b > c && b + c > a && c + a > b)
                Console.WriteLine("Aceste laturi pot forma un triunghi");
            else
                Console.WriteLine("Aceste laturi nu pot forma un triunghi");
        }
        public static void exercise7()
        {
            Console.WriteLine("Swap pe variabilele a,b");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine();
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }
        public static void exercise8()
        {
            Console.WriteLine("Swap pe variabilele a,b fara aux");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine();
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }
        public static void exercise9()
        {
            Console.WriteLine("Toti divizorii lui n");
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    Console.WriteLine($"{i} {n / i}");
            }
        }
        public static void exercise10()
        {
            Console.WriteLine("Test de primalitate");
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            bool prim = true;
            if (n == 1)
                prim = false;
            else
                if (n % 2 == 0 && n != 2)
                prim = false;
            else
                for (int k = 3; k <= Math.Sqrt(n); k += 2)
                    if (n % k == 0)
                        prim = false;

            if (prim == true)
                Console.WriteLine($"{n} este prim");
            else
                Console.WriteLine($"{n} nu este prim");
        }
        public static void exercise11()
        {
            Console.WriteLine("Cifre in oglinda");
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.Write($"{n % 10}");
                n /= 10;
            }
            Console.WriteLine();
        }
        public static void exercise12()
        {
            Console.WriteLine("Numere divizibile cu n din intervalul [a,b]");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int result = 0;
            if (a % n == 0)
                result = (b / n) - (a / n) + 1;
            else
                result = (b / n) - (a / n);
            Console.WriteLine($"Exista {result} numere divizibile cu {n} in [{a}, {b}]");
        }
        public static void exercise13()
        {
            Console.WriteLine("Anii bisecti dintr-un interval [y1,y2]");
            Console.WriteLine("Introduceti y1 si y2");
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int bisect = 0;
            if (y1 > 1582 && y2 > 1582 && y1 <= y2)
            {
                for (int i = y1; i <= y2; i++)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                            bisect++;
                    }
                    else
                        if (i % 4 == 0)
                        bisect++;
                }
                Console.WriteLine($"Sunt {bisect} ani bisecti intre {y1} si {y2}");
            }
            else
                Console.WriteLine("Intervalul nu este valid deoarece y1 si y2 nu sunt date in ordine crescatoare sau una dintre valori nu apartine calendarului gregorian");
        }
        public static void exercise14()
        {
            Console.WriteLine("Este numarul palindrom?");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int copie = n;
            int i = 0;
            while (n != 0)
            {
                i = i * 10 + n % 10;
                n /= 10;
            }
            if (i == copie)
                Console.WriteLine("n este palindrom");
            else
                Console.WriteLine("n nu este palindrom");

        }
        public static void exercise15()
        {
            Console.WriteLine("Sortare 3 numere");
            Console.WriteLine("Introduceti a b si c, fiecare pe un rand separat");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > c)
                (a, c) = (c, a);
            if (a > b)
                (a, b) = (b, a);
            if (b > c)
                (b, c) = (c, b);
            Console.WriteLine($"Numerele sortate sunt {a} {b} {c}");
        }
        public static void exercise16()
        {
            Console.WriteLine("Sortare 5 numere");
            Console.WriteLine("Introduceti cele 5 numere pe randuri separate");
            int a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            if (a > b)
                (a, b) = (b, a);
            if (a > c)
            {
                (a, c) = (c, a);
            }
            if (a > d)
            {
                (a, d) = (d, a);
            }
            if (a > e)
            {
                (a, e) = (e, a);
            }
            if (b > c)
            {
                (b, c) = (c, b);
            }
            if (b > d)
            {
                (b, d) = (d, b);
            }
            if (b > e)
                (b, e) = (e, b);
            if (c > d)
                (c, d) = (d, c);
            if (c > e)
                (c, e) = (e, c);
            Console.WriteLine($"Numerele sortate sunt {a} {b} {c} {d} {e}");
        }
        public static void exercise17()
        {
            Console.WriteLine("CMMDC cu Euclid");
            Console.WriteLine("Introduceti a si b pe linii separate");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r;
            while(b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine($"CMMDC dintre numerele date este {a}");

        }
    }
}
