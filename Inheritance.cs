using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    
       public  class Vehicle
        {
            public string brand = "tata";
            public void honk()
            {
                Console.WriteLine("Tuut, tuut!");
            }



        }
       public  class Car : Vehicle
       {
        public string modelName = "safari";
        }


}
