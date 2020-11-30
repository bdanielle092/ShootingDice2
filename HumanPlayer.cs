using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Enter a number for your Roll");
            Console.ReadLine();
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}