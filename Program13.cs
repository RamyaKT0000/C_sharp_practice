using System;
using System.Threading;

namespace ConApp01
{
    class Program13
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine($"{i} {11-i}");
                Thread.Sleep(1000);
                i++;
            }

            /* display following series:
               1, 3, 5, 7, 9
               2, 4, 6, 8, 10
               5, 4, 3, 2, 1
            */

            i = 1;
            while(i<=10)
            {
                Console.Write($"{i}, ");
                Thread.Sleep(1000);
                i = i+2;
            }

            Console.WriteLine("\n");

            i = 2;
            while(i <= 10)
            {
                Console.Write($"{i}, ");
                Thread.Sleep(1000);
                i = i + 2;
            }

            Console.WriteLine("\n");

            i = 5;
            while(i>=1)
            {
                Console.Write($"{i}, ");
                Thread.Sleep(1000);
                i = i - 1;
            }

            Console.WriteLine("\n");

            //Generate Fibonacci Series: 1 1 2 3 5 8 ....

            int a = 0, b = 1;
            int c = 0;

            Console.Write($"{a} {b} ");

            i = 2;

            while(i < 10)
            {
                c = a + b;
                Console.Write($"{i} ");
                a = b;
                b = c;
                i++;
            }

            Console.WriteLine("\n");

            //Generate multiplication table

            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            i = 1;
            while(i<=10)
            {
                Console.WriteLine($"{n} x {i} = {n*i}");
                i++;
            }

        }
    }
}
