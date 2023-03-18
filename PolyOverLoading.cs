using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class PolyOverLoading
    {
        public void add(int x)
        {
            Console.WriteLine(x);
        }

        public void add(double x,int  y) 
        {
           Console.WriteLine(x+y);
        }

        public void add(int x,double y)
        {
            Console.WriteLine(x+y);
        }

        public void add(double x, double y)
        {
            Console.WriteLine(x+y);
        }
    }
}
