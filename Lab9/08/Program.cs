
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

class CustomList<T>
{
    private T Value;
    private List<T> values = new List<T>();

    public CustomList(List<T> values)
        { this.values = values; }


    // ---------------------------------------------- //

    public void Add(T element)
    {
        values.Add(element);
    }

    public T Remove(int index)
    {
        T element = values[index];
        values.RemoveAt(index);
        return element;
    }

    public bool Contains(T element)
    {
        if (values.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Swap(List<T> list, int value1, int value2)
    {
        T temp = list[value1];
        list[value1] = list[value2];
        list[value2] = temp;
    }

    public int CountOfGreaterThan<T>(List<T> list, T element) where T : IComparable<T>
    {
        int count = 0;
        foreach (var value in list)
        {
            if (value.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }

    public void Print(List<T> values)
    {
        foreach (var element in values)
        {
            Console.WriteLine(element);
        }
    }

    public T Max<T>(List<T> values) where T : IComparable<T>
    {
        T max = values[0];
        foreach (var value in values)
        {
            if (value.CompareTo(max) > 0)
            {
                max = value;
            }
        }
        return max;
    }

    public T Min<T>(List<T> values) where T : IComparable<T>
    {
        T min = values[0];
        foreach (var value in values)
        {
            if (value.CompareTo(min) < 0)
            {
                min = value;
            }
        }
        return min;
    }

}


class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        CustomList<string> custom = new CustomList<string>(list);
        
        string command = null;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] input = command.Split();
            string function = input[0];

            if (input.Length == 2)
            {
                string value = input[1];
               
                if (function == "Add")
                {
                    custom.Add(value);
                }
                else if (function == "Remove")
                {
                    int result = Int32.Parse(value);
                    custom.Remove(result);
                }
                else if (function == "Contains")
                {
                    bool contains = custom.Contains(value);
                    Console.WriteLine(contains);
                }
                else if (function == "Greater")
                {
                    int greater = custom.CountOfGreaterThan(list, value);
                    Console.WriteLine(greater);
                }
                else
                {
                    Console.WriteLine("Wrong Outputing!");
                }
            }

            if (input.Length == 3)
            {
                if (function == "Swap")
                {
                    int value1 = int.Parse(input[1]);
                    int value2 = int.Parse(input[2]);
                    custom.Swap(list, value1, value2);
                }
                else
                {
                    Console.WriteLine("Wrong Outputing!");
                }
            } 

            if (input.Length == 1)
            {
                if (function == "Print")
                {
                   custom.Print(list);
                }
                else if (function == "Max")
                {
                  var max = custom.Max(list);
                    Console.WriteLine(max);
                }
                else if (function == "Min")
                {
                   var min = custom.Min(list);
                    Console.WriteLine(min);
                }
                else
                {
                    Console.WriteLine("Wrong Outputing!");
                }
            }
           
            
        }
    }

    

   


}