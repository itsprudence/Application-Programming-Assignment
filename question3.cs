// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int totalRows = 6;  // Defining the number of rows, which is 6

        for (int currentRow = 0; currentRow < totalRows; currentRow++)
        {
            string lineOutput = "";  // Stores the row string instead of directly printing.

            if (currentRow == 0 || currentRow == totalRows - 1)
            {
                // First and last row: '&' with spaces in between
                for (int column = 0; column < totalRows; column++)
                {
                    lineOutput += "&";
                    if (column < totalRows - 1) lineOutput += " ";  // Adding space except at the last '&'
                }
            }
            else
            {
                // Middle rows: '&' appears diagonally, '*' fills the rest
                for (int column = 0; column < totalRows; column++)
                {
                    if (column == currentRow)
                    {
                        lineOutput += "&";
                    }
                    else
                    {
                        lineOutput += "*";  // Stars fill the gaps
                    }

                    if (column < totalRows - 1) lineOutput += " ";  // Keep spacing consistent
                }
            }

            Console.WriteLine(lineOutput);  // Output the row after it's fully built
        }
    }
}

