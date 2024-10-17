using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Bus : Car
    {
        private float fuel_quantity;
        private float liters_per_km;
        private float tank_capacity;

        public Bus(float fuel, float liter, float capacity)
            : base(fuel, liter, capacity)
        {

        }

        public override bool Drive(float distance)
        {
            float need = (liters_per_km + 1.4f) * distance;

            if (need <= fuel_quantity)
            {
                fuel_quantity -= need;
                Console.WriteLine($"[ Bus travelled {distance} km ]");
                return true;

            }
            else
            {
                Console.WriteLine("[ Bus need refueling ]");
                return false;
            }
        }

        public bool DriveEmpty(float distance)
        {
            float need = (liters_per_km) * distance;

            if (need <= fuel_quantity)
            {
                fuel_quantity -= need;
                Console.WriteLine($"[ Bus travelled {distance} km ]");
                return true;

            }
            else
            {
                Console.WriteLine("[ Bus need refueling ]");
                return false;
            }
        }

        public override bool Refuel(float liters)
        {
            if (liters >= tank_capacity)
            {
                Console.WriteLine($"[ Cannot fit {liters} fuel in the tank] ");
                return false;
            }
            else if (liters <= 0)
            {
                Console.WriteLine("[ Fuel must be a positive number ]");
                return false;
            }
            else
            {
                fuel_quantity += liters;
                return true;
            }
        }
    }
}
