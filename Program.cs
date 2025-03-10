using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up console colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            
            // Display welcome message with title color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ForegroundColor = ConsoleColor.White;
            
            try
            {
                // Get package weight from user
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter the package weight:");
                Console.ForegroundColor = ConsoleColor.White;
                float weight = float.Parse(Console.ReadLine());
                
                // Check weight restriction
                if (weight > 50)
                {
                    // Display error in red
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    return;
                }
                
                // Get package dimensions
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter the package width:");
                Console.ForegroundColor = ConsoleColor.White;
                float width = float.Parse(Console.ReadLine());
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter the package height:");
                Console.ForegroundColor = ConsoleColor.White;
                float height = float.Parse(Console.ReadLine());
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter the package length:");
                Console.ForegroundColor = ConsoleColor.White;
                float length = float.Parse(Console.ReadLine());
                
                // Check dimensions total
                if (width + height + length > 50)
                {
                    // Display error in red
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    return;
                }
                
                // Calculate shipping quote
                float quote = (width * height * length * weight) / 100;
                
                // Display quote in green
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
                Console.WriteLine("Thank you!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (FormatException)
            {
                // Handle input format errors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Please enter valid numeric values.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                // Handle other unexpected errors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                // Reset console colors and wait for key press
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadLine();
            }
        }
    }
}