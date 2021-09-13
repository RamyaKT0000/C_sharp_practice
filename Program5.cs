using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 5th program");

            /*
            Task: Generate electricity bill
            Input: lmr, pmr
            calculate bu=pmr-lmr
            calculate UR
            BU     UR
            <150   1.75
            <375   3.25
            <500   5
            >=500  6.5
            calculate amout and display
            */

            Console.WriteLine("Enter the lmr value: ");
            int lmr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the pmr value: ");
            int pmr = Convert.ToInt32(Console.ReadLine());

            int BU = pmr - lmr;

            double UR = 0;

            if (BU < 150)
                UR = 1.75;
            else if (BU < 375)
                UR = 3.25;
            else if (BU < 500)
                UR = 5;
            else
                UR = 6.5;

            Console.WriteLine($"Unit Rate is: {UR}");

            double amt = BU * UR;

            Console.WriteLine($"Total Amount is: {amt}");
        }
    }
}
