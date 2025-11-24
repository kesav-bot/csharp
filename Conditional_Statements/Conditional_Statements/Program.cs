/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine("You are an adult.");
        else
            Console.WriteLine("You are a minor.");

        Console.WriteLine();

        Console.Write("Enter a grade (A/B/C/D): ");
        char grade = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (grade)
        {
            case 'A': Console.WriteLine("Excellent!"); break;
            case 'B': Console.WriteLine("Good Job!"); break;
            case 'C': Console.WriteLine("Needs Improvement."); break;
            case 'D': Console.WriteLine("Failed."); break;
            default: Console.WriteLine("Invalid Grade!"); break;
        }
    }
}
*/


// If - else Statement Example

/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a child.");
        }
    }
}
*/

// Switch Statement Example

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a day number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day number!");
                break;
        }
    }
}
