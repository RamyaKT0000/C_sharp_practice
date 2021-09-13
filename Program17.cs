using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program17
    {
        static void Main(string[] args)
        {
            int[][] items = new int[3][];

            items[0] = new int[] { 10, 20, 30, 40, 50 };
            items[1] = new int[] { 100, 200, 300 };
            items[2] = new int[] { 1, 2 };

            for(int i=0;i<items.Length;i++)
            {
                for(int j=0;j<items[i].Length;j++)
                {
                    Console.Write($"{items[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===================================");

            //============================================================

            string[][] batches = new string[4][];

            batches[0] = new string[] {"Ramya K T"};
            batches[1] = new string[] {"Raksha K T", "Chaitra S G"};
            batches[2] = new string[] {"Thimmappa K S", "Nagarathna Bhat", "Ganapathi Bhat"};
            batches[3] = new string[] { "Hello", "Welcome", "To", "World" };

            for (int i = 0; i < batches.Length; i++)
            {
                for (int j = 0; j < batches[i].Length; j++)
                {
                    Console.Write($"{batches[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("===================================");

        }
    }
}

/*
Jagged Array: is used to declare an array of array
Jagged array can contain different number of columns in every row.

days in a year: int[][] months = new int[4][];
months[0]= new int[31];
months[1]= new int[29];
months[2]= new int[30];
months[3]= new int[31];

scenario: students in multiple classrooms

Points to note:
This feature is available on .Net only (No other programming languages support this feature).
This is array will have different number of columns in each row.

 */