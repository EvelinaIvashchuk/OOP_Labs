using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    abstract class Mammal : Animal
    {
        private string LivingRegion { get; set; }

        public Mammal(string name, double weight, string LivingRegion) 
            : base(name, weight)
        { this.LivingRegion = LivingRegion; }

        public override string ToString()
        {
            return base.ToString() + ", " + LivingRegion;
        }

    }
}
