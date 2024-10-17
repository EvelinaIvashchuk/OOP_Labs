using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03
{
    abstract class Animal
    {
        private string Name { get; set; }
        private double Weight { get; set; }
        public int FoodEaten { get; set; }

        public Animal(string name, double weight)
        {
            Name = name;
            GetWeight = weight;
        }

        public double GetWeight
        {
            get { return Weight; } set { Weight = value; } 
        }

        public abstract string MakeSound();
        public abstract void Eat(Food food);

        public override string ToString()
        {
            return $"{Name}, {GetWeight}, {FoodEaten}";
        }

    }
}
