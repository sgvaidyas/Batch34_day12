using System;
using System.Collections.Generic;
using System.Linq;

namespace Batch34_day12
{
    class StudentInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Lambda4
    {
        static void Main(string[] args)
        {
            List<StudentInfo> mystud = new List<StudentInfo>();
            int ch;
            do
            {
                StudentInfo ob = new StudentInfo();
                Console.WriteLine("Enter name & age");
                ob.Name = Console.ReadLine();
                ob.Age = int.Parse(Console.ReadLine());
                mystud.Add(ob);
                Console.WriteLine("Press 1 to add more");
                ch = int.Parse(Console.ReadLine());
            } while (ch==1);

            Console.WriteLine("\nthe records");
            foreach( StudentInfo s in mystud)
                Console.WriteLine(s.Name +"  :  "+s.Age);

            List<StudentInfo> stud_list = mystud.FindAll(x=>x.Age>50);
            Console.WriteLine("\nthe records age> 50");
            foreach (StudentInfo s in stud_list)
                Console.WriteLine(s.Name + "  :  " + s.Age);

            List<StudentInfo> names = mystud.FindAll(x => (x.Name.ToString().EndsWith("s")));

            /*
             * 
             * 
            List<string> mystring = new List<string>() { "aaa", "ggg", "dddd" };
            mystring.Sort();
            foreach (string s in mystring)
                Console.WriteLine(s);

             * 
             * */

            Console.WriteLine("\nsorted of mystud based on age");
            mystud.Sort(
                delegate(StudentInfo p1,StudentInfo p2)
                {
                    if (p1.Age < p2.Age)
                        return -1;
                    else
                        return 1;
                }     
                );
            Console.WriteLine("\nthe ");
            foreach (StudentInfo s in mystud)
                Console.WriteLine(s.Name + "  :  " + s.Age);

            List<string> names1 = mystud.Select(x => x.Name).ToList();
            foreach(string n in names1)
                Console.WriteLine(n);
        }
    }
}
