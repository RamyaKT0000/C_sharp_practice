using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate 1 to 10 using while loop...");
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine($"{i}");
                i++;
            }

            Console.WriteLine("===============================");

            Console.WriteLine("Generate 1 to 10 using for loop...");
            for(i=1; i<=10; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("===============================");

            Console.WriteLine("Generate 1 to 10 using do..while loop...");
            i = 1;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            } while (i <= 10);

            Console.WriteLine("===============================");

        }
    }
}

/*
 loop: is an iteration control structure, used to repeat statement execution. and C# supports 3 loops:

1: while loop: Entry Control loop with infinite iteration.(pre tested conditions) -- will never moves inside loop if condition 
    is not satisfied.

2. for loop: Entry control loop with finite iteration. (Post tested conditions) -- will move inside the loop and print output 
    atleast once though the conditions are not met. Bcoz it will check condition later.

3. do..while loop: Exit control loop with infinite iteration.
 */