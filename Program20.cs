using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program20
    {
        static void getRole(string qualification, out string eligibleRole)
        {
            switch(qualification)
            {
                case "B.Tech":
                    eligibleRole = "Programmer";
                    break;

                case "MBA":
                    eligibleRole = "Marketing";
                    break;

                case "MCA":
                    eligibleRole = "Trainer";
                    break;

                default:
                    eligibleRole = "HR";
                    break;
            }
        }

        static void Main(string[] args)
        {
            string qualification = "B.Tech";
            string eligibleRole;
            getRole(qualification, out eligibleRole);
            Console.WriteLine($"For qualification {qualification}, the eligible role is: {eligibleRole}");
        }
    }
}

/*
 out parameter is used to have a variable without initialization and changes will be effect to the original. 
commonly used in the case of initialization at the definition.
eg:
        static void Initialization(out int a)
        {
            a = 0;
        }

        static void Main(string[] args)
        {
            int a;
            Initialization(out a);
            Console.WriteLine(a);
        }
 */
