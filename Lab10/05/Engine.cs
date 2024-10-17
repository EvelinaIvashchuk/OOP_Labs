using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class Engine
    {
        public Engine() { }

        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            ClinicsManager manager = new ClinicsManager();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();

                var function = input[0];

                if (input.Length == 5)
                {
                    if (function == "Create" && input[1] == "Pet")
                    {
                        var name = input[2];
                        var age = int.Parse(input[3]);
                        var kind = input[4];
                        manager.CreatePet(name, age, kind);
                    }
                }

                if (input.Length == 4)
                {
                    if (function == "Create" && input[1] == "Clinic")
                    {
                        var name = input[2];
                        var roomcount = int.Parse(input[3]);
                        manager.CreateClinic(name, roomcount);
                    }
                }

                if (input.Length == 3)
                {
                    if (function == "Add")
                    {
                        var name = input[1];
                        var rooms = input[2];
                        if (manager.Add(name, rooms) == true)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("[" + manager.Add(name, rooms) + "]");
                        }
                        else if (manager.Add(name, rooms) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[" + manager.Add(name, rooms) + "]");
                        }
                        Console.ResetColor();
                        
                    }
                    else if (function == "Print")
                    {
                        var name = input[1];
                        var rooms = int.Parse(input[2]);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(manager.PrintRoom(name, rooms));
                        Console.ResetColor();
                    }
                }

                if (input.Length == 2)
                {
                    if (function == "HasEmptyRooms")
                    {
                        var name = input[1];
                        if (manager.HasEmptyRooms(name) == true)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("[" + manager.HasEmptyRooms(name) + "]");
                        }
                        else if(manager.HasEmptyRooms(name) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[" + manager.HasEmptyRooms(name) + "]");
                        }
                        Console.ResetColor();
                   
                    }
                    else if (function == "Release")
                    {
                        var name = input[1];
                        if (manager.Release(name) == true)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("[" + manager.Release(name) + "]");
                        }
                        else if (manager.Release(name) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("[" + manager.Release(name) + "]");
                        }
                        Console.ResetColor();
                    }
                    else if (function == "Print")
                    {
                        var clinicname = input[1];
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(manager.PrintClinic(clinicname));
                        Console.ResetColor();
                    }

                }
            }
        }
    }
}
