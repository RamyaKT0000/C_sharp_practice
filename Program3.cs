using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 3rd program");

            /*
            character refers to any letter including alphabet, digit, special letters
                ASCII value for every letter
                A - Z   are 65 to 90
                a - z are 97 to 122
                0 - 9  are 48 to 57 
            */

            //Read a character and display its previous and forward character
            Console.WriteLine("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Entered character is: {ch}");
            Console.WriteLine($"Next Letter of {ch} is {(char)(ch+1)}");
            Console.WriteLine($"Previous Letter of {ch} is {(char)(ch-1)}");

            //determine which type of character it is
            if (ch >= 65 && ch <= 90)
                Console.WriteLine($"{ch} is Capital Letter alphabet.");
            else if (ch >= 97 && ch <= 122)
                Console.WriteLine($"{ch} is Small Letter alphabet");
            else if (ch >= 48 && ch <= 57)
                Console.WriteLine($"{ch} is digit");
            else
                Console.WriteLine($"{ch} is special character");

        }
    }
}
