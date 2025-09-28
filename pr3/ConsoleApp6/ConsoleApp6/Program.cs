using System;
using System.Collections.Generic;

class Engine
{
    public string Model { get; set; }
    public int Power { get; set; }
    public string Displacement { get; set; }
    public string Efficiency { get; set; }

    public Engine(string model, int power) //конструктор
    {
        Model = model;
        Power = power;
        Displacement = "n/a";
        Efficiency = "n/a";
    }
}

class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public string Weight { get; set; }
    public string Color { get; set; }

    public Car(string model, Engine engine) //конструктор
    {
        Model = model;
        Engine = engine;
        Weight = "n/a";
        Color = "n/a";
    }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //двигуни
        Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            Engine eng = new Engine(parts[0], int.Parse(parts[1]));

            if (parts.Length == 3)
            {
                if (int.TryParse(parts[2], out int disp)) eng.Displacement = parts[2];
                else eng.Efficiency = parts[2];
            }
            else if (parts.Length == 4)
            {
                eng.Displacement = parts[2];
                eng.Efficiency = parts[3];
            }

            engines[eng.Model] = eng; //додаю
        }

        int m = int.Parse(Console.ReadLine()); //авто
        List<Car> cars = new List<Car>();

        for (int i = 0; i < m; i++)
        {
            string[] parts = Console.ReadLine().Split();
            Car car = new Car(parts[0], engines[parts[1]]);

            if (parts.Length == 3)
            {
                if (int.TryParse(parts[2], out int w)) car.Weight = parts[2];
                else car.Color = parts[2];
            }
            else if (parts.Length == 4)
            {
                car.Weight = parts[2];
                car.Color = parts[3];
            }

            cars.Add(car);
        }

        foreach (var car in cars) //вивід
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");
            Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            Console.WriteLine($"  Weight: {car.Weight}");
            Console.WriteLine($"  Color: {car.Color}");
        }
    }
}
