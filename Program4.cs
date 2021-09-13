using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program4
    {

        /*
        Control Structure: used to control statement execution.
        if: used as branching
        case: used for constant expression in the condition
        loop: to iterate statements

        relational operators: >, >=, <, <=, ==, !=
        logical operators: &&, ||, !
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 4th program");

            //check the given number is zero or not
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num == 0)
                Console.WriteLine($"Entered number {num} is '0'");
            else
                Console.WriteLine($"Entered number {num} is not '0'");

            //========================================================================================

            //Read marks and check the value is valid or not
            Console.WriteLine("Enter marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if(marks >= 35 && marks <= 100)
                Console.WriteLine($"Input mark {marks} is valid");
            else
                Console.WriteLine($"Input mark {marks} is not valid");

            //========================================================================================

            //Read 3 subject marks into 3 variables and display total, average, result and grade
            Console.WriteLine("Enter 3 subject marks: ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            int sub2 = Convert.ToInt32(Console.ReadLine());
            int sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Entered marks are: {sub1}, {sub2}, {sub3}");

            int total = sub1 + sub2 + sub3;
            double average = (double) total / 3;

            Console.WriteLine($"Total marks of entered 3 subject marks is: {total}");
            Console.WriteLine($"Average of entered 3 subject marks is: {average}");

            string result = string.Empty;
            string grade = string.Empty;

            if(sub1 >= 35 && sub2 >=35 && sub3 >= 35)
            {
                result = "PASS";
                if (average >= 75)
                    grade = "A1";
                else if (average >= 60)
                    grade = "A";
                else if (average >= 50)
                    grade = "B";
                else
                    grade = "C";
            }
            else
            {
                result = "FAIL";
                grade = "Cannot be assigned";
            }

            Console.WriteLine($"Result is: {result}");
            Console.WriteLine($"Grade is: {grade}");
        }
    }
}
