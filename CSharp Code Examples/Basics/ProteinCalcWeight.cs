using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Code_Examples
{
    class ProteinCalcWeight
    {
        //Authors: Daniel Kucharski
        //Calculates remomended Protein intake on weight
        public static void run()
        {
            while (true)
            {
                // Prompt user to enter their weight in pounds
                Console.Write("Enter your weight in pounds: ");
                string weightInput = Console.ReadLine();

                // Parse weight input
                if (double.TryParse(weightInput, out double weightInPounds))
                {
                    // Calculate protein requirement by dividing weight by 20 and multiplying by 7
                    double proteinByWeightMethod1 = (weightInPounds / 20) * 7;

                    // Calculate protein requirement by multiplying weight by 0.36
                    double proteinByWeightMethod2 = weightInPounds * 0.36;

                    // Display the results
                    Console.WriteLine();
                    Console.WriteLine($"Recommended protein intake:");
                    Console.WriteLine($"{proteinByWeightMethod1:F2} to {proteinByWeightMethod2:F2} grams per day");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid weight in pounds.");
                    Console.WriteLine();
                }
            }
            Console.ReadLine(); // Keep console window open
        }
    }
}
