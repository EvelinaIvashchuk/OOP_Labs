using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Manager
    {
        List<Gems> gems;
        List<Weapon> weapons;

        public Manager()
        {
            gems = new List<Gems>();
            weapons = new List<Weapon>();
        }

        public void CreateWeapon(string WeaponName, string weaponType, RarityLevel rarityLevel)
        {
            Weapon weapon = new Weapon();
            if (weaponType == "Axe")
            {
                weapon = new Axe(WeaponName, rarityLevel);
            }
            else if (weaponType == "Sword")
            {
                weapon = new Sword(WeaponName, rarityLevel);
            }
            else if (weaponType == "Knife")
            {
                weapon = new Knife(WeaponName, rarityLevel);
            }
            else
            {
                Console.WriteLine($"Not found {weaponType} or {rarityLevel}");
            }

            if (weapon != null)
            {
                weapons.Add(weapon);
            }
        }


        public Weapon GetWeaponName(string weaponName)
        {
            var currentName = weapons.FirstOrDefault(w => w.NameWeapon == weaponName);
            if (currentName == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Operation!");
                Console.ResetColor();
            }
            return currentName;
        }

        public void AddGemToSocket(string weaponName, int socketIndex, GemsType gemType, PurityLevel purityLevel)
        {
            var weapon = GetWeaponName(weaponName);
            if (weapon == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something Wrong!");
                Console.ResetColor();
                return;
            }

            if (socketIndex < 0 || socketIndex >= weapon.sockets)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid socket index!");
                Console.ResetColor();
                return;
            }

            Gems gem = new Gems(gemType, purityLevel);

            weapon.AddGem(socketIndex, gem); 
        }

        public void RemoveGemFromSocket(string weaponName, int socketIndex)
        {
            var weapon = GetWeaponName(weaponName);
            if (weapon == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something Wrong!");
                Console.ResetColor();
                return;
            }
                

            if (socketIndex < 0 || socketIndex >= weapon.sockets)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid socket index!");
                Console.ResetColor();
                return;
            }

            weapon.RemoveGem(socketIndex);

        }

        public void PrintWeaponInfo(string weaponName)
        {
            var weapon = GetWeaponName(weaponName);
            if (weapon == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something Wrong!");
                Console.ResetColor();
                return;
            }

            int totalStrength = 0;
            int totalAgility = 0;
            int totalVitality = 0;

            for (int i = 0; i < weapon.sockets; i++)
            {
                var gem = weapon.GemSockets[i]; 
                if (gem != null)
                {
                    totalStrength += gem.strength;
                    totalAgility += gem.agility;
                    totalVitality += gem.vitality;
                    weapon.ApplyMinAndMax(gem);
                }

            }

            
            Console.WriteLine($"{weaponName}: " +
                $"{weapon.minDamage}-{weapon.maxDamage} " +
                $"Damage, " + $"+{totalStrength} Strength, +{totalAgility} Agility, +{totalVitality} Vitality");
        }
    }
}
