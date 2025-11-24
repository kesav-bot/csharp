using System;

class Program
{
    static void Main()
    {

        string name = "Kesavan";

        Console.WriteLine(" Original String: " + name);
        Console.WriteLine();

        Console.WriteLine(" Length of string: " + name.Length);

        Console.WriteLine(" Uppercase: " + name.ToUpper());

        Console.WriteLine(" Lowercase: " + name.ToLower());

        Console.WriteLine(" Substring(0,3): " + name.Substring(0, 3));

        Console.WriteLine(" Contains 'sav'? : " + name.Contains("sav"));

        Console.WriteLine(" Replace 'K' with 'M': " + name.Replace("K", "M"));

        Console.WriteLine(" Starts with 'Ke'? : " + name.StartsWith("Ke"));
        Console.WriteLine(" Ends with 'van'? : " + name.EndsWith("van"));

        string messy = "   Hello World   ";
        Console.WriteLine(" Trim: '" + messy.Trim() + "'");

        string sentence = "C# is easy to learn";
        string[] words = sentence.Split(' ');

        Console.WriteLine("\nWords after Split:");
        foreach (string w in words)
        {
            Console.WriteLine(w);
        }

        string joined = string.Join("-", words);
        Console.WriteLine("\n Join words with '-': " + joined);
    }
}
