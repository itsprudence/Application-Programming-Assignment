using System;

class CreditEvaluator
{
    static void Main()
    {
        int customerNumber = 1;

        while (true)
        {
            Console.WriteLine($"\nCustomer {customerNumber}:");

            // Prompt for credit limit
            Console.Write("Enter credit limit (or type 'exit' to stop): ");
            string creditInput = Console.ReadLine();

            if (creditInput.ToLower() == "exit")
                break;

            if (!double.TryParse(creditInput, out double creditLimit) || creditLimit < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid credit limit.");
                continue; // Restart loop for valid input
            }

            // Prompt for item price
            Console.Write("Enter price of item: ");
            if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0)
            {
                Console.WriteLine("Invalid price. Please enter a valid positive number.");
                continue;
            }

            while (true)
            {
                Console.Write("Enter quantity of item (Enter 0 to cancel transaction): ");
                if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 0)
                {
                    Console.WriteLine("Invalid quantity. Enter a valid number.");
                    continue;
                }

                if (quantity == 0)
                {
                    Console.WriteLine("Transaction cancelled. Moving to next customer...\n");
                    break;
                }

                double totalCost = price * quantity;

                if (totalCost > creditLimit)
                {
                    Console.WriteLine("Sorry, your purchase exceeds the credit limit.");
                    Console.WriteLine("Try a smaller quantity or enter 0 to cancel.");
                }
                else
                {
                    Console.WriteLine($"Purchase successful! Total: {totalCost:C}\n");
                    break;
                }
            }

            customerNumber++;
        }

        Console.WriteLine("Thank you for using our service. Goodbye!");
    }
}
