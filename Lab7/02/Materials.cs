namespace _02
{
    class Materials
    {
        public static void DISPLAY()
        {
            string data = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");
            Console.Write(data);
            Console.Write("          -WELCOME TO THE PEOPLE CONTROL SYSTEM-          ");
            Console.WriteLine(time);
            LINE();
        }

        public static void LINE()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
        }

        public static void SmallLine()
        {
            Console.WriteLine("------------------------");
        }

        public static void Menu()
        {
            Console.WriteLine("1. ID Identifier");
            Console.WriteLine("2. Birthday Identifier");
            Console.WriteLine("3. Procurement of products");
        }
    }
}