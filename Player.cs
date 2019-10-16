using System;

namespace Hackathon
{
    public class Player : IShape
    {
        public string Name;
        private Shape hand;
        private int winCount;
        private int lossCount;

        public Player(string name)
        {
            Name = name;
            WinCount = 0;
            LossCount = 0;
        }

        //Getters and Setters

        public Shape Hand{get;set;}
        public int WinCount{get;set;}
        public int LossCount{get;set;}

        //Methods
        public Shape SetShape(char c){
            if(c == 'r' || c == 'R')
                Hand = new Shape("rock");
            else if(c == 'p' || c == 'P')
                Hand =  new Shape("paper");
            else if(c == 's' || c == 'S')
                Hand = new Shape("scissors");
            else if(c == 'g' || c == 'G')
                Hand = new Shape("scissors");
            else {
                System.Console.WriteLine("Invalid hand shape!!!");
                return null;
            }
            return Hand;
        }

        public void Play(Player opponent)
        {
            if(Hand != null && opponent.Hand !=null)
            {
                // retrieve result from Hand method
                string Result = Hand.CheckResult(Hand, opponent.Hand);

                if(Result == "win")
                {
                    WinCount++;
                    opponent.LossCount++;
                    System.Console.WriteLine($"{Hand.HandSign} beats {opponent.Hand.HandSign}");
                    System.Console.WriteLine($"{Name} wins! {opponent.Name} loses!");
                }
                else if(Result == "lose")
                {
                    LossCount++;
                    opponent.WinCount++;
                    System.Console.WriteLine($"{opponent.Hand.HandSign} beats {Hand.HandSign}");
                    System.Console.WriteLine($"{opponent.Name} wins! {Name} loses!");
                }
                else if(Result == "draw")
                {
                    System.Console.WriteLine("JYNX!");
                    System.Console.WriteLine($"You both picked {Hand.HandSign}");
                    System.Console.WriteLine($"No one wins at life!");
                }
                
                Hand = null;
                opponent.Hand = null;


                return;
            }
            else
            {
                System.Console.WriteLine("Error occured... try again!!!");
                return;
            }
        }
    }
}