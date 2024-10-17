using CarSales;

class Program
{
    static void Main(string[] args)
    {
        // Зчитуємо кількість двигунів
        int n = Convert.ToInt32(Console.ReadLine());
        Engine[] engines = new Engine[n];

        // Читання двигунів
        for (int i = 0; i < n; i++)
        {
            string engineInput = Console.ReadLine();
            string[] engineData = ParseInput(engineInput);
            string model = engineData[0];
            int power = Convert.ToInt32(engineData[1]);
            int displacement = engineData.Length > 2 && engineData[2] != "n/a" ? Convert.ToInt32(engineData[2]) : -1;
            string efficiency = engineData.Length == 4 ? engineData[3] : "n/a";

            engines[i] = new Engine(model, power, displacement, efficiency);
        }

        // Зчитуємо кількість автомобілів
        int m = int.Parse(Console.ReadLine());
        Car[] cars = new Car[m];

        // Читання автомобілів
        for (int i = 0; i < m; i++)
        {
            string carInput = Console.ReadLine();
            string[] carData = ParseInput(carInput);

            string carModel = carData[0];
            string engineModel = carData[1];

            Engine carEngine = null;
            for (int j = 0; j < engines.Length; j++)
            {
                if (engines[j].Model == engineModel)
                {
                    carEngine = engines[j];
                    break;
                }
            }

            // Якщо є третій параметр - це вага, якщо немає - задаємо значення за замовчуванням (-1)
            int weight = -1;
            if (carData.Length > 2 && IsNumeric(carData[2]))
            {
                weight = Convert.ToInt32(carData[2]);
            }

            // Якщо є четвертий параметр - це колір, якщо немає - задаємо значення за замовчуванням ("n/a")
            string color = carData.Length == 4 ? carData[3] : "n/a";

            cars[i] = new Car(carModel, carEngine, weight, color);
        }

        // Виведення результатів
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].PrintCarInfo();
        }
    }

    // Ручне розбиття рядка на частини
    static string[] ParseInput(string input)
    {
        string[] parts = new string[4];
        string currentPart = "";
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ' && currentPart != "")
            {
                parts[index] = currentPart;
                currentPart = "";
                index++;
            }
            else
            {
                currentPart += input[i];
            }
        }

        // Додаємо останню частину
        if (currentPart != "")
        {
            parts[index] = currentPart;
        }

        // Обрізаємо зайві елементи, якщо їх менше 4
        int nonNullParts = 0;
        for (int i = 0; i < parts.Length; i++)
        {
            if (parts[i] != null)
                nonNullParts++;
        }

        string[] result = new string[nonNullParts];
        for (int i = 0; i < nonNullParts; i++)
        {
            result[i] = parts[i];
        }

        return result;
    }
    
    // Метод для перевірки, чи є рядок числом
    static bool IsNumeric(string value)
    {
        for (int i = 0; i < value.Length; i++)
        {
            if (!char.IsDigit(value[i]))
                return false;
        }
        
        return true;
    }
}
