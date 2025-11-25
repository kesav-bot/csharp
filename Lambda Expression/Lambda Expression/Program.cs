using System;

class Program
{
    static void Main()
    {
        // Lambda with no parameters
        Action greet = () => Console.WriteLine("Hello from Lambda!");
        greet();

        // Lambda with one parameter
        Action<string> showName = name => Console.WriteLine("Your name is: " + name);
        showName("Kesavan");

        // Lambda with return value
        Func<int, int> square = x => x * x;
        Console.WriteLine("Square of 5: " + square(5));

        // Lambda with two parameters
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine("10 + 20 = " + add(10, 20));
    }
}
