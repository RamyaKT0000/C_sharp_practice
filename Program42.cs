using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConApp01
{
    class Program42
    {
        /*
        static void Main(string[] args)
        {
            string fpath = @"E:\files_example\file_1.txt";
            StreamWriter fname = new StreamWriter(fpath);

            fname.WriteLine("Welcome to file handling....");
            fname.WriteLine("File created using C#");
            fname.WriteLine("Created by Ramya K T at " + DateTime.Now);

            Console.WriteLine("File created successfully");
            fname.Close();
        }*/

        /*
        static void Main(string[] args)
        {
            string fpath = @"E:\files_example\file_1.txt";
            StreamWriter fname = new StreamWriter(fpath,true); 
            //true is mentioned along with StreamWriter which will retain all the previous content as it is 

            fname.WriteLine("==========================================");
            fname.WriteLine("Welcome to the world...");
            fname.WriteLine("File created using C#");
            fname.WriteLine("Created by Ramya K T at " + DateTime.Now);

            Console.WriteLine("File created successfully");
            fname.Close();
        }*/

        static void Main(string[] args)
        {
            string fpath = @"E:\files_example\file_1.txt";
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(fpath);

                string fileContent = sr.ReadToEnd();
                Console.WriteLine(fileContent);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File no found " + ex.Message);
            }

            sr.Close();

        }
    }
}
/*
IO stands for Input and Output

.NET provided an API containing built in classes to handle a files,  namespace is System.IO
File Handling:    This is the feature used to handle files like Write data, read data, delete file, 
edit file content, etc..,

To create Object:

StreamWriter obj = new StreamWrite("filename");

Note: The above system will create a new file, overwrite if file already exist

StreamWriter obj = new StreamWrite("filename",true);

By providing true as second parameter, the data will into the content

*/
