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
            Die dice = new Die();
            Game game = new Game();
            var diceResults = Game.startGame();
            Console.WriteLine($"You rolled a {diceResults.Item1}, a {diceResults.Item2}, and a {diceResults.Item3}, for a total of {diceResults.Item4}");
            Console.ReadLine();
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */


        }
    }
}
