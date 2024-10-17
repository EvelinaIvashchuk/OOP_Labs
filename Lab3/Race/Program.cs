// See https://aka.ms/new-console-template for more information

using Race;

int n = int.Parse(Console.ReadLine());
Car[] cars = new Car[n];

// Читання даних про автомобілі
for (int i = 0; i < n; i++)
{
    string carInput = Console.ReadLine();
    string model = "";
    string fuelStr = "";
    string consumptionStr = "";
    int partIndex = 0;

    for (int j = 0; j < carInput.Length; j++)
    {
        if (carInput[j] == ' ')
        {
            partIndex++;
        }
        else
        {
            if (partIndex == 0)
            {
                model += carInput[j];
            }
            else if (partIndex == 1)
            {
                fuelStr += carInput[j];
            }
            else if (partIndex == 2)
            {
                consumptionStr += carInput[j];
            }
        }
    }

    double fuelAmount = Convert.ToDouble(fuelStr);
    double fuelConsumption = Convert.ToDouble(consumptionStr);

    cars[i] = new Car(model, fuelAmount, fuelConsumption);
}

// Обробка команд
string command;
while ((command = Console.ReadLine()) != "End")
{
    string commandType = "";
    string model = "";
    string distanceStr = "";
    int partIndex = 0;

    // Розбиваємо команду вручну
    for (int i = 0; i < command.Length; i++)
    {
        if (command[i] == ' ')
        {
            partIndex++;
        }
        else
        {
            if (partIndex == 0)
            {
                commandType += command[i];
            }
            else if (partIndex == 1)
            {
                model += command[i];
            }
            else if (partIndex == 2)
            {
                distanceStr += command[i];
            }
        }
    }

    if (commandType == "Drive")
    {
        int distance = Convert.ToInt32(distanceStr);

        // Шукаємо автомобіль по моделі
        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i].Model == model)
            {
                cars[i].Drive(distance);
                break;
            }
        }
    }
}

// Виведення результатів
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"{cars[i].Model} {Math.Round(cars[i].FuelAmount, 2)} {cars[i].DistanceTraveled}");
}