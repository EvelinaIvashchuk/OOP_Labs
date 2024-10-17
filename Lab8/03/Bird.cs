using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    abstract class Bird : Animal
    {
        private double WingSize { get; set; }

        public Bird(string name, double weight, double wingSize) : base(name, weight)
        { WingSize = wingSize; }

        public override string ToString()
        {
            return base.ToString() + $", {WingSize}";
        }
    }
}
