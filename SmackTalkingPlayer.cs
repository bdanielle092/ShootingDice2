using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        //taunt from player 1
        public string Taunt { get; } = "You're going down";
        public override int Roll()
        {
            //player 1 shouting their taunt when they roll
            Console.WriteLine($"{Name} shouts {Taunt}!");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }


}