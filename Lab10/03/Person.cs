using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            var comparison = name.CompareTo(other.name);
            if (comparison != 0)
            {
                return comparison;
            }

            comparison = age.CompareTo(other.age);
            if (comparison != 0)
            {
                return comparison;
            }

            return town.CompareTo(other.town);
        }
    }
}
