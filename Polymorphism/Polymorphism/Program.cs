// Same method name → different behaviors
// virtual - allows child classes to give their own version of this method.


using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal a1 = new Dog();
        Animal a2 = new Cat();

        a1.MakeSound();
        a2.MakeSound();
    }
}
