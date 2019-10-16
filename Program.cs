using System;
using System.IO;

namespace Hackathon
{
    
    class Program
    {
        public void Play(Player opponent, Player player)
        {
            if(player.Hand != null && opponent.Hand !=null)
            {
                // retrieve result from Hand method
                string Result = player.Hand.CheckResult(player.Hand, opponent.Hand);

                if(Result == "win")
                {
                    player.WinCount++;
                    opponent.LossCount++;
                    System.Console.WriteLine($"{player.Hand.HandSign} beats {opponent.Hand.HandSign}");
                    System.Console.WriteLine($"{player.Name} wins! {opponent.Name} loses!");
                }
                else if(Result == "lose")
                {
                    player.LossCount++;
                    opponent.WinCount++;
                    System.Console.WriteLine($"{opponent.Hand.HandSign} beats {player.Hand.HandSign}");
                    System.Console.WriteLine($"{opponent.Name} wins! {player.Name} loses!");
                }
                else if(Result == "draw")
                {
                    System.Console.WriteLine("JYNX!");
                    System.Console.WriteLine($"You both picked {player.Hand.HandSign}");
                    System.Console.WriteLine($"No one wins at life!");
                }
                else if(Result == "live")
                {
                    player.WinCount++;
                    opponent.LossCount++;
                    opponent = null;
                    System.Console.WriteLine($"{player.Hand.HandSign} beats {opponent.Hand.HandSign}");
                    System.Console.WriteLine($"{player.Name} wins! {opponent.Name} loses!");
                }
                else if(Result == "die")
                {
                    player.LossCount++;
                    opponent.WinCount++;
                    
                    System.Console.WriteLine($"{opponent.Hand.HandSign} beats {player.Hand.HandSign}");
                    System.Console.WriteLine($"{opponent.Name} wins! {player.Name} loses!");
                }
                
                player.Hand = null;
                opponent.Hand = null;


                return;
            }
            else
            {
                System.Console.WriteLine("Error occured... try again!!!");
                return;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Jan, Ken, Poi!");
            //////////////////////
            // Pick your names //
            System.Console.WriteLine("player 1, enter your name:");
            string n1 = Console.ReadLine();
            System.Console.WriteLine("player 2, enter your name:");
            string n2 = Console.ReadLine();
            // name set
            Player p1 = new Player(n1);
            Player p2 = new Player(n2);

            //////////////////////
            // Pick your shape //
            // Player 1
            System.Console.WriteLine($"Shape up, {n1}");
            ConsoleKeyInfo keyPress1 = Console.ReadKey();
            p1.SetShape(keyPress1.KeyChar);
            System.Console.WriteLine("\rPlayer 1 ready!");
            // Player 2
            System.Console.WriteLine($"Shape up, {n2}");
            ConsoleKeyInfo keyPress2 = Console.ReadKey();
            System.Console.WriteLine("\rPlayer 2 ready!");
            p2.SetShape(keyPress2.KeyChar);

            //////////////////////
            // Get ready...... //
            System.Console.WriteLine("\rPress any key to  continue!");
            ConsoleKeyInfo keyPress3 = Console.ReadKey();
            System.Console.WriteLine("\rJan, Ken, Poi!");

            p.Play(p2, p1);


        }
    }
}
