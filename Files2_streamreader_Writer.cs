using System;
using System.Collections.Generic;
using System.IO;

namespace Batch34_day12
{
    class Files2_streamreader_Writer
    {
        static void Main(string[] args)
        {
            string filename = @"D:\myfiles\secondfile.txt";
            //writing!!!!!!!!!!
            FileStream fp = new FileStream(filename, FileMode.Create);
            StreamWriter sw = new StreamWriter(fp);

            sw.WriteLine(" hey this is the first line");
            sw.WriteLine("this is second");
            sw.WriteLine("third line");

            sw.Close();
            fp.Close();
            Console.WriteLine("You created a file");

            //reading
            FileStream fp1 = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fp1);

            string line;
            Console.WriteLine("\n\n the file read");
            while((line=sr.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }

            sr.Close();
            fp1.Close();

        }
    }
}
