using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Student
    {
        public string Index { get; set; }
        public int[] score { get; set; }

        public Student(string index, int[] score)
        {
            Index = index;
            this.score = score;
        }
    }
}
