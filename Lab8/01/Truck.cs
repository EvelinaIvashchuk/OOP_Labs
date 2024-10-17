using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Truck : Car
    {
        private float fuel_quantity;
        private float liters_per_km;

        public Truck(float fuel, float liter)
            : base(fuel, liter)
        {

        }

        public override bool Drive(float distance)
        {
            float need = (liters_per_km + 1.6f) * distance;

            if (need <= fuel_quantity)
            {
                fuel_quantity -= need;
                Console.WriteLine($"[ Truck travelled {distance} km ]");
                return true;

            }
            else
            {
                Console.WriteLine("[ Truck need refueling ]");
                return false;
            }
        }

        public override void Refuel(float liters)
        {
            fuel_quantity += liters * 0.95f;
        }
    }
}
