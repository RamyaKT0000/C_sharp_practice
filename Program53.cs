using System;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    public static class StringExtensioMethods
    {
        public static string Upper(this string name)
        {
            return name.ToUpper();
        }

        public static string Firstname(this string fullname)
        {
            return fullname.Substring(0, fullname.IndexOf(" "));
        }

        public static string LastName(this string fullname)
        {
            return fullname.Substring(fullname.IndexOf(" ") + 1);
        }
    }

    class Program53
    {
        static void Main(string[] args)
        {
            string fullname = "Ramya K T";
            Console.WriteLine(fullname);
            Console.WriteLine(fullname.Upper());
            Console.WriteLine(fullname.Firstname());
            Console.WriteLine(fullname.LastName());
        }
    }
}
