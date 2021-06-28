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

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //Conditions for user options
            while (playerPosition <= 100)
            {
                rollDice = random.Next(1, 7);
                Console.WriteLine("Dice number is : " + rollDice);

                //Print user options
                Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");
            
                //Use random to check user option
                int index = random.Next(list.Count);
                Console.WriteLine("Player option is : " + list[index]);
                if (playerPosition + rollDice < 100  )
                {
                    if (list[index] == "Ladder") playerPosition += rollDice;
                    if (list[index] == "Snake") playerPosition -= rollDice;
                }
                else if (playerPosition + rollDice == 100)
                {
                    playerPosition += rollDice;
                    break;
                }
                if (playerPosition < 0)
                {
                    playerPosition = 0;
                }
                //Print to Console
                Console.WriteLine("\n");
                Console.WriteLine("Player current position : " + playerPosition);
            }
            Console.WriteLine("Final position is :" + playerPosition);


        }
    }
}
