using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] x = new string[4] {"guy", "danny", "gal", "ely",};
            Console.WriteLine(x[1]);
            Array.Sort(x);
            PrintX(x);
            Person[] people = new Person[]
            {
                new Person(3215, 32, 1.8, "berry"),
                new Person(3452, 14, 1.4, "bonny"),
                new Person(8765, 15, 1.6, "james"),
                new Person(1234, 75, 1.5, "linda"),
                new Person(2314, 24, 1.6, "sara"),
            };
            CompareByAge compareByAge = new CompareByAge();
            CompareByName namecompare = new CompareByName();
            Array.Sort(people, namecompare);
            PrintPersonArray(people);
            
        }
        static void PrintX(string[] d)
        {
            foreach (string x in d)
            {
                Console.WriteLine(x);
            }
        }
        static void PrintPersonArray(Person[] people)
        {
            foreach(Person x in people)
            {
                Console.WriteLine(x);
            }
        }
    }
}
