using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public static void gameTester()
        {
            //creates a new game and starts it
            Game testGame = new Game(); 
            var testResults = Game.startGame();
            Debug.Assert(testResults.Item4 <= 18 & testResults.Item4 >= 3, "The total was out of bounds."); //tests the total to see if it is possible and returns an error if not
            dieTester(); //calls the method to test the game
        }

        public static void dieTester()
        {
            //creates a new die and rolls it
            Die testDie = new Die(); 
            var testRoll = testDie.diceRoller();
            Debug.Assert(testRoll <= 6 & testRoll >= 1, "The roll was out of bounds."); // tests the roll to see if it is between 1 and 6 and resturn an error if not
        }
    }
}
