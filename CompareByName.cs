using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class CompareByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
    class CompareByID : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.ID - y.ID;
        }
    }
    class CompareByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
    class CompareByHeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Height > y.Height)
            {
                return 1;
            }
            else if (x.Height == y.Height)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
