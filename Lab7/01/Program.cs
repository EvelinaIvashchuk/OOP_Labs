using System.Data;
using System.Globalization;

namespace TELEPHONYPROGRAM
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Materials.Displayer();
                Console.Write("Write numbers: ");  string[] input_1 = Console.ReadLine().Split();
                Console.Write("Write sites: ");  string[] input_2 = Console.ReadLine().Split();

                Telephony telephony = new Telephony();
            
                telephony.Calling(input_1);
                Materials.SmallLine();
                telephony.Browsing(input_2);

                Console.WriteLine("Well Done!");

                Materials.LINE();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine();
                Materials.LINE();
            }
        }


    }

}
