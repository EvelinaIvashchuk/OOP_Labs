namespace CarSales;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int? Weight { get; set; }
    public string Color { get; set; }

    public Car(string model, Engine engine, int weight = -1, string color = "n/a")
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color;
    }

    public void PrintCarInfo()
    {
        Console.WriteLine(Model + ":");
        Console.WriteLine(" " + Engine.Model + ":");
        Console.WriteLine("  Power: " + Engine.Power);
        Console.WriteLine("  Displacement: " + (Engine.Displacement != -1 ? Engine.Displacement.ToString() : "n/a"));
        Console.WriteLine("  Efficiency: " + Engine.Efficiency);
        Console.WriteLine(" Weight: " + (Weight != -1 ? Weight.ToString() : "n/a"));
        Console.WriteLine(" Color: " + Color);
    }
}