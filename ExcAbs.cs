using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    abstract class ExcAbs
    {
        public abstract int area();
    }
    class Square : ExcAbs
    {
        
        public override int area()
        {
            Console.WriteLine("area of the square");
            return 0;
        }
    }
    
}
