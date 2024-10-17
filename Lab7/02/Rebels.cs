using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            food = 0;
        }

        public void BuyFood()
        {
            food += 5;
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
