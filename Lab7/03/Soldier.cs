using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Soldier : ISoldier
    {
        public int ID { get; }
        public string name { get; }
        public string surname { get; }
        public Soldier(int ID, string FirstName, string LastName)
        {
            this.ID = ID;
            this.name = FirstName;
            this.surname = LastName;
        }

        public Soldier() { }

        public Soldier(string name, string surname) { }


        public override string ToString()
        {
            return $"Name: {name} {surname} Id: {ID}";
        }

    }
}
