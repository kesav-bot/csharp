using System;

class Person
{

    public string Name;
    public int Age;

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {

        Console.WriteLine("First Person:");
        Person p1 = new Person();
        p1.Name = "Kesavan";
        p1.Age = 23;
        p1.Display();

        Console.WriteLine();

        Console.WriteLine("Second Person:");
        Person p2 = new Person();
        p2.Name = "Arun";
        p2.Age = 21;
        p2.Display();
    }
}
