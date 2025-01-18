using System;

namespace Mission1Hilton
{
    class DiceRoller
    {
        private Random _rng = new Random();

        /// <summary>
        /// Simulates rolling two 6-sided dice for the specified number of rolls.
        /// Returns an array of frequencies where index 0 represents sum=2, 
        /// index 1 represents sum=3, ..., index 10 represents sum=12.
        /// </summary>
        public int[] RollDice(int numberOfRolls)
        {
            // Array to track frequencies for sums 2..12 (11 possible sums)
            int[] frequencies = new int[11];

            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = _rng.Next(1, 7); // 1-6
                int die2 = _rng.Next(1, 7); // 1-6

                int sum = die1 + die2; // possible sums 2-12

                // Increment the frequency at the (sum-2) index
                frequencies[sum - 2]++;
            }

            return frequencies;
        }
    }
}