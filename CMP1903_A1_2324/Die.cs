using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private Random _roll; //makes a new random object 

        //Constructor
        public Die()
        {
            _roll = new Random();
            DiceRoller(); //calls the method to roill the dice
        }

        //Method
        public int DiceRoller()
        {
            int currentValue = _roll.Next(1, 7); //rolls the dice stores the current value
            return currentValue; //returns the value
        }


    }
}

