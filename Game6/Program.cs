namespace Game6
{
    internal class Program
    {
        public static void Main()
        {
            Game.persons = new List<Game>();
            Console.WriteLine("");
            Console.WriteLine("                                                       ~           ");
            Console.WriteLine("                                                INSPECTOR MORS");
            Console.WriteLine("                                                the  videogame");
            Console.WriteLine("                                                       ~           ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                          press ENTER,  чтобы начать.");
            Console.ReadLine();
            Persmenu.Menu();
        }
    }
}