using System;
using System.Collections.Generic;
using System.IO;

namespace Batch34_day12
{
    class Files1
    {
        static void Main(string[] args)
        {
            string filename = @"D:\myfiles\firstfile.txt";
            //writing
            FileStream f = new FileStream(filename, FileMode.OpenOrCreate);

            for (byte i = 1; i < 255; i++)
            {
                f.WriteByte(i);
            }
            f.Close();
            //reading
            FileStream read = new FileStream(filename, FileMode.Open);

            int j = 0;
            while((j=read.ReadByte())!=-1)
            {
                Console.WriteLine(j + " = " +(char)j);
            }

            read.Close();

        }
    }
}
