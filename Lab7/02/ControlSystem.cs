using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    interface IBuyer
    {
        int Food { get; set; }
        public void BuyFood();
    }

    internal class ControlSystem 
    {    
        public ControlSystem() { }

        private List<string> IdSearching = new List<string>();
        private List<int> AgeSearching = new List<int>();
        public void AddCitizen(string name, int age, string ID, int year)
        {
            Citizen citizen = new Citizen(name, age, ID, year);
            IdSearching.Add(ID);
            AgeSearching.Add(year);
        }

        public void AddRobot(string model, string ID)
        {
            Robot robot = new Robot(model, ID);
            IdSearching.Add(ID);
        }

        public void AddPet(string name, int year)
        {
            Pet pets = new Pet(name, year);
            AgeSearching.Add(year);
        }

        public void AddRebel(string name, int age, string group)
        {
            Rebel rebel = new Rebel(name, age, group);
        }

        public void NUMFOUND(string num)
        {
            foreach (var ID in IdSearching)
            {
                if (ID.EndsWith(num))
                {
                    Console.WriteLine($"FINDED: [{ID}]");
                }
            }
        }

        public void AGEFOUND(int year)
        {
            foreach(var Years in AgeSearching)
            {
                if(Years.Equals(year))
                {
                    Console.WriteLine($"FINDED:[{Years}]");
                }
            }
        }

        public void WORKING1()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split();

                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string ID = input[2];
                    Citizen citizen = new Citizen(name, age, ID); 
                }

                else if (input.Length == 2)
                {
                    string model = input[0];
                    string ID = input[1];
                    AddRobot(model, ID);
                }
            }
        }

        public void WORKING()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split();

                if (input.Length == 5 && input[0] == "Citizen")
                {
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    string ID = input[3];
                    string[] birthDate = input[4].Split('/');

                    int day = int.Parse(birthDate[0]);
                    int month = int.Parse(birthDate[1]);
                    int year = int.Parse(birthDate[2]);

                    AddCitizen(name, age, ID, year);
                }

                else if (input.Length == 3 && input[0] == "Robot")
                {
                    string model = input[1];
                    string ID = input[2];
                    AddRobot(model, ID);
                }

                if (input.Length == 3 && input[0] == "Pet")
                {
                    string name = input[1];
                    string[] birthDate = input[2].Split('/');

                    int day = int.Parse(birthDate[0]);
                    int month = int.Parse(birthDate[1]);
                    int year = int.Parse(birthDate[2]);
                    AddPet(name, year);
                }
            }
        }

        public void WORKING2()
        {
            int N = int.Parse(Console.ReadLine());
            List<Rebel> rebels = new List<Rebel>();
            List<Citizen> citizens = new List<Citizen>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string ID = input[2];
                    string[] birthDate = input[3].Split('/');

                    int day = int.Parse(birthDate[0]);
                    int month = int.Parse(birthDate[1]);
                    int year = int.Parse(birthDate[2]);
                    Citizen citizen = new Citizen(name, age, ID, year);
                    citizens.Add(citizen);
                }

                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];
                    Rebel rebel = new Rebel(name, age, group);
                    rebels.Add(rebel);
                }
            }
            int totalFood = 0;
            string command = null;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split();
                string name = input[0];

                for (int i = 0; i < citizens.Count; i++)
                {
                    if (citizens[i].Name == name)
                    {
                        citizens[i].BuyFood();
                        totalFood += citizens[i].Food;
                    }
                    else
                    {
                        continue;
                    }
                }

                for(int i = 0; i < rebels.Count; i++)
                {
                    if (rebels[i].Name == name)
                    {
                        rebels[i].BuyFood();
                        totalFood += rebels[i].Food;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Materials.SmallLine();
            Console.WriteLine(totalFood);

        }



    }
}
