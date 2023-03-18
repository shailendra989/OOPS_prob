using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class VariableTypes
    {
        public void showVarTypes()
        {
            int age = 25;
            Console.WriteLine("Age: " + age);

            float salary = 5000.50f;
            Console.WriteLine("Salary: " + salary);

            bool isEmployed = true;
            Console.WriteLine("Employed: " + isEmployed);

            char gender = 'M';
            Console.WriteLine("Gender: " + gender);

            string name = "John Doe";
            Console.WriteLine("Name: " + name);

            object obj = age;
            Console.WriteLine("Object: " + obj);

            Console.ReadLine();
        }
    }
}
