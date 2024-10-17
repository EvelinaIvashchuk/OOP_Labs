using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Engine
    {
        public Engine() { }
        public void Run()
        {
            Manager manager = new Manager();
            string command = null;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split(";");
                string function = input[0];
                if (input.Length == 2)
                {
                    if (function == "Print")
                    {
                        var NameWeapon = input[1];
                        manager.PrintWeaponInfo(NameWeapon);
                    }
                }

                if (input.Length == 3)
                {
                    if (function == "Remove")
                    {
                        var NameWeapon = input[1];
                        var socketIndex = int.Parse(input[2]);
                        manager.RemoveGemFromSocket(NameWeapon, socketIndex);
                    }
                }

                if (input.Length == 4)
                {
                    if(function == "Create")
                    {
                        if (Enum.TryParse(input[1], out RarityLevel rarityLevel))
                        {
                            var weaponType = input[2];
                            var NameWeapon = input[3];
                            manager.CreateWeapon(NameWeapon, weaponType, rarityLevel);
                        }
                    }
                }

                if (input.Length == 5)
                {
                    if(function=="Add")
                    {
                        var NameWeapon = input[1];
                        int socketIndex = int.Parse(input[2]);
                        if (Enum.TryParse(input[3], out PurityLevel purityLevel))
                        {
                            if (Enum.TryParse(input[4], out GemsType gemsType))
                            {
                                manager.AddGemToSocket(NameWeapon,socketIndex,gemsType,purityLevel);
                            }
                        }

                    }
                }

                
            }
        }
    }
}
