using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program21
    {
        /*
        static void DisplayNames(params string [] names)
        {
            Console.WriteLine("Given names are: ");

            for(int i=0;i<names.Length;i++)
            {
                Console.Write($"{names[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("==================================");
        }
        static void Main(string[] args)
        {
            DisplayNames("Ramya", "Raksha");
            DisplayNames("Chaitra", "Thimmappa", "Ganapathi", "Nagarathna");
        }
        */

        /*static void DisplayNames(string batchCode, params string[] names)
        {
            Console.WriteLine($"Batch code: {batchCode}: ");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("==================================");
        }
        static void Main(string[] args)
        {
            DisplayNames("4JN17CS069","Ramya", "Raksha");
            DisplayNames("4JN17CS070","Chaitra", "Thimmappa", "Ganapathi", "Nagarathna");
        } */

        // define a method and name it addition which take any number of integer value. and display their sum

        static void addition(params int[] values)
        {
            int sum = 0;

            Console.Write($"Entered values are: ");

            for(int i=0;i<values.Length;i++)
            {
                Console.Write($"{values[i]} ");
                sum += values[i];
            }

            Console.WriteLine($"and Sum = {sum}");

            Console.WriteLine("=============================");
        }
        static void Main(string[] args)
        {
            addition(10, 20, 30);
            addition(1000, 2000);
            addition(1, 2, 3, 4, 5, 6);
        }

    }
}

/*
params: Allow to have different number of arguments to a function
can have only one params type as argument
can have another variable before to params only
 */