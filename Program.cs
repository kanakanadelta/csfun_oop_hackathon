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

                System.Console.WriteLine(PlayerArt(player.Hand.HandSign));
                System.Console.WriteLine(OpponentArt(opponent.Hand.HandSign));

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


                    System.Console.WriteLine($"{player.Hand.HandSign} beats {opponent.Hand.HandSign}");
                    System.Console.WriteLine($"{player.Name} wins! {opponent.Name} loses (their life)!");

                    System.Console.WriteLine("\nYou can't play rock paper scissors with just one person. That would be lonely. Game Over.");

                    opponent.Living = false;
                    System.Console.WriteLine("\n"+player.GetWinLoss());
                    System.Console.WriteLine(opponent.GetWinLoss());
                    return;
                }
                else if(Result == "die")
                {
                    player.LossCount++;
                    opponent.WinCount++;

                    
                    System.Console.WriteLine($"{opponent.Hand.HandSign} beats {player.Hand.HandSign}");
                    System.Console.WriteLine($"{opponent.Name} wins! {player.Name} loses (their life)!");
                    
                    System.Console.WriteLine("\nYou can't play rock paper scissors with just one person. That would be lonely. Game Over.");

                    player.Living = false;
                    System.Console.WriteLine("\n"+player.GetWinLoss());
                    System.Console.WriteLine(opponent.GetWinLoss());
                    return;
                } else if (Result == "shootout")
                {
                    System.Console.WriteLine("A shoot out ensued. You both killed each other to death and lose your lives. Game over. Forever.");

                    player.LossCount++;
                    opponent.LossCount++;

                    System.Console.WriteLine("\n Good Job.");
                    player.Living = false;
                    opponent.Living = false;

                    System.Console.WriteLine("\n"+player.GetWinLoss());
                    System.Console.WriteLine(opponent.GetWinLoss());
                    return;
                }
                
                player.Hand = null;
                opponent.Hand = null;

                System.Console.WriteLine("\n"+player.GetWinLoss());
                System.Console.WriteLine(opponent.GetWinLoss());
                return;
            }
            else
            {
                System.Console.WriteLine("Error occured... try again!!!");
                return;
            }
        }

        public String PlayerArt(string sign)
        {
            if(sign == "rock")
            {
                return "\n    _______\n---'   ____)\n      (_____)\n      (_____)\n      (____)\n---.__(___)";
            }
            else if (sign == "paper")
            {
                return "\n     _______\n---'    ____)____\n           ______)\n          _______)\n         _______)\n---.__________)\n";
            } else if (sign == "scissors")
            {
                return "\n    _______\n---'   ____)____\n          ______)\n       __________)\n      (____)\n---.__(___)\n";
            } else {
                return "\n          ^\n         | |\n       @#####@\n     (###   ###)-.\n   .(###     ###) \\\n  /  (###   ###)   )\n (=-  .@#####@|_--\"\n /\\    \\_|l|_/ (\\\n(=-\\     |l|    /\n \\  \\.___|l|___/\n /\\      |_|   /\n(=-\\._________/\\\n \\             /\n   \\._________/\n     #  ----  #\n     #   __   #\n     \\########/\n";
            }
        }

        public String OpponentArt(string sign)
        {
            if(sign == "rock")
            {
                return "\n  _______    \n (____   '---\n(_____)      \n(_____)      \n (____)      \n  (___)__.---\n";
            }
            else if (sign == "paper")
            {
                return "\n       _______    \n  ____(____   '---\n (______          \n(_______          \n (_______         \n   (__________.---\n";
            } else if (sign == "scissors")
            {
                return "\n       _______    \n  ____(____   '---\n (______          \n(__________       \n      (____)      \n       (___)__.---\n";
            } else {
                return "\n          ^\n         | |\n       @#####@\n     (###   ###)-.\n   .(###     ###) \\\n  /  (###   ###)   )\n (=-  .@#####@|_--\"\n /\\    \\_|l|_/ (\\\n(=-\\     |l|    /\n \\  \\.___|l|___/\n /\\      |_|   /\n(=-\\._________/\\\n \\             /\n   \\._________/\n     #  ----  #\n     #   __   #\n     \\########/\n";
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("\n ______              __         ______                           \n|   __ \\.-----.----.|  |--.    |   __ \\.---.-.-----.-----.----.  \n|      <|  _  |  __||    < __  |    __/|  _  |  _  |  -__|   _|_ \n|___|__||_____|____||__|__|  | |___|   |___._|   __|_____|__||  |\n                           |_|               |__|             |_|\n _______        __                                __ \n|     __|.----.|__|.-----.-----.-----.----.-----.|  |\n|__     ||  __||  ||__ --|__ --|  _  |   _|__ --||__|\n|_______||____||__||_____|_____|_____|__| |_____||__|\n");

            //////////////////////
            // Pick your names //
            System.Console.WriteLine("player 1, enter your name:");
            string n1 = Console.ReadLine();
            System.Console.WriteLine("player 2, enter your name:");
            string n2 = Console.ReadLine();
            // name set
            Player p1 = new Player(n1);
            Player p2 = new Player(n2);

            ///////////////////////
            // GAME LOOP STARTS //
            /////////////////////

            do{
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
            System.Console.WriteLine("\rJan, Ken, Poi!\n");

            p.Play(p2, p1);
            } while(p1.Living == true && p2.Living == true);


        }
    }
}
