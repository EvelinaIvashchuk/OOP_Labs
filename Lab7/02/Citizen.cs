using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Citizen : IBuyer
    {
        private string name;
        private int age;
        private string ID;
        private int years;
        private int food;
        public Citizen(string  name, int age, string ID, int years)
        {
            this.name = name;
            this.age = age;
            this.ID = ID;
            this.years = years;
            food = 0;
        }

        public Citizen(string name, int age, string ID)
        {
            this.name = name;
            this.age = age;
            this.ID = ID;
        }

        public void BuyFood()
        {
            food += 10;
        }

        public int Food
        {
            get { return food; }
            set { food = value; }
        }

        public string Name
        { get { return name; } set { name = value; } }

    }

}
