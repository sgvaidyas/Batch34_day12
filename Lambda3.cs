using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day12
{
    class Lambda3
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>() { 11, 2, 3, 56, 76, 53, 28 };
            List<int> evenlist = mylist.FindAll(x => (x % 2) == 0);

            foreach(int n in evenlist)
            {
                Console.WriteLine(n);
            }
        }
    }
}
