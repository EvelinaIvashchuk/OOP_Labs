using System.Runtime.CompilerServices;
using _01;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string name = input[0];
        float fuel_quantity = float.Parse(input[1]);
        float liters_per_km = float.Parse(input[2]);
        Car car = new Car(fuel_quantity, liters_per_km);


        string[] input1 = Console.ReadLine().Split();
        string name1 = input1[0];
        float fuel_quantity1 = float.Parse(input1[1]);
        float liters_per_km1 = float.Parse(input1[2]);
        Truck truck = new Truck(fuel_quantity1, liters_per_km1);

        int N = int.Parse(Console.ReadLine());

       for (int i = 0; i < N; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            string NameFunction = input2[0];
            string NameVehile = input2[1];
            float action = float.Parse(input2[2]);

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
            }
       }
    }
}

/*
Car 15 0,3
Truck 100 0,9
4
Drive Car 9
Drive Car 30
Refuel Car 50
Drive Truck 10


Car 30,4 0,4
Truck 99,34 0,9
5
Drive Car 500
Drive Car 13,5
Refuel Truck 10,300
Drive Truck 56,2
Refuel Car 100,2
 
 */