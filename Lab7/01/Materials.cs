namespace TELEPHONYPROGRAM
{
    class Materials
    {
        public static void Displayer()
        {
            string data = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");
            Console.Write(data);
            Console.Write("         -WELCOME TO TELEPHONY COMPANY-        ");
            Console.WriteLine(time);
            LINE();
        }

        public static void LINE()
        {
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public static void SmallLine()
        {
            Console.WriteLine("------------------------");
        }
    }

    interface Calling
    {
        void Calling(string[] input);
    }

    interface Browsing
    {
        void Browsing(string[] input);
    }
}
