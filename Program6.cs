using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program6
    {
        /*
        switch case: Used to have constant expression in the condition
        */

        static void Main(string[] args)
        {
            //Take a number as input and provide direction using switch case
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("North");
                    break;

                case 2:
                    Console.WriteLine("East");
                    break;

                case 3:
                    Console.WriteLine("West");
                    break;

                case 4:
                    Console.WriteLine("South");
                    break;

                default:
                    Console.WriteLine("Wrong number");
                    break;
            }
        }
    }
}
