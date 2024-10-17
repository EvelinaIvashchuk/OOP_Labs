using _02;

class Program
{
    static void Main()
    {
        try
        {
            Materials.DISPLAY();
            ControlSystem controlSystem = new ControlSystem();
            Materials.Menu();
            Materials.SmallLine();
            int Select = int.Parse(Console.ReadLine());
            Materials.SmallLine();

            switch (Select)
            {
                case 1:
                    controlSystem.WORKING1();
                    string id = Console.ReadLine();
                    controlSystem.NUMFOUND(id);
                    break;

                    case 2:
                    controlSystem.WORKING();
                    int years = int.Parse(Console.ReadLine());
                    controlSystem.AGEFOUND(years);
                    break;
                    case 3:
                    controlSystem.WORKING2();
                    break;
                default:
                    Console.WriteLine("Wrong!");
                    break;
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