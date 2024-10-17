using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Footman : Soldier
    {
        public Footman(string name) : base(name) { }

        public override void OnKingAttacked(EventArgs args)
        {
            Console.WriteLine($"Footman {Name} in a panicking!");
        }


    }
}
