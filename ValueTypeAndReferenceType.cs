using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class ValueTypeAndReferenceType
    {
        public static void show()
        {
            int a = 5;
            int b = a;
            b = 10;
            Console.WriteLine($"a: {a}"); 
            Console.WriteLine($"b: {b}"); 

            // Example of a reference type
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 4;
            Console.WriteLine($"arr1[0]: {arr1[0]}"); 
            Console.WriteLine($"arr2[0]: {arr2[0]}"); 


        }

        

  
}
