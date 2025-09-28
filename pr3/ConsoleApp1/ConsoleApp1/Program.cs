using System;

class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    //конструктор без параметрів
    public Person()
    {
        Name = "No name";
        Age = 1;
    }

    //конструктор тільки з віком
    public Person(int age) : this()
    {
        Age = age;
    }

    //конструктор з ім’ям і віком
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        //конструктор без параметрів
        Person p1 = new Person();
        Console.WriteLine(p1.Name + " " + p1.Age);

        //конструктора з віком
        Person p2 = new Person(20);
        Console.WriteLine(p2.Name + " " + p2.Age);

        //конструктор з ім’ям і віком
        Person p3 = new Person("Pesho", 20);
        Person p4 = new Person("Gosho", 18);
        Person p5 = new Person("Stamat", 43);

        Console.WriteLine(p3.Name + " " + p3.Age);
        Console.WriteLine(p4.Name + " " + p4.Age);
        Console.WriteLine(p5.Name + " " + p5.Age);
    }
}