using _05;

[Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]

public class Startup
{
    public static void Main()
    {
        CustomAttribute attribute = (CustomAttribute)typeof(Startup).GetCustomAttributes(false).FirstOrDefault();

        string command = null;

        while ((command = Console.ReadLine()) != "END")
        {
            string[] input = command.Split(' ');
            string print = input[0];
            Console.WriteLine(attribute.Print(print));
        }
    }
}