using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 5, 1, 4, 2, 3 };

        // Keep numbers greater than 2 (Where)
        // Arrange the result in descending order (OrderByDescending)
        // Transform the result by squaring each number (Select)
        var result = numbers
            .Where(n => n > 2)
            .OrderByDescending(n => n)
            .Select(n => n * n);

        Console.WriteLine("Original List: { 5, 1, 4, 2, 3 }");
        Console.WriteLine("Filtered ( > 2), Sorted (Descending), and Squared (n * n):");

        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }
}