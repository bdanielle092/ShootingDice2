using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {

        //creating a list of taunts
        private List<string> _ListOfTaunts = new List<string>()
        {
            "I can roll better than you",
            "oh man, You're going down",
            "You lose again"
        };
        public override int Roll()
        {
            //picking a random taunt from the list 
            Random Taunts = new Random();
            int SmackTalk = Taunts.Next(0, _ListOfTaunts.Count);
            string Taunt = _ListOfTaunts[SmackTalk];
            Console.WriteLine($"{Name} shouts {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}