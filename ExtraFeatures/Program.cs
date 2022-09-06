using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace ExtraFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string newString = "Hello World!";
            Console.WriteLine(newString);

            var myList = new List<string> { "HTML", "CSS", "C#", "JavaScript", "React", "jQuery" };

            foreach (string item in myList)
            {
                Console.Write(item + " ");
            }

            var person1 = new Person("Adam");
            Console.WriteLine($"\nName: {person1.Name}, Address: {person1.Address} ");

        }


    }
    class Person
    {
        public Person(string name) : this(name, "No address")
        {
        }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }

    }
}
