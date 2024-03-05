using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public static Tuple<int, int, int, int> startGame() //method to perform all the operations of the game
        {
            Die dice = new Die(); //makes a new dice to be rolled
            //declaring all the variables for the calulations
            int total = 0;
            int newRoll;
            int[] savedRolls = new int[3]; //creates an array for the 3 rolls

            for (int i = 0; i < 3; i++) //looped to roll 3 times
            {
                newRoll = dice.diceRoller(); //rolls the dice
                savedRolls[i] = newRoll; //saves the result to the correct array position
                total = total + newRoll; //adds to the total
            }
            //returns all the values as a tuple
            return Tuple.Create(savedRolls[0], savedRolls[1], savedRolls[2], total);
        }







    }
}
