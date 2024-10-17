using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }

        public Person(string firstName, string lastName, string group)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
        }
    }
}
