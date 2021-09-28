using System;
using System.Collections.Generic;
using System.IO;

namespace Batch34_day12
{
    class Studentfile
    {
        public static string filename = @"D:\myfiles\student_records.txt";

        static void insertrecord()
        {
             //writing!!!!!!!!!!
            StreamWriter sw = new StreamWriter(filename,true);
            
            int ch;
            do
            {
                StudentInfo ob = new StudentInfo();
                Console.WriteLine("Enter name & age");
                ob.Name = Console.ReadLine();
                ob.Age = int.Parse(Console.ReadLine());
                sw.WriteLine(ob.Name.PadRight(40) + " | " + ob.Age.ToString().PadRight(5));
                Console.WriteLine("Press 1 to add more");
                ch = int.Parse(Console.ReadLine());
            } while (ch == 1);
                                 
            sw.Close();
            Console.WriteLine("Student records updated");
        }
        static void displayallrecords()
        {
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
        static void searchrecord()
        {
            FileStream fp1 = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fp1);
            int ch;
            string name, age,line;
            Console.WriteLine("1 Search by name 2 Search by Age 3 Exit");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the name of the student");
                    name = Console.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(name))
                            Console.WriteLine(line);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the age of the student");
                    age = Console.ReadLine();
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(age))
                        {
                           // Console.WriteLine("line = "+line);
                            string line_age = line.Substring(43).Trim();
                            if (age.Trim().Equals(line_age))
                                Console.WriteLine(line);
                        }
                    }
                    break;
                case 3: break;
                default: Console.WriteLine("invalid");break;
            }
            sr.Close();
            fp1.Close();
        }



        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.WriteLine("1 Insert records");
                Console.WriteLine("2 Display all records");
                Console.WriteLine("3 Search Record");
                Console.WriteLine("4 Exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: insertrecord(); break;
                    case 2: displayallrecords(); break;
                    case 3: searchrecord(); break;
                    case 4: break;
                    default: Console.WriteLine("invalid selection");break;
                }
            } while (ch != 4);
        }
    }
}
