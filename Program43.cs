using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program43
    {
        static void Main(string[] args)
        {
            string fpath = @"E:\files_example\file_1.txt";
            FileStream fname = new FileStream(fpath, FileMode.Append, FileAccess.Write);
        
            StreamWriter sw = new StreamWriter(fname);

            sw.WriteLine("Added at Eof at " + DateTime.Now);

            sw.Close();
        }
    }
}

/*
File Stream: The object of this class, used to read or write append the file content
 */