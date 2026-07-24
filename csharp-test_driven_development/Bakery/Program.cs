using System;
using Bakery.Models;

namespace Bakery
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Pierre's Bakery");
            Console.WriteLine("Bread is $5 per loaf. Buy 2, get 1 free.");
            Console.WriteLine("Pastries are $2 each. Buy 3, get 1 free.");

            bool continueOrdering = true;
            while (continueOrdering)
            {
                int loaves = ReadNonNegativeQuantity("How many loaves of bread?");
                int pastries = ReadNonNegativeQuantity("How many pastries?");

                Bread bread = new Bread(loaves);
                Pastry pastry = new Pastry(pastries);
                float total = bread.CalculateCost() + pastry.CalculateCost();

                Console.WriteLine($"The total cost is ${total}.");
                Console.WriteLine("Order again? (yes/no)");
                continueOrdering = string.Equals(
                    Console.ReadLine()?.Trim(),
                    "yes",
                    StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine("Goodbye.");
        }

        private static int ReadNonNegativeQuantity(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
                {
                    return quantity;
                }

                Console.WriteLine("Input only accepts numbers 0 or greater.");
            }
        }
    }
}
