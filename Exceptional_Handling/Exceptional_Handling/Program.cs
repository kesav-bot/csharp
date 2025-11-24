using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Exception Handling Example ===");

        try
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == 0)
                throw new DivideByZeroException("You cannot divide by zero!");

            int result = num1 / num2;
            Console.WriteLine($"Result = {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter only numbers!");
            Console.WriteLine("System Message: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed!");
            Console.WriteLine("System Message: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong!");
            Console.WriteLine("System Message: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\nProgram Ended (finally block executed).");
        }
    }
}
