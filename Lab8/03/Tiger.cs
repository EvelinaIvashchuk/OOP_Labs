using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Tiger : Feline
    {
        private string Breed { get; set; }

        public Tiger(string name, double weight, string LivingRegion, string Breed)
            : base(name, weight, LivingRegion)
        {
            this.Breed = Breed;
        }

        public override string MakeSound()
        {
            return "ROAH!!!";
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                GetWeight += 1.00 * food.GetQuantity;
                FoodEaten += food.GetQuantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat  {food}!");
            }
        }

        public override string ToString()
        {
            return "Tiger " + base.ToString();
        }
    }
}
