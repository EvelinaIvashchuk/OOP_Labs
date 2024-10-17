using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> Missions { get; set; }

        public Commando(int id, string firstName, string lastName, string corps, double salary)
            : base(id, firstName, lastName, salary, corps) 
        { 
           Missions = new List<Mission>();
        }

        public void AddMission(Mission mission)
        {
            Missions.Add(mission);
        }

        public override string ToString()
        {
            string missions = "";
            foreach (var mission in Missions)
            {
                missions += mission.ToString() + "\n";
            }
            return base.ToString() + $"\nMissions:\n{missions}";
        }
    }
}
