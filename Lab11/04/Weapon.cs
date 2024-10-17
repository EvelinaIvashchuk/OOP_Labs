using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public enum RarityLevel
    {
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        Epic = 5
    }
    public class Weapon
    {
        public string NameWeapon {  get; set; }
        public int minDamage {  get; set; } = 0;
        public int maxDamage { get; set; } = 0;
        public int sockets { get; set; }
        private RarityLevel rarity { get; set; }
        public Gems[] GemSockets { get; set; }
        public Gems gems { get; set; }

        public Weapon(string name, int minDamage, int maxDamage, int sockets, RarityLevel rarity)
        {
            NameWeapon = name;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.sockets = sockets;
            this.rarity = rarity;
            GemSockets = new Gems[sockets];

            ApplyRarityBonus();
        }

        public void ApplyMinAndMax(Gems gem)
        {
            minDamage += gem.strength * 2 + gem.agility * 1;
            maxDamage += gem.strength * 3 + gem.agility * 4;
        }

        public Weapon()
        {
            ApplyRarityBonus();
        }

        public void ApplyRarityBonus()
        {
            minDamage *= (int)rarity;
            maxDamage *= (int)rarity;
        }

        

        public void AddGem(int socketIndex, Gems gem)
        {
            if (socketIndex < 0 || socketIndex >= sockets)
            {
                Console.WriteLine("Invalid socket index.");
                return;
            }

            GemSockets[socketIndex] = gem;
        }

        public void RemoveGem(int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= sockets)
            {
                Console.WriteLine("Invalid socket index.");
                return;
            }

            GemSockets[socketIndex] = null; 
        }

    }

    public class Axe : Weapon
    {
        public Axe(string name, RarityLevel rarity)
            : base(name, 5, 10, 4, rarity) 
        {
           

        }
    }

    // Sword class with predefined characteristics
    public class Sword : Weapon
    {
        public Sword(string name, RarityLevel rarity)
            : base(name, 4, 6, 3, rarity) 
        {
            
        }
    }

    // Knife class with predefined characteristics
    public class Knife : Weapon
    {
        public Knife(string name, RarityLevel rarity)
            : base(name, 3, 4, 2, rarity) 
        {
           
        }
    }
}
