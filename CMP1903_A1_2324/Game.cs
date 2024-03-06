using System;

namespace DieGame_Assessment_1
{
    // Game class
    public class Game
    {
        // Stores the random object for number generation
        private Random _rng;
        // Creates the three public die objects
        public Die die1;
        public Die die2;
        public Die die3;
        
        // Game class constructor
        public Game()
        {
            // Initliaze the random object
            _rng = new Random();
            // Creates the three dice objects (die1, die2 and die3)
            die1 = new Die(_rng);
            die2 = new Die(_rng);
            die3 = new Die(_rng);
        }

        // Play method
        public int Play()
        {
            // Creates a new integer variable to store the total value of the dice
            int total = 0;
            
            // Rolls the three dice using the roll method and adds each value to the total
            total += die1.Roll();
            total += die2.Roll();
            total += die3.Roll();
            
            // Displays the individual dice values
            Console.WriteLine("Individual die rolls:"); 
            Console.WriteLine("Die 1: " + die1.currentValue);
            Console.WriteLine("Die 2: " + die2.currentValue);
            Console.WriteLine("Die 3: " + die3.currentValue);
            
            // Displays the total of the three dice
            Console.WriteLine("Total of the three dice rolls: " + total);
            
            return total;
        }
    }
}
