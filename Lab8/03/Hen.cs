using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override string MakeSound()
        {
            return "Cluck";
        }

        public override void Eat(Food food)
        {
            GetWeight += 0.25 * food.GetQuantity;
            FoodEaten += food.GetQuantity;
        }

        public override string ToString()
        {
            return "Hen " + base.ToString();
        }

    }
}
