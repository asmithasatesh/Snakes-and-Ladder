using System;

namespace SnakesNLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollDice,playerPosition = 0;
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Dice number is : " + rollDice);
        }
    }
}
