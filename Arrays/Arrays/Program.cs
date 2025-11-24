using System;

class Program
{
    static void Main()
    {
        // SINGLE-DIMENSIONAL ARRAY

        Console.WriteLine(" Single Dimensional Array ");

        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine();

        // TWO-DIMENSIONAL ARRAY (2D)

        Console.WriteLine(" Two Dimensional Array ");

        int[,] matrix = {
            { 1, 2 },
            { 3, 4 }
        };

        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // JAGGED ARRAY (Array of Arrays)
        Console.WriteLine(" Jagged Array ");

        int[][] jagged = new int[3][];

        jagged[0] = new int[] { 1, 2, 3 };
        jagged[1] = new int[] { 10, 20 };
        jagged[2] = new int[] { 100, 200, 300 };

        for (int i = 0; i < jagged.Length; i++)
        {
            Console.Write("Row " + i + ": ");

            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nEnd of Array Demo");
    }
}
