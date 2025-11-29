// focuses on showing only essential information to the user and hiding unnecessary implementation details.

using System;

//ABSTRACT CLASS (Abstraction)
abstract class Shape
{
    // Abstract method → NO BODY 
    public abstract void Draw();

    // Normal method
    public void Display()
    {
        Console.WriteLine("Displaying a shape.");
    }
}


// INTERFACE

interface IColor
{
    void SetColor(string color);   // Only method signature
}


//     CLASS USING BOTH
class Circle : Shape, IColor
{
    // Implement abstract method
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }

    // Implement interface method
    public void SetColor(string color)
    {
        Console.WriteLine($"Circle color set to {color}.");
    }
}

// MAIN PROGRAM

class Program
{
    static void Main()
    {
        Circle circle = new Circle();

        circle.Draw();  
        circle.Display();    
        circle.SetColor("Blue"); 
    }
}
