using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Private : Soldier, IPrivate
    {
        public double Salary { get; set; }
        public int ID { get; set; }

        public Private(int id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
        {
            Salary = salary * 2;
            this.ID = id;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {Salary}";
        }

    }
}
