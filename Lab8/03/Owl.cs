using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight,  wingSize)
        {

        }

        public override string MakeSound()
        {
            return "Hoot Hoot";
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                GetWeight += 0.25 * food.GetQuantity;
                FoodEaten += food.GetQuantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {food}!");
            }
        }


        public override string ToString()
        {
            return "Owl " + base.ToString();
        }
    }
}
