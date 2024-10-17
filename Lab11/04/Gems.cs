using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    public enum GemsType
    {
        Ruby, Emerald, Amethyst
    }

    public enum PurityLevel
    {
        Chipped = 1,  
        Regular = 2,  
        Perfect = 5,  
        Flawless = 10
    }
    public class Gems
    {
        public GemsType Type { get; set; }
        public PurityLevel Purity { get; set; }

        public int strength { get; set; } = 0;
        public int agility { get; set; } = 0;
        public int vitality { get; set; } = 0;

        public Gems(GemsType type, PurityLevel purity)
        {
            Type = type;
            Purity = purity;

            switch (Type)
            {
                case GemsType.Ruby:
                    strength = 7;
                    agility = 2;
                    vitality = 5;
                    break;
                case GemsType.Emerald:
                    strength = 1;
                    agility = 4;
                    vitality = 9;
                    break;
                case GemsType.Amethyst:
                    strength = 2;
                    agility = 8;
                    vitality = 4;
                    break;
            }

            ApplyPurityBonus();
        }
        private void ApplyPurityBonus()
        {
            strength += (int)Purity;
            agility += (int)Purity;
            vitality += (int)Purity;
        }

        public void ApplyMinAndMax(int max, int min)
        {
            min = (2 * strength) + (1 * agility);
            max = (3 * strength) + (4 * agility);
        }
    }
}
