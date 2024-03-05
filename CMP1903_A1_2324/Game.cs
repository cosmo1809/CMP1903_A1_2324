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
        public static Tuple<int, int, int, int> startGame()
        {
            Die dice = new Die();
            int total = 0;
            int newRoll;
            int[] savedRolls = new int[3];
            for (int i = 0; i < 3; i++)
            {
                newRoll = dice.diceRoller();
                savedRolls[i] = newRoll;
                Console.WriteLine(newRoll.ToString());
                total = total + newRoll;
            }
            int roll1 = savedRolls[0];
            int roll2 = savedRolls[1];
            int roll3 = savedRolls[2];
            return Tuple.Create(roll1, roll2, roll3, total);
        }







    }
}
