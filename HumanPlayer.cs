using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            //ask user to enter a number
            Console.WriteLine("Enter a number for your Roll");
            //user input
            Console.ReadLine();
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}