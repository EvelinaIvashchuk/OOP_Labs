using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02
{
    abstract class Soldier
    {
        public string Name { get; private set; }
        protected int hitCount = 0;

        protected Soldier(string name) 
        {
            Name = name;
        }

        public void IncreaseHitCount()
        {
            hitCount++;
        }

        public abstract bool IsDead();

        public abstract void OnKingAttacked(EventArgs args);
    }
}
