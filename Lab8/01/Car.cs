using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Car
    {
        private float fuel_quantity;
        private float liters_per_km;

        public Car(float fuel, float liter)
        {
            fuel_quantity = fuel;
            liters_per_km = liter;
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

        public virtual void Refuel(float liters)
        {
            fuel_quantity += liters;
        }

    }
}
