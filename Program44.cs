using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program44
    {
        static void Main(string[] args)
        {
            string fname= @"E:\files_example\file_1.txt";

            //Total file path:
            Console.WriteLine("Path = " + Path.GetDirectoryName(fname));

            //File path with filename
            Console.WriteLine("Path = " + Path.GetFullPath(fname));

            //Return extension of path file
            Console.WriteLine("Extension of path = " + Path.GetExtension(fname));

            //Return filename with path
            Console.WriteLine("Filename of Path = " + Path.GetFileName(fname));
        }
    }
}
