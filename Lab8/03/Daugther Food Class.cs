using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Vegetable : Food
    {
        public Vegetable(int quantity) : base(quantity) { }
        public Vegetable() { }
    }

    class Fruit : Food
    {
        public Fruit(int quantity) : base(quantity) { }
        public Fruit() { }
    }

    class Meat : Food
    {
        public Meat(int quantity) : base(quantity) { }
        public Meat() { }
    }

    class Seeds : Food
    {
        public Seeds(int quantity) : base(quantity) { }
        public Seeds() { }
    }
}
