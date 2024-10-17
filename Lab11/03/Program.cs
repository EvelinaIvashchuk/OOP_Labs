public enum TrafficLighter
{
    Red, Yellow, Green
}

class Program
{
    static void Main()
    {
        List<TrafficLighter> list = new List<TrafficLighter>();
        string[] input = Console.ReadLine().Split();

        foreach (string signal in input)
        {
            TrafficLighter trafficLighter;
            Enum.TryParse(signal, out trafficLighter);
            list.Add(trafficLighter);
        }

        int N = int.Parse(Console.ReadLine());

        string result = "";
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < list.Count; j++)
            {
                var trafficligher = list[j];
                trafficligher = SignalSwitch(trafficligher);
                list[j] = trafficligher;
                result += ($"{trafficligher} ");
            }
            result += "\n";
        }

        Console.WriteLine( result );
    }


    static TrafficLighter SignalSwitch(TrafficLighter trafficligher)
    {
        var enumlighter = Enum.GetNames(typeof(TrafficLighter)).Length;
        var current = (int)trafficligher;
        trafficligher = (TrafficLighter)((current + 1) % enumlighter);
        return trafficligher;
    }
}