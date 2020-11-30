using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {

        public List<string> Taunts = new List<string>()
  {
     "I can roll better than you",
     "You're going down",
     "I got this "
  };
        public override int Roll()
        {
            int randomTaunt = new Random().Next(Taunts.Count);
            string random = Taunts[randomTaunt];
            Console.WriteLine($"{Name} shouts {Taunts}!");

            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}