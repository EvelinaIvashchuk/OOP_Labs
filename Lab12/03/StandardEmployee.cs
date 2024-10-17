using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class StandardEmployee : IEmployee
    {
        public const int WorkHoursPerWeekConst = 40;
        public StandardEmployee(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public int WorkHoursPerWeek
        {
            get { return WorkHoursPerWeekConst; }
        }
    }
}
