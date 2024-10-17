using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Repair
    {
        private string PartName { get; set; }
        private int HoursWorked { get; set; }

        public Repair(string PartName, int hoursWorked)
        {
            this.PartName = PartName;
            HoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return $"    Part name: {PartName}; Hours worked: {HoursWorked}";
        }

    }
}
