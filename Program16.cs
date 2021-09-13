using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program16
    {
        static void Main(string[] args)
        {
            //2 dimensional array
            int[,] items = new int[2, 2];

            items[0, 0] = 1000;
            items[0, 1] = 2000;
            items[1, 0] = 3000;
            items[1, 1] = 4000;

            Console.WriteLine($"{items[0, 0]}");
            Console.WriteLine($"{items[0, 1]}");
            Console.WriteLine($"{items[1, 0]}");
            Console.WriteLine($"{items[1, 1]}");

            Console.WriteLine("===================================");

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write($"{items[i,j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===================================");

            //=============================

            int[,] values = new int[2, 3] { {100, 200, 300 }, { 400, 500, 600 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{values[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===================================");

        }
    }
}
