using System;

namespace CMP1903_A1_2324
{
    // Die Class
    public class Die
    {
        // Stores the random object for number generation
        private Random _rng;

        // Creates a current value integer to store the value of a die
        public int currentValue; 

        // Die class constructor 
        public Die(Random random)
        {
            // Initializes the random object. 
            // Sets the current value of each die to 0
            this._rng = random;
            currentValue = 0;
        }

        // Method to roll each dice. This will then change the current value to a random number
        public int Roll()
        { 
            currentValue = _rng.Next(1, 7); // Assigns current value to a random number between 1 and 6
            return currentValue;
        }
    }
}
