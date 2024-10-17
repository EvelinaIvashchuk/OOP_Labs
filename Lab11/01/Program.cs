using _01;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Windows.Input;

public class Program
{
    public static void Main()
    {
        var type = typeof(HarvestingFields);
        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        string command = null;
        while((command = Console.ReadLine()) != "HARVEST")
        {
            foreach (var fieldsInfo in fields)
            {
                string modifier = GetModifire(fieldsInfo);
                if (command == modifier)
                {
                    Console.WriteLine($"{modifier} {fieldsInfo.FieldType.Name} {fieldsInfo.Name}");
                }
                else if (command == "all")
                {
                    Console.WriteLine($"{GetModifire(fieldsInfo)} {fieldsInfo.FieldType.Name} {fieldsInfo.Name}");
                }
                
            }
        }

    }

    private static string GetModifire(FieldInfo fieldInfo)
    {
        if (fieldInfo.IsPublic)
        {
            return "public";
        }
        if (fieldInfo.IsPrivate)
        {
            return "private";
        }

        return "protected";
    }

}