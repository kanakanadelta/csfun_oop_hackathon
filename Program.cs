using System;

namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jan, Ken, Poi!");
            Player p1 = new Player("Player 1");
            Player p2 = new Player("Player 2");

            p1.SetShape('p');
            p2.SetShape('s');
            p1.Play(p2);
            System.Console.WriteLine(p1.LossCount);
            System.Console.WriteLine(p2.WinCount);
        }
    }
}
