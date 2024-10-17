using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string LivingRegion)
            : base(name, weight, LivingRegion)
        { }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
