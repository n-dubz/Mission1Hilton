using System;

namespace Mission1Hilton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            
            // Read how many rolls from user
            // Note: Use try-catch or TryParse in real-world apps for validation
            int numberOfRolls = int.Parse(Console.ReadLine());

            // Instantiate the roller
            DiceRoller roller = new DiceRoller();
            
            // Perform the simulation
            int[] rollResults = roller.RollDice(numberOfRolls);

            // Print the results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

            for (int sum = 2; sum <= 12; sum++)
            {
                // Calculate the percentage for this sum
                double percentage = (rollResults[sum - 2] / (double)numberOfRolls) * 100;
                
                // Convert that percentage to number of asterisks (truncate to int)
                int starsCount = (int)Math.Floor(percentage);
                
                // Build the line of stars
                string stars = new string('*', starsCount);

                // Print results in the desired format, e.g. "2: ***"
                Console.WriteLine($"{sum}: {stars}");
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}