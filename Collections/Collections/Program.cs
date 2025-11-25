using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // LIST
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Apple"); // Duplicate allowed

        Console.WriteLine("List (Allows Duplicates, Ordered):");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine();

        // DICTIONARY (KEY - VALUE)
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(1, "Kesavan");
        students.Add(2, "Ravi");

        Console.WriteLine("Dictionary (Key-Value Pairs):");
        foreach (var item in students)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
        Console.WriteLine();

        // HASHSET (NO DUPLICATES)
        HashSet<int> numbers = new HashSet<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(10); // Duplicate ignored

        Console.WriteLine("HashSet (Unique Values Only):");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();

        // QUEUE (FIFO)
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("Queue (FIFO):");
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine();

        // 5. STACK (LIFO)
        Stack<int> stack = new Stack<int>();
        stack.Push(100);
        stack.Push(200);
        stack.Push(300);

        Console.WriteLine("Stack (LIFO):");
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}
