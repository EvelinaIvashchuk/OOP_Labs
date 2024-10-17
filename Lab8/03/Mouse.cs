using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Mouse : Mammal
    {
        public Mouse(string name, double weight,  string LivingRegion)
            : base(name, weight, LivingRegion)
        { }

        public override string MakeSound()
        {
            return "Squeak";
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Fruit)
            {
                GetWeight += 0.10 * food.GetQuantity;
                FoodEaten += food.GetQuantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {food}!");
            }
        }

        public override string ToString()
        {
            return "Mouse " + base.ToString();
        }
    }
}
