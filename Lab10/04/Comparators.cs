using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class PersonAgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }

    class PersonNameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length < y.Name.Length)
                return -1; 
            if (x.Name.Length > y.Name.Length)
                return 1;

            char firstCharX = char.ToLower(x.Name[0]);
            char firstCharY = char.ToLower(y.Name[0]);

            if (firstCharX < firstCharY)
                return -1; 
            if (firstCharX > firstCharY)
                return 1;

            return 0;
        }
    }
}

