using System;

namespace _20xTerningSpil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Die!");
            Player p1 = new Player();
            p1.name = "Ole";
            Player p2 = new Player();
            p2.name = "Børge";
            p1.TakeTurn();
            p2.TakeTurn();
            Console.WriteLine(p1.name + " "+ p1.sum);
            Console.WriteLine(p2.name + " " + p2.sum);
            Console.ReadKey();
        }
    }
}
