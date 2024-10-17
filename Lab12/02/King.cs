using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public delegate void EventWithKing(EventArgs e);
    class King
    {
      public string Name { get; set; }

        public King(string name)
        {
            Name = name;
        }

        public event EventWithKing BeingAttacked;

        public void TakeAttack()
        {
            OnBeingAttacked();
        }

        protected virtual void OnBeingAttacked()
        {
            Console.WriteLine($"King {Name} is under attack!");

            BeingAttacked?.Invoke(EventArgs.Empty);
        }

    }
}
