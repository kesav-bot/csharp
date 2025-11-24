using System;

class Program
{
    // Method with no parameters
    static void Greet()
    {
        Console.WriteLine("Hello! Welcome to Methods.");
    }

    //  Method with parameters
    static void PrintName(string name)
    {
        Console.WriteLine("Your name is: " + name);
    }

    // Method with return value
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method with multiple parameters
    static void StudentDetails(string name, int age)
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Age: " + age);
    }

    // Method Overloading - Same method name, different parameters
    static void Show()
    {
        Console.WriteLine("Show() called");
    }

    static void Show(string msg)
    {
        Console.WriteLine("Show(string): " + msg);
    }

    static void Main()
    {
        // Calling all methods

        Greet();

        PrintName("Kesavan");

        int sum = Add(10, 20);
        Console.WriteLine("Sum = " + sum);

        StudentDetails("Arun", 21);

        Show();
        Show("Hello from Overloaded Method");
    }
}
