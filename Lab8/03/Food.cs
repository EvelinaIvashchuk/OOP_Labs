using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    abstract class Food
    {
        private int Quantity { get; set; }

        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int GetQuantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public Food() { }

    }

    
}
