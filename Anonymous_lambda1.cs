using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day12
{
    class Anonymous_lambda1
    {
        delegate int Myfun1(int num);
        delegate int Myfun(int x,int y);
        static void Main(string[] args)
        {
            Myfun1 ob = x => x * x * x;
            int myval = ob(4);
            Console.WriteLine("Cube  = "+myval);

            Myfun add = (x,y)=>x + y;
            int sum = add(22,11);
            Console.WriteLine("Sum = "+sum);

            Myfun1 ob2 = x => x + 100;
            Console.WriteLine(ob2(88));

            Myfun add2 = (x, y) => x + 100 + y;
            Console.WriteLine(add2(22,6));
        }
    }
}
