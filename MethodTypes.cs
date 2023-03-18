using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class MethodTypes   
    {
        static void showMethodType()
        {
            // Static method
            int result1 = Math.Abs(-10);
            Console.WriteLine("Absolute value: " + result1);

            // object method
            string message = "hello world";
            int result2 = message.IndexOf("world");
            Console.WriteLine("Index of 'world': " + result2);

            // Parameterized method
            double result3 = CalculateSquare(5.0);
            Console.WriteLine("Square of 5.0: " + result3);

            // Method with return value
            string fullName = GetFullName("John", "Doe");
            Console.WriteLine("Full name: " + fullName);

            Console.ReadLine();
        }

        // Parameterized method to calculate square
        static double CalculateSquare(double num)
        {
            return num * num;
        }

        // Method with return value to concatenate first and last name
        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
