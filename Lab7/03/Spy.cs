using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Spy : Soldier, ISpy
    {
        public int SpyNumber { get; set; }

        public Spy(int id, string firstName, string lastName, int spyNumber)
            : base(id, firstName, lastName)
        {
            SpyNumber = spyNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $"Spy number: {SpyNumber}";
        }
    }
}
