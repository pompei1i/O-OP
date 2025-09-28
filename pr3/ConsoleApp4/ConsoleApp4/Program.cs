using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public Employee(string name, double salary, string position, string department) //конструктор
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
        Email = "n/a";
        Age = -1;
    }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //кількість
        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            double salary = double.Parse(parts[1].Replace(',', '.'), CultureInfo.InvariantCulture);
            Employee emp = new Employee(parts[0], salary, parts[2], parts[3]);

            if (parts.Length == 5)
            {
                if (parts[4].Contains("@")) emp.Email = parts[4];
                else emp.Age = int.Parse(parts[4]);
            }
            else if (parts.Length == 6)
            {
                emp.Email = parts[4];
                emp.Age = int.Parse(parts[5]);
            }

            employees.Add(emp);
        }

        var bestDept = employees //кращий відділ
            .GroupBy(e => e.Department)
            .OrderByDescending(g => g.Average(e => e.Salary))
            .First();

        Console.WriteLine("Highest Average Salary: " + bestDept.Key);

        foreach (var e in bestDept.OrderByDescending(e => e.Salary)) //сортування
        {
            Console.WriteLine($"{e.Name} {e.Salary:F2} {e.Email} {e.Age}");
        }
    }
}
