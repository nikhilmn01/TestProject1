using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.consolePrograms
{
    public class NumberGuessingGame
    { 
        public static void guess()
        {

            Random num = new Random();
            int val = num.Next(0, 100);
            int guessCount = 5;
            bool result = false;
            Console.WriteLine("Guess a number between 0 and 100");
            do
            {
                Console.WriteLine("You have " + (guessCount) + " chance(s) to guess");
                try
                {
                    string parser = Console.ReadLine();
                    int guessedNum = int.Parse(parser);

                    if (guessCount == 1)
                    {
                        Console.WriteLine("Actual number was "+ val);
                        break;
                    }

                    if (guessedNum > val)
                    {
                        Console.WriteLine("Too high! guess lower");
                        guessCount--;
                    }
                    else if (guessedNum < val)
                    {
                        Console.WriteLine("Too low! guess higher");
                        guessCount--;
                    }

                    else if (guessedNum == val)
                    {
                        //Console.WriteLine("actual number is " + val + " you guessed " + guessedNum);
                        result = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a number! Please restart and enter a number");
                }

            }
            while (result == false);
            {
                if (guessCount == 1)
                {
                    Console.WriteLine("Too many chances were given!");
                }
                else if (result == true)
                {
                    Console.WriteLine("You got it right! Good Job");
                }
                Console.WriteLine("GAME OVER!!");
            }

        }

    }
}
