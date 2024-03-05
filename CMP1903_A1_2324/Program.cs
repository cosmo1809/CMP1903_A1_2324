using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            
            Game game = new Game(); //creates a new game using the game class
            var diceResults = Game.startGame(); //collects the results of the game as a tuple from the game class

            //outputs the results of the game with each number rolled and a total
            Console.WriteLine($"You rolled a {diceResults.Item1}, a {diceResults.Item2}, and a {diceResults.Item3}, for a total of {diceResults.Item4}");
            Console.WriteLine("Press enter to test your values for any errors, if none are found the program will end.");
            Console.ReadLine();

            Testing.gameTester(); //uses the testing class to find any erroneous results
        }
    }
}
