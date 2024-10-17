using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class RoyalGuard : Soldier
    {
        public RoyalGuard(string name) : base(name) { }

        public override void OnKingAttacked(EventArgs args)
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}
