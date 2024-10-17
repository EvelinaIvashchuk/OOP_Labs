using _04;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        Engine engine = new Engine();
        engine.Run();
    }
}

/*
Create;Common;Axe;Axe of Misfortune
Add;Axe of Misfortune;0;Chipped;Ruby
Print;Axe of Misfortune
END

Create;Common;Axe;Axe of Misfortune
Add;Axe of Misfortune;0;Flawless;Ruby
Remove;Axe of Misfortune;0
Print;Axe of Misfortune
END
 
 
 */