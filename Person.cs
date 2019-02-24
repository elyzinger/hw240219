using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person 
{
    class Person : IComparable<Person>
    {
        public int ID { get;private set; }
        public int Age { get; private set; }
        public double Height { get; private set; }
        public string Name { get; private set; }
        public Person(int id, int age, double height, string name)
        {
            this.ID = id;
            this.Age = age;
            this.Height = height;
            this.Name = name;
        }
        private static readonly IComparer<Person> idComparer;
        private static readonly IComparer<Person> ageComparer;
        private static readonly IComparer<Person> heightComparer;
        private static readonly IComparer<Person> nameComparer;
        public static IComparer<Person> NameComparer { get
            {
                return new CompareByName();
                    }
        }
        public static IComparer<Person> IDComparer
        {
            get
            {
                return new CompareByID();
            }
        }
        public static IComparer<Person> AgeComparer
        {
            get
            {
                return new CompareByAge();
            }
        }
        public static IComparer<Person> HeightComparer
        {
            get
            {
                return new CompareByHeight();
            }
        }
        static Person()
        {
           CompareByName = new CompareByName();
           CompareByID  = new CompareByID();
            AgeComparer = new CompareByAge();
        }
        public override string ToString()
        {
            return $"id: {ID} age: {Age} height: {Height} name: {Name}";
        }

        public int CompareTo(Person other)
        {
            return this.ID - other.ID;
        }
    }
}
