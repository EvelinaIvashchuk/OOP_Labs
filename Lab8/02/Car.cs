using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Car
    {
        private float fuel_quantity;
        private float liters_per_km;
        private float tank_capacity;

        public Car(float fuel, float liter, float capacity)
        {
            fuel_quantity = fuel;
            liters_per_km = liter;
            tank_capacity = capacity;
        }

        public virtual bool Drive(float distance)
        {
            float need = (liters_per_km + 0.9f) * distance;

            if (need <= fuel_quantity)
            {
                fuel_quantity =- need;
                Console.WriteLine($"[ Car travelled {distance} km ]");
                return true;
            }
            else
            {
                Console.WriteLine("[ Car need refueling ]");
                return false;
            }
        }

        public virtual bool Refuel(float liters)
        {
            if (liters >= tank_capacity)
            {
                Console.WriteLine($"[ Cannot fit {liters} fuel in the tank ]");
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
