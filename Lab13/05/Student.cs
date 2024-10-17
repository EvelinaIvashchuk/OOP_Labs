using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Student(string firstName, string lastname, string email)
        {
            FirstName = firstName;
            LastName = lastname;
            Email = email;
        }
    }
}
