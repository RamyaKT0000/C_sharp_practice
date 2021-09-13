using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program14
    {
        static void Main(string[] args)
        {
            //Generate numbers using While loop
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine($"{i}");
                i++;
            }

            Console.WriteLine("=========================");

            //Generate numbers using do..while loop
            i = 1;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            } while (i <= 10);

            Console.WriteLine("=========================");
        }
    }
}
