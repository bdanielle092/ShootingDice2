using System;

namespace ShootingDice
{


    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a number with a minimum of 5 so that the players roll is never below that
            return new Random().Next(5, DiceSize) + 1;
        }
    }
}