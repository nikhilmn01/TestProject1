using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.consolePrograms;


NumberGuessingGame.guess();

string restartGame;
bool yn = false;
do
{
    Console.WriteLine("Want to play again? enter y for yes and press anything else for no");
    restartGame = Console.ReadLine();
    if (restartGame == "y")
    {
        NumberGuessingGame.guess();
    }
    else
    {
        Console.WriteLine("Good Bye!");
        yn = true;
    }
}while(yn == false);
