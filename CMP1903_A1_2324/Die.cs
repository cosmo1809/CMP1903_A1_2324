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
        private int _currentValue;

        public Die()
        {
            roll = new Random();
            diceRoller();
        }

        //Property
        public int currentValue
        {
            get { return _currentValue; }
            set { _currentValue = value; }
        }

        //Method
        public int diceRoller()
        {
            int currentValue = roll.Next(1, 7);
            return currentValue;
        }


    }
}

