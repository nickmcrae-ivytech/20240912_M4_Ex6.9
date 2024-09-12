using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables to track the sales totals
            double totalDanielle = 0, totalEdward = 0, totalFrancis = 0, saleAmount = 0;
            string inputInitial;
        
            while (true)
            {
                // Prompt the user for a salesperson's initial
                Console.Write("Enter salesperson initial (D, E, F) or Z to quit: ");
                inputInitial = Console.ReadLine().ToUpper();
        
                // Exit loop if the user types Z
                if (inputInitial == "Z")
                {
                    break;
                }
        
                // Validate the initial and process sale amount
                if (inputInitial == "D" || inputInitial == "E" || inputInitial == "F")
                {
                    Console.Write("Enter the sale amount: ");
                    if (double.TryParse(Console.ReadLine(), out saleAmount))
                    {
                        switch (inputInitial)
                        {
                            case "D":
                                totalDanielle += saleAmount;
                                break;
                            case "E":
                                totalEdward += saleAmount;
                                break;
                            case "F":
                                totalFrancis += saleAmount;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid sale amount. Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid initial. Please enter D, E, F, or Z to quit.");
                }
            }
        
            // Calculate the grand total
            double grandTotal = totalDanielle + totalEdward + totalFrancis;
        
            // Determine the highest total salesperson
            string highestSalesperson;
            double highestTotal = Math.Max(totalDanielle, Math.Max(totalEdward, totalFrancis));
        
            if (highestTotal == totalDanielle)
            {
                highestSalesperson = "Danielle";
            }
            else if (highestTotal == totalEdward)
            {
                highestSalesperson = "Edward";
            }
            else
            {
                highestSalesperson = "Francis";
            }
        
            // Display the results
            Console.WriteLine("\nSales Summary:");
            Console.WriteLine($"Danielle's Total: {totalDanielle:C}");
            Console.WriteLine($"Edward's Total: {totalEdward:C}");
            Console.WriteLine($"Francis's Total: {totalFrancis:C}");
            Console.WriteLine($"Grand Total for all sales: {grandTotal:C}");
            Console.WriteLine($"Highest salesperson: {highestSalesperson} with {highestTotal:C}");
            Console.WriteLine("--------------------");
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey();
        }
    }
}
