using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("For Loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        Console.WriteLine();

        Console.WriteLine("While Loop:");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine("j = " + j);
            j++;
        }

        Console.WriteLine();

        Console.WriteLine("Foreach Loop:");
        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int num in numbers)
        {
            Console.WriteLine("num = " + num);
        }
    }
}
