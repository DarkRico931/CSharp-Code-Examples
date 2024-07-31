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
                // Asks user to select a weight type
                Console.Write("Do you want to enter your weight in Pounds or Kilograms? \n(1) Pounds\n(2) Kilograms\n");
                string UnitChoice = Console.ReadLine().Trim().ToUpper();

                double weightInPounds;

                if (UnitChoice == "1")
                {
                    // Asks user to input weight in pounds
                    Console.Write("Enter your weight in pounds: ");
                    string weightInput = Console.ReadLine();
                    if (double.TryParse(weightInput, out weightInPounds))
                    {
                        // No conversion needed
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid weight in pounds.");
                        Console.WriteLine();
                        continue;
                    }
                }
                else if (UnitChoice == "2")
                {
                    // Asks user to input weight in Kilograms
                    Console.Write("Enter your weight in kilograms: ");
                    string weightInput = Console.ReadLine();
                    if (double.TryParse(weightInput, out double weightInKilograms))
                    {
                        // Convert kilograms to pounds
                        weightInPounds = weightInKilograms * 2.205;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid weight in kilograms.");
                        Console.WriteLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter (1) for pounds or (2) for kilograms.");
                    Console.WriteLine();
                    continue;
                }


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
            Console.ReadLine(); // Keep console window open
        }
    }
}
