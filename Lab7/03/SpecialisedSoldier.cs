using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class SpecialisedSoldier : Soldier, ISpecialisedSoldier
    {
        public string Corps { get; set; }
        private double Salary;
        protected SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName)
        {
            Corps = corps;
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {Salary} \nCorps: {Corps}";
        }
    }
}
