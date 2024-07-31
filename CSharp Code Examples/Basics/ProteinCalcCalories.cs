using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class ProteinCalcCalories
    {
        //Authors: Daniel Kucharski
        //Calculates remomended Protein intake dependant on calories
        public static void run()
        {
            while (true)
            {
                Console.Write("Enter your daily calorie intake: ");
                string calorieInput = Console.ReadLine();

                // Parse calorie input
                if (double.TryParse(calorieInput, out double dailyCalories))
                {
                    // Calculate the range of protein intake based on 10% to 35% of daily calories
                    double minProteinCalories = dailyCalories * 0.10;
                    double maxProteinCalories = dailyCalories * 0.35;

                    // Convert calorie range to grams of protein 
                    double minProteinGrams = minProteinCalories / 4;
                    double maxProteinGrams = maxProteinCalories / 4;

                    // Display the results for calorie based methods
                    Console.WriteLine();
                    Console.WriteLine($"Based on your daily calorie intake of {dailyCalories} calories:");
                    Console.WriteLine($"Recommended protein intake range: {minProteinGrams:F2} to {maxProteinGrams:F2} grams per day");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid calorie intake.");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
