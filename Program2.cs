using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program2
    {
        /*
        Naming convention: While writing programmable code, have to follow naming convetion to identify the code
            ClassName, MethodName or any TypeName should be in PascalCase (1st letter of every word must be capital)
            keywords will be in lower case
            containts will be in UPPER CASE
v           ariable names will be camelCaseNotation (1st letter from 2nd word must be capital)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 2nd program");

            //Read full name and display as "full name, first name, last name in seperate object
            Console.WriteLine("Enter your Full Name");
            string fullName = Console.ReadLine();

            string firstName = fullName.Substring(0, fullName.IndexOf(" "));
            string lastName = fullName.Substring(fullName.IndexOf(" ") + 1);

            Console.WriteLine($"Hello, {fullName}");
            Console.WriteLine($"Your First Name is : {firstName}");
            Console.WriteLine($"Your Last Name is : {lastName}");
        }
    }
}
