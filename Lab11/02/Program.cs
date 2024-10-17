using _02;
using System.Reflection;

class Program
{
    
    static void Main()
    {
        var classType = typeof(BlackBoxInteger);
        var methodsInfo = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
        var instance = (BlackBoxInteger)Activator.CreateInstance(classType, true);


        string command = null;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] input = command.Split("_");
            var currentMethod = methodsInfo.FirstOrDefault(x => x.Name.Equals(input[0]));
            currentMethod.Invoke(instance, new object[] { int.Parse(input[1]) });

            var innerValue = classType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault(x => x.Name.Equals("innerValue")).GetValue(instance);

            Console.WriteLine(innerValue);
        }
    }

}
