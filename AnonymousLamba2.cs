using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day12
{
    class AnonymousLamba2
    {
        delegate void Myfun();
        static void Main(string[] args)
        {
            Myfun ob = delegate () { Console.WriteLine("this is a demo"); };

            ob();
        }
    }
}
