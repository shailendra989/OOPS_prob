using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    
    
    internal class ObjectAndClass
    {
        static void CreateObject(string[] args)
        {
            Person person1 = new Person("John", "Doe");
            person1.SayHello();
            person1.Introduce();
            Console.ReadLine();
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}.", FirstName, LastName);
        }
    }
}




