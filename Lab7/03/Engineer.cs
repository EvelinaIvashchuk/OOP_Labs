using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Repair> Repairs { get; set; } = new List<Repair>();

        public Engineer(int id, string firstName, string lastName, double salary, string corps)
         : base(id, firstName, lastName, salary, corps) { }


        public void AddRepair(Repair repair)
        {
            Repairs.Add(repair);
        }

        public List<Repair> GetRepairs()
        {
            return Repairs;
        }

        public override string ToString()
        {
            string repairsInfo = "";
            foreach (var repair in Repairs)
            {
                repairsInfo += repair.ToString() + "\n";
            }
            return base.ToString() + $"\nRepairs:\n{repairsInfo}";
        }

    }

}
