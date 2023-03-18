using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
        public  class PolyOverriding
        {
           public  virtual void Run()
            {
            Console.WriteLine("Running");
            }

           
        }
    class Over : PolyOverriding
    {
        public override void Run()
        {
            Console.WriteLine("slowly running");
        }
    }
}
