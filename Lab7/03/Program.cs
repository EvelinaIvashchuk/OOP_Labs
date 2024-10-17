using System.Dynamic;

namespace _03
{
    class Program
    {
        static void Main()
        {
            try
            {
                Materials.DISPLAY();
                string command = null;
                List<Private> privatesList = new List<Private>();
                List<LeutenantGeneral> leutenantGeneralsList = new List<LeutenantGeneral>();
                List<Engineer> engineersList = new List<Engineer>();
                List<Commando> commandosList = new List<Commando>();
                List<Spy> spiesList = new List<Spy>();

                while ((command = Console.ReadLine()) != "End")
                {
                    string[] input = command.Split();
                    string name = input[0];

                    if (name == "Private")
                    {
                        int ID = int.Parse(input[1]);
                        string firstname = input[2];
                        string lastname = input[3];
                        double salary = double.Parse(input[4]);
                        Private privates = new Private(ID, firstname, lastname, salary);
                        privatesList.Add(privates);
                    }

                    if (name == "LeutenantGeneral")
                    {
                        int ID = int.Parse(input[1]);
                        string firstname = input[2];
                        string lastname = input[3];
                        double salary = double.Parse(input[4]);
                        LeutenantGeneral leutenantGeneral = new LeutenantGeneral(ID, firstname, lastname, salary);

                        for (int i = 5; i < input.Length; i++)
                        {
                            int privateId = int.Parse(input[i]);
                            for (int j = 0; j < privatesList.Count; j++)
                            {
                                if (privatesList[j].ID == privateId)
                                {
                                    leutenantGeneral.AddPrivate(privatesList[j]);
                                    break;
                                }
                            }
                        }

                        leutenantGeneralsList.Add(leutenantGeneral);
                    }

                    if (name == "Engineer")
                    {
                        int ID = int.Parse(input[1]);
                        string firstname = input[2];
                        string lastname = input[3];
                        double salary = double.Parse(input[4]);
                        string corps = input[5];

                        Engineer engineer = new Engineer(ID, firstname, lastname, salary, corps);

                        for (int i = 6; i < input.Length; i += 2)
                        {
                            string partName = input[i];
                            int hoursWorked = int.Parse(input[i + 1]);
                            Repair repair = new Repair(partName, hoursWorked);
                            engineer.AddRepair(repair);
                        }

                        engineersList.Add(engineer);
                    }

                    if (name == "Commando")
                    {
                        int ID = int.Parse(input[1]);
                        string firstname = input[2];
                        string lastname = input[3];
                        double salary = double.Parse(input[4]);
                        string corps = input[5];

                        Commando commando = new Commando(ID, firstname, lastname, corps, salary);

                        for (int i = 6; i < input.Length; i += 2)
                        {
                            string missionName = input[i];
                            string state = input[i + 1];
                            Mission mission = new Mission(missionName, state);
                            commando.AddMission(mission);
                        }

                        commandosList.Add(commando);
                    }

                    if (name == "Spy")
                    {
                        int ID = int.Parse(input[1]);
                        string firstname = input[2];
                        string lastname = input[3];
                        int spyNumber = int.Parse(input[4]);

                        Spy spy = new Spy(ID, firstname, lastname, spyNumber);
                        spiesList.Add(spy);
                    }
                }

                Materials.SmallLine();

                foreach (var privateSoldier in privatesList)
                {
                    Console.WriteLine(privateSoldier.ToString());
                }
                foreach (var commando in commandosList)
                {
                    Console.WriteLine(commando.ToString());
                }
                foreach (var leutenantGeneral in leutenantGeneralsList)
                {
                    Console.WriteLine(leutenantGeneral.ToString());
                }
                foreach (var engineer in engineersList)
                {
                    Console.WriteLine(engineer.ToString());
                }
                foreach (var spy in spiesList)
                {
                    Console.WriteLine(spy.ToString());
                }
                Materials.LINE();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Materials.LINE();
            }
        

        } 
    }
}

/*
Private 1 Pesho Peshev 22,22
Commando 13 Stamat Stamov 13,1 Airforces
Private 222 Toncho Tonchev 80,08
LeutenantGeneral 3 Joro Jorev 100 222 1
End

Engineer 7 Pencho Penchev 12,23 Marines Boat 2 Crane 17
Commando 19 Penka Ivanova 150,15 Airforces HairyFoot finished Freedom inProgress
End
 
 */