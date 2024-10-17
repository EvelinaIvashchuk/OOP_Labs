namespace Race;

public class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKm { get; set; }
    public int DistanceTraveled { get; set; }

    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
        DistanceTraveled = 0; // Автомобілі починаються з 0 км пробігу
    }

    public bool Drive(int amountOfKm)
    {
        var neededFuel = amountOfKm * FuelConsumptionPerKm;
        if (FuelAmount >= neededFuel)
        {
            FuelAmount -= neededFuel;
            DistanceTraveled += amountOfKm;
            return true;
        }

        Console.WriteLine("Недостатньо палива для руху");
        
        return false;
    }
}