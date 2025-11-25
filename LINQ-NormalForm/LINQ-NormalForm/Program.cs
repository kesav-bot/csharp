using System;
using System.Collections.Generic;
using System.Linq;

// Define the data models (objects)
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DeptId { get; set; }
    public int Marks { get; set; }
}

class Department
{
    public int Id { get; set; }
    public string DeptName { get; set; }
}

class Program
{
    static void Main()
    {
        // Sample Data Sets
        var students = new List<Student>()
        {
            new Student { Id = 1, Name = "Kesavan", DeptId = 1, Marks = 96 },
            new Student { Id = 2, Name = "Rahul", DeptId = 2, Marks = 92 },
            new Student { Id = 3, Name = "Vijay", DeptId = 1, Marks = 76 },
            new Student { Id = 4, Name = "Nandu", DeptId = 3, Marks = 44 },
            new Student { Id = 5, Name = "Deepak", DeptId = 1, Marks = 88 },
            new Student { Id = 6, Name = "Siva", DeptId = 2, Marks = 64 }
        };

        var departments = new List<Department>()
        {
            new Department { Id = 1, DeptName = "CSE" },
            new Department { Id = 2, DeptName = "ECE" },
            new Department { Id = 3, DeptName = "EEE" }
        };

        // --- THE COMBINED LINQ QUERY (Query Syntax) ---
        var combinedResult =
            from s in students
                // 1. JOIN: Link Student to Department
            join d in departments on s.DeptId equals d.Id
            // 2. FILTER: Only include students who scored 75 or higher
            where s.Marks >= 75
            // 3. GROUP: Group the results by the Department Name
            group s by d.DeptName into deptGroup
            // 4. ORDER: Order the groups alphabetically by Department Name
            orderby deptGroup.Key
            // 5. PROJECT & AGGREGATE: Select the final output structure
            select new
            {
                Department = deptGroup.Key,
                Count = deptGroup.Count(),
                AverageMarks = deptGroup.Average(s => s.Marks),
                Toppers = deptGroup.OrderByDescending(s => s.Marks).Select(s => s.Name)
            };

        // --- OUTPUT THE RESULT ---

        Console.WriteLine("--- Combined LINQ Query Results ---");

        foreach (var group in combinedResult)
        {
            Console.WriteLine($"\n**Department: {group.Department}**");
            Console.WriteLine($"  - Total Toppers (>= 75): {group.Count}");
            Console.WriteLine($"  - Average Marks in Group: {group.AverageMarks:F2}");
            Console.WriteLine($"  - Top Students:");

            foreach (var name in group.Toppers)
            {
                Console.WriteLine($"    > {name}");
            }
        }
    }
}