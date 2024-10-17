using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Dog : Mammal
    {
        public Dog(string name, double weight, string LivingRegion)
            : base(name, weight,  LivingRegion)
        { }

        public override string MakeSound()
        {
            return "Woof!";
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                GetWeight += 0.40 * food.GetQuantity;
                FoodEaten += food.GetQuantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat  {food}!");
            }
        }

        public override string ToString()
        {
            return "Dog " + base.ToString();
        }
    }
}
