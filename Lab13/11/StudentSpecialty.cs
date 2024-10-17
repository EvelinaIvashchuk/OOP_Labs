using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class StudentSpecialty
    {
        public string SpecialtyName { get; set; }
        public string NumberOfFaculty {  get; set; }

        public StudentSpecialty(string s, string n)
        {
            SpecialtyName = s;
            NumberOfFaculty = n;
        }

    }
}
