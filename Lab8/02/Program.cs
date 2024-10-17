using System.Diagnostics;
using System.Runtime.CompilerServices;
using _02;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string name = input[0];
        float fuel_quantity = float.Parse(input[1]);
        float liters_per_km = float.Parse(input[2]);
        float tank_capacity = float.Parse(input[3]);
        Car car = new Car(fuel_quantity, liters_per_km, tank_capacity);

        string[] input1 = Console.ReadLine().Split();
        string name1 = input1[0];
        float fuel_quantity1 = float.Parse(input1[1]);
        float liters_per_km1 = float.Parse(input1[2]);
        float tank_capacity1 = float.Parse(input1[3]);
        Truck truck = new Truck(fuel_quantity1, liters_per_km1, tank_capacity1);

        string[] input2 = Console.ReadLine().Split();
        string name2 = input1[0];
        float fuel_quantity2 = float.Parse(input2[1]);
        float liters_per_km2 = float.Parse(input2[2]);
        float tank_capacity2 = float.Parse(input2[3]);
        Bus bus = new Bus(fuel_quantity2, liters_per_km2, tank_capacity2);

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] input3 = Console.ReadLine().Split();
            string NameFunction = input3[0];
            string NameVehile = input3[1];
            float action = float.Parse(input3[2]);

            if (NameFunction == "Drive")
            {
                if (NameVehile == "Car")
                {
                    car.Drive(action);
                }
                else if (NameVehile == "Truck")
                {
                    truck.Drive(action);
                }
                else if (NameVehile == "Bus")
                {
                    bus.Drive(action);
                }
            }
            else if (NameFunction == "Refuel")
            {
                if (NameVehile == "Car")
                {
                    car.Refuel(action);
                }
                else if (NameVehile == "Truck")
                {
                    truck.Refuel(action);
                }
                else if (NameFunction == "Bus")
                {
                    bus.Refuel(action);
                }
            }

            if (NameFunction == "DriveEmpty")
            {
                if (NameVehile == "Bus")
                {
                    bus.DriveEmpty(action);
                }
                else
                {
                    Console.WriteLine($"{NameVehile} cannot support this function");
                }
            }
        }
    }
}

/*
Car 30 0,04 70
Truck 100 0,5 300
Bus 40 0,3 150
8
Refuel Car -10
Refuel Truck 0
Refuel Car 10
Refuel Car 300
Drive Bus 10
Refuel Bus 1000
DriveEmpty Bus 100
Refuel Truck 1000
 
 */
