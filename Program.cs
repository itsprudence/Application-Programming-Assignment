namespace Ass_Q5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int salesmenCount = 10;
            int itemsCount = 5;
            string[] salesmen = new string[salesmenCount];
            int[,] sales = new int[salesmenCount, itemsCount]; // 2D array for sales data
            int[] totalSales = new int[salesmenCount];
            int grandTotal = 0;

            for (int i = 0; i < salesmenCount; i++)
            {
                Console.Write("Enter salesman name: ");
                salesmen[i] = Console.ReadLine();

                int total = 0;
                for (int j = 0; j < itemsCount; j++)
                {
                    // Loop for item sales with basic validation for integer input
                    while (true)
                    {
                        Console.Write($"Enter sales for {salesmen[i]} (Item {j + 1}): ");
                        if (int.TryParse(Console.ReadLine(), out int sale))
                        {
                            sales[i, j] = sale;
                            total += sale;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter a valid integer for sales.");
                        }
                    }
                }
                totalSales[i] = total;
                grandTotal += total;
            }

            // Sales report
            Console.WriteLine("\nSales Report:");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Name\t\tItem1\tItem2\tItem3\tItem4\tItem5\tTotalSales");
            Console.WriteLine("------------------------------------------------------");

            for (int i = 0; i < salesmenCount; i++)
            {
                Console.Write($"{salesmen[i]}\t");

                for (int j = 0; j < itemsCount; j++)
                {
                    Console.Write($"{sales[i, j]}\t");
                }
                Console.WriteLine($"{totalSales[i]}");
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Grand Total Sales: \t\t\t\t\t\t{grandTotal}");
        }
    }
}
