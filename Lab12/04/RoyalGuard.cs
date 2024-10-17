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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Royal Guard {Name} is defending!");
            Console.ResetColor();
        }

        public override bool IsDead()
        {
            return hitCount >= 3; 
        }
    }
}
