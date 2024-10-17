using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Cat : Feline
    {
        private string Breed { get; set; }

        public Cat(string name, double weight, string LivingRegion, string Breed)
            : base(name, weight, LivingRegion)
        {
            this.Breed = Breed;
        }

        public override string MakeSound()
        {
            return "MEOW!";
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                GetWeight += 0.30 * food.GetQuantity;
                FoodEaten += food.GetQuantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {food}!");
            }
        }

        public override string ToString()
        {
            return "Cat " + base.ToString();
        }
    }
}
