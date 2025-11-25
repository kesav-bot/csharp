// hold a reference to a method.
// Think of a delegate as a pointer to a function.
// You can pass methods as parameters, store them, change them, and call them later.

using System;

public delegate void MyDelegate();   

class Program
{
    // Create any method with same signature as delegate
    public static void ShowMessage()
    {
        Console.WriteLine("Hello from Delegate!");
    }

    static void Main()
    {
        MyDelegate d = ShowMessage;   // Assign method to delegate
        d();                          // Call delegate
    }
}
