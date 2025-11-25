using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"C:\Learning\csharp\File_handling\sample.txt";

        File.WriteAllText(path, "Hello, this is C# File Handling!\n");

        File.AppendAllText(path, "This line is appended.\n");

        string content = File.ReadAllText(path);
        Console.WriteLine("File Content:\n" + content);

        Console.WriteLine("\nReading Line by Line:");
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        string newPath = @"C:\Demo\newfile.txt";
        using (StreamWriter writer = new StreamWriter(newPath))
        {
            writer.WriteLine("Line 1");
            writer.WriteLine("Line 2");
            writer.WriteLine("Line 3");
        }

        Console.WriteLine("\nNew file created with StreamWriter.");

        if (File.Exists(path))
        {
            Console.WriteLine("\nFile exists: " + path);
        }

        string copyPath = @"C:\Demo\copy_sample.txt";
        File.Copy(path, copyPath, overwrite: true);

        string movePath = @"C:\Demo\moved_sample.txt";

        if (File.Exists(movePath))
        {
            File.Delete(movePath);
        }

        File.Move(copyPath, movePath);

        if (File.Exists(movePath))
        {
            File.Delete(movePath);
            Console.WriteLine("\nMoved file deleted.");
        }
    }
}
