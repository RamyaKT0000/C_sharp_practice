using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program9
    {
        /*
        enum: enumerated type, used to have set of constants
        example: Gender, Martial status, Direction, etc
        */
        enum Martial_status
        {
            Married, UnMarried, Divorced
        }

        static void Main(string[] args)
        {
            Martial_status p1 = Martial_status.Married;
            if (p1 == Martial_status.Married)
            {
                Console.WriteLine("You can leave office at 7PM...!");
            }
            else if (p1 == Martial_status.UnMarried)
            {
                Console.WriteLine("You can leave office at 8PM...!");
            }
            else
            {
                Console.WriteLine("You can Leave office at any time...!");
            }
        }
    }
}
