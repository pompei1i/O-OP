using System;
using System.Collections.Generic;
using System.Globalization; //для парсу чисел

class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelPerKm { get; set; }
    public double Distance { get; set; }

    public Car(string model, double fuel, double fuelPerKm) //конструктор
    {
        Model = model;
        FuelAmount = fuel;
        FuelPerKm = fuelPerKm;
        Distance = 0;
    }

    public bool Drive(double km) //метод поїхати
    {
        double needFuel = km * FuelPerKm;
        if (FuelAmount >= needFuel)
        {
            FuelAmount -= needFuel;
            Distance += km;
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //кількість авто
        Dictionary<string, Car> cars = new Dictionary<string, Car>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            string model = parts[0];
            double fuel = double.Parse(parts[1].Replace(',', '.'), CultureInfo.InvariantCulture);
            double perKm = double.Parse(parts[2].Replace(',', '.'), CultureInfo.InvariantCulture);

            cars[model] = new Car(model, fuel, perKm);
        }

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "End") break;

            string[] parts = line.Split();
            string model = parts[1];
            double km = double.Parse(parts[2].Replace(',', '.'), CultureInfo.InvariantCulture);

            cars[model].Drive(km);
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
        }
    }
}
