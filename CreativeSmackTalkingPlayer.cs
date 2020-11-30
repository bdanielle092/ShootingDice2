using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {

        //creating a list of taunts
        public List<string> ListOfTaunts = new List<string>()
  {
     "I can roll better than you",
     "oh man, You're going down",
     "You lose again"
  };
        public override int Roll()
        {
            //picking a random taunt from the list 
            Random Taunts = new Random();
            int SmackTalk = Taunts.Next(0, ListOfTaunts.Count);
            string Taunt = ListOfTaunts[SmackTalk];
            Console.WriteLine($"{Name} shouts {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}