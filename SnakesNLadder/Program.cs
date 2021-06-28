using System;
using System.Collections.Generic;

namespace SnakesNLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int rollDice,playerPosition = 0;

            //Create random number to roll dice
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Dice number is : " + rollDice);

            //Print user options
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");
            var list = new List<string> { "No Play", "Ladder","Snake"};
            //Use random to check user option
            int index = random.Next(list.Count);
            //Conditions for user options
            if (list[index] == "Ladder") playerPosition += rollDice;
            if (list[index] == "Snake") playerPosition -= rollDice;
            //Print to Console
            Console.WriteLine("Player option is : " + list[index]);
            Console.WriteLine("\n");
            Console.WriteLine("Player current position : " + playerPosition);


        }
    }
}
