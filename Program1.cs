//Basic structures:

using System;

namespace ConApp01
{
    class Program1
    {
        static void Main(string[] args)
        {
            //displaying output to the screen
            Console.WriteLine("Hello World!");

            //declaring variable
            string name;

            //initializing variable
            name = "Ramya K T";
            
            //templating literal: provide variable value content within message -- use $ before message -- use {variable name}
            Console.WriteLine($"Hello {name}");

            // --> single line comment
            /* -------- multi line comment ----------- */

            //str.Length -- to find length of particular string
            Console.WriteLine($"Length of string name is : {name.Length}");

            //str.ToUpper() -- to convert string to upper case
            Console.WriteLine($"After converting {name} to upper case : {name.ToUpper()}");

            //str.ToLower() -- to convert string to lower case
            Console.WriteLine($"After converting {name} to lower case : {name.ToLower()}");

            // to get the position of 1st occurence of the character
            Console.WriteLine($"The index of a in {name} is: {name.IndexOf("a")}");

            //to get the position of last occurence of the character
            Console.WriteLine($"The last index of a in {name} is : {name.LastIndexOf("a")}");

            // return 3 characters from 0th position -- str.Substring(start, number of character)
            Console.WriteLine($"The substring is: {name.Substring(0,3)}");

            //return 5 characters from 2nd position
            Console.WriteLine($"The substring is: {name.Substring(2, 5)}");

            //display full name excluding 1st letter -- str.Substring(start)
            Console.WriteLine($"The full name excluding 1st letter : {name.Substring(1)}");

            //display full name excluding last letter
            Console.WriteLine($"The full name excluding last letter: {name.Substring(0, name.Length-1)}");

            //display 1st name in full name
            Console.WriteLine( $"The 1st name in full name is: {name.Substring(0, name.IndexOf(" "))}");

            //display last name in full name
            Console.WriteLine($"The last name in full name is: {name.Substring(name.LastIndexOf(" ")+1)}");

            //data types -- variable.GetType() -- returns type of data variable (int, float, char, etc)
            /* data types are:
                string
                int
                float
                char
                bool
                double
            */

            Console.WriteLine($"The value of string is : {name} and is of {name.GetType()} type");

            int v1 = 100;
            Console.WriteLine($"The value of integer is: {v1} and is of {v1.GetType()} type");

            char ch = 'z';
            Console.WriteLine($"The value of character is: {ch} and is of {ch.GetType()} type");

            double v2 = 5.29;
            Console.WriteLine($"The value of double is {v2} and is of {v2.GetType()} type");

            bool val = true;
            Console.WriteLine($"The value of boolean is {val} and is of {val.GetType()} type");

            //Take input from user:
            Console.WriteLine($"Hello {name}! How are you?");
            Console.ReadLine();
            Console.WriteLine("Good");

            //Take string input from user
            Console.WriteLine("Enter your date of birth: ");
            string DOB = Console.ReadLine();
            Console.WriteLine($"Hello {name} and your dob is {DOB}");

            //Taking int input from user
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Entered number is: {n}");
            Console.WriteLine($"Next number is : {n+1}");
            Console.WriteLine($"Square of number is: {n*n}");
            Console.WriteLine($"Cube of number is: {n*n*n}");

            //Mathematical operations
            Console.WriteLine("Enter 1st number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a = {n1} and b = {n2}");
            Console.WriteLine($"Addition of {n1} and {n2} is: {n1+n2}");
            Console.WriteLine($"Subtraction of {n1} and {n2} is: {n1-n2}");
            Console.WriteLine($"Multiplication of {n1} and {n2} is: {n1*n2}");
            Console.WriteLine($"Division of {n1} and {n2} is: {n1/n2}");
            Console.WriteLine($"Modulus of {n1} and {n2} is: {n1%n2}");
        }
    }
}
