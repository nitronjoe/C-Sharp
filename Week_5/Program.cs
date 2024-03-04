using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a person with the default constructor
            Person person1 = new Person();
            Console.WriteLine("Person 1:");
            //Console.WriteLine(person1.Output());
            Console.WriteLine(person1.ToString());
            Console.WriteLine();

            // Create a person with specified first and last name
            Person person2 = new Person("Joe", "Thompson");
            Console.WriteLine("Person 2:");
            //Console.WriteLine(person2.Output());
            Console.WriteLine(person2.ToString());
            Console.WriteLine();

            // Create a person object with specified values for all fields
            Person person3 = new Person("Joe", "Thompson", "27517493@students.lincoln.ac.uk");
            Console.WriteLine("Person 3:");
            //Console.WriteLine(person3.Output());
            Console.WriteLine(person3.ToString());
            Console.WriteLine();

            Person person4 = new Person("Joe", "Thompson", "27517493@students.lincoln.ac.uk");
            Console.WriteLine("Person 4:");
            string personInfo = person4.Output();
            // Write person info to the console
            Print.Write(personInfo);

            // Write person info to the file
            Print.WriteToFile(personInfo);

            Console.ReadKey();
        }
    }
}
