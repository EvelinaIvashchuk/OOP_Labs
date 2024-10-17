using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Student
    {
        public string Name { get; set; }
        public string NumberOfFaculty { get; set; }

        public Student(string name, string numberOfFaculty)
        {
            Name = name;
            NumberOfFaculty = numberOfFaculty;
        }
    }
}
