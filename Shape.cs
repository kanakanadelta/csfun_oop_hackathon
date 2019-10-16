using System;

namespace Hackathon
{
    public class Shape
    {
        private string handSign;
    
        //constructor
        public Shape(string handSign){
            HandSign = handSign;
        }

        // Getters and Setters
        public string HandSign{get;set;}

        //method
        public string CheckResult(Shape playerHand, Shape opponentHand)
        {
            if(playerHand.HandSign == "rock")
            {
                if(opponentHand.HandSign == "rock")
                    return "draw";
                else if(opponentHand.HandSign == "paper")
                    return "lose";
                else
                    return "win";
            } //
            else if(playerHand.HandSign == "paper")
            {
                if(opponentHand.HandSign == "paper")
                    return "draw";
                else if(opponentHand.HandSign == "scissors")
                    return "lose";
                else
                    return "win";
            } //
            else
            {
                if(opponentHand.HandSign == "scissors")
                    return "draw";
                else if(opponentHand.HandSign == "rock")
                    return "lose";
                else
                    return "win";
            }
        }
    }
}