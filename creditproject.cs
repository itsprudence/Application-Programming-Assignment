using System;
class CreditEvaluator
{
    static void Main()
    {
        int customerNumber = 1;

        while (true)
        {
            Console.WriteLine($"\nCustomer {customerNumber}:");

            Console.Write("Enter credit limit (or type 'exit' to stop): ");
            string creditInput = Console.ReadLine();
            if (creditInput.ToLower() == "exit")
                break;
            double creditLimit = double.Parse(creditInput);
            Console.Write("Enter price of item: ");
            double price = double.Parse(Console.ReadLine());

            double totalCost;
            int quantity;

            while (true)
            {
                Console.Write("Enter quantity of item (Enter 0 to exit transaction): ");
                quantity = int.Parse(Console.ReadLine());

                if (quantity == 0)
                {
                    Console.WriteLine("Transaction cancelled. Moving to next customer...\n");
                    break; // Exit the loop and move to the next customer
                }

                totalCost = price * quantity;

                if (totalCost > creditLimit)
                {
                    Console.WriteLine("Sorry, you cannot purchase goods worth such a value on credit.");
                    Console.WriteLine("Please enter a new quantity or enter 0 to cancel.");
                }
                else
                {
                    Console.WriteLine("Thank You for purchasing from us.");
                    Console.WriteLine($"Total purchase value: {totalCost:C}\n");
                    break; // Exit the loop and move to the next customer
                }
            }
            customerNumber++;
        }
    }
}