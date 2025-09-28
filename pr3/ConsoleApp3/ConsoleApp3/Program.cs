using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age) //конструктор
    {
        Name = name;
        Age = age;
    }
}

class Family
{
    private List<Person> members = new List<Person>(); //список

    public void AddMember(Person member) //додати
    {
        members.Add(member);
    }

    public Person GetOldestMember() //знайти старшого
    {
        Person oldest = members[0];
        foreach (var p in members)
        {
            if (p.Age > oldest.Age) oldest = p;
        }
        return oldest;
    }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //кількість
        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            string name = parts[0];
            int age = int.Parse(parts[1]);

            Person person = new Person(name, age); //нова людина
            family.AddMember(person); //додаємо
        }

        Person oldest = family.GetOldestMember();
        Console.WriteLine(oldest.Name + " " + oldest.Age); //вивід
    }
}
