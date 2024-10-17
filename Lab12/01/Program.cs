using System.Data;
using Dispatcher;
using _01;

class Program
{
    static void Main()
    {
        var dispetcher = new Dispatcher.Dispatcher();
        var handler = new Handler();

        dispetcher.NameChange += handler.OnDispatcherNameChange;

        string command = null;
        while ((command = Console.ReadLine()) != "End" || (command = Console.ReadLine()) != "END")
        {
            string[] input = command.Split();
            dispetcher.Name = input[0];
        }
    }
}