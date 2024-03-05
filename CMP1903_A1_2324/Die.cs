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

        private Random roll;
        private int newValue;
        //Property

        public Die()
        {
            roll = new Random();
            diceRoller();
        }

        public int CurrentValue
        {
            get { return newValue; }
            private set { newValue = value; }
        }

        //Method
        public int diceRoller()
        {
            newValue = roll.Next(1, 7);
            return newValue;
        }


    }
}

