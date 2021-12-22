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
            Console.WriteLine("Welcome to number game. Press 'q' at any point in game to quit");
            Console.WriteLine("Guess a number between 0 and 100");
            do
            {
                Console.WriteLine("You have " + (guessCount) + " chance(s) to guess");
                try
                {
                    string parser = Console.ReadLine();
                    if (parser == "q")
                    {
                        break;
                    }
                    int guessedNum = int.Parse(parser);

                    if (guessCount == 1)
                    {
                        if (guessedNum == val)
                        {
                            guessCount--;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Actual number was " + val);
                            break;
                        }
                        
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
                        result = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a number! Please enter a number");
                }

            }
            while (result == false);
            {
                if (guessCount == 1)
                {
                    Console.WriteLine("Too many chances were given!");
                }
                else if (guessCount == 0)
                {
                    Console.WriteLine("That was very close! got it right on the last chance!");
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
