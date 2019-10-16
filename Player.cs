using System;

namespace Hackathon
{
    public class Player : IShape
    {
        public string Name;
        private Shape hand;
        private int winCount;
        private int lossCount;
        public bool Living = true;

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
                Hand = new Shape("gun");
            else {
                System.Console.WriteLine("Invalid hand shape!!!");
                return null;
            }
            return Hand;
        }

        public string GetWinLoss(){
            string winLoss = $"{Name}: Wins - {WinCount}, Losses - {LossCount}, Life is intact? - {Living}";
            return winLoss;
        }

    }
}