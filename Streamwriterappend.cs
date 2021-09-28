using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day12
{
    class Streamwriterappend
    {
        static void Main(string[] args)
        {
            string filename = @"D:\myfiles\thirdfile.txt";
            //writing!!!!!!!!!!
            StreamWriter sw = new StreamWriter(filename,true);//append

            Console.WriteLine("Enter something : ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
         
            sw.Close();
            Console.WriteLine("You created a file");

            //reading
            FileStream fp1 = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fp1);

            string line;
            Console.WriteLine("\n\n the file read");
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            sr.Close();
            fp1.Close();

        }
    }
}
