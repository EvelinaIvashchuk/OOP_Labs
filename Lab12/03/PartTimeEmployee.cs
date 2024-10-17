using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class PartTimeEmployee : IEmployee
    {
        public const int WorkHoursPerWeekConst = 20;
        public PartTimeEmployee(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public int WorkHoursPerWeek
        {
            get { return WorkHoursPerWeekConst; }
        }
    }
}
