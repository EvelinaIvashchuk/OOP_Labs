using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Engine
    {
        public void Run()
        {
            var soldiers = new List<Soldier>();
            var king = new King(Console.ReadLine());
            var royalGuardsNames = Console.ReadLine().Split();
            var footmenNames = Console.ReadLine().Split();

            foreach (string guardName in royalGuardsNames)
            {
                var currentRoyalGuard = new RoyalGuard(guardName);
                soldiers.Add(currentRoyalGuard);
                king.BeingAttacked += currentRoyalGuard.OnKingAttacked;
            }

            foreach (string footManName in footmenNames)
            {
                var footMan = new Footman(footManName);
                soldiers.Add(footMan);
                king.BeingAttacked += footMan.OnKingAttacked;
            }

            string command = null;
            var commandCount = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                commandCount++;
                if (commandCount < 1 || commandCount > 100)
                {
                    throw new Exception("Number of commands in the range [1...100].");
                }

                string[] input = command.Split();

                if (input[0] == "Kill")
                {
                    Soldier deadSoldier = soldiers.FirstOrDefault(s => s.Name.Equals(input[1]));
                    king.BeingAttacked -= deadSoldier.OnKingAttacked;
                    soldiers.Remove(deadSoldier);
                }

                if (input[0] == "Attack")
                {
                    king.TakeAttack();
                }

            }
        }
    }
}
