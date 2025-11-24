using System;

class Program
{
    static void Main()
    {
        // VARIABLES + DATA TYPES
        int age = 23;
        double salary = 45000.75;
        string name = "Kesavan";
        bool isStudent = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Is Student: " + isStudent);

        // OPERATORS
        int a = 10, b = 3;

        Console.WriteLine("\nArithmetic Operators:");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        Console.WriteLine("\nComparison:");
        Console.WriteLine(a > b);
        Console.WriteLine(a == 10);

        Console.WriteLine("\nLogical:");
        Console.WriteLine(true && false);
        Console.WriteLine(true || false);
    }
}
