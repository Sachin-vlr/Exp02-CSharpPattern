using System;  // Importing necessary namespace

public class Exercise33  // Declaration of the Exercise33 class
{
    public static void Main()  // Main method, entry point of the program
    {
        int no_row, c = 1, blk, i, j;  // Declaration of variables

        Console.Write("\n\n");  // Displaying new lines
        Console.Write("Display the Pascal's triangle:\n");  // Displaying the purpose of the program
        Console.Write("--------------------------------\n\n");  // Displaying a separator and new lines

        Console.Write("Input number of rows: ");  // Prompting the user to input the number of rows
        no_row = Convert.ToInt32(Console.ReadLine());  // Reading the number entered by the user

        // Loop to create and display Pascal's triangle
        for (i = 0; i < no_row; i++)
        {
            for (blk = 1; blk <= no_row - i; blk++)
                Console.Write("  ");  // Adding spaces for formatting the triangle

            for (j = 0; j <= i; j++)
            {
                if (j == 0 || i == 0)
                    c = 1;  // First and last elements in a row of Pascal's triangle are always 1
                else
                    c = c * (i - j + 1) / j;  // Calculating binomial coefficient

                Console.Write("{0}   ", c);  // Displaying the current value of c in the triangle
            }
            Console.Write("\n");  // Moving to the next line for the new row
        }
    }
}
