using System;
using System.Collections.Generic;

class Program
{
    static readonly Random Random = new Random();

    struct Student
    {
        public string FirstName;
        public string LastName;
        public string Major;
        public int IndexNumber;
        public int Scholarship;

        public void Show()
        {
            Console.WriteLine(
                $"{FirstName} {LastName} | {Major} | {IndexNumber} | {Scholarship} PLN"
            );
        }
    }

    struct Rectangle
    {
        public int X;
        public int Y;
        public double Width;
        public double Height;

        public double GetArea()
        {
            return Width * Height;
        }

        public void Show()
        {
            Console.WriteLine("\nRectangle:");

            Console.WriteLine($"Top Left: ({X}, {Y})");
            Console.WriteLine($"Top Right: ({X + Width}, {Y})");
            Console.WriteLine($"Bottom Left: ({X}, {Y - Height})");
            Console.WriteLine($"Bottom Right: ({X + Width}, {Y - Height})");

            Console.WriteLine($"Area: {Math.Round(GetArea(), 2)}");
        }
    }

    class Animal
    {
        public string Name;
        public int Weight;
        public int Height;

        public Animal()
        {
            Name = "unknown";
            Weight = 0;
            Height = 0;
        }

        public Animal(string name, int weight, int height)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public void Show()
        {
            Console.WriteLine($"{Name} | {Weight} kg | {Height} cm");
        }
    }

    class Car
    {
        public string Brand;
        public string Model;
        public string Year;

        public Car()
        {
            Brand = "unknown";
            Model = "unknown";
            Year = "0000";
        }

        public Car(string brand, string model, string year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void Show()
        {
            Console.WriteLine($"{Brand} {Model} ({Year})");
        }
    }

    static void Task1()
    {
        List<Student> students = new List<Student>();

        for (int i = 0; i < 4; i++)
        {
            Student student = new Student();

            Console.Write("First name: ");
            student.FirstName = Console.ReadLine();

            Console.Write("Last name: ");
            student.LastName = Console.ReadLine();

            Console.Write("Major: ");
            student.Major = Console.ReadLine();

            student.IndexNumber = Random.Next(410000, 450001);
            student.Scholarship = Random.Next(1200, 3301);

            students.Add(student);

            Console.WriteLine();
        }

        Console.WriteLine("\nStudents:");

        foreach (Student student in students)
        {
            student.Show();
        }
    }

    static void Task2()
    {
        Rectangle rectangle = new Rectangle();

        Console.Write("X: ");
        rectangle.X = int.Parse(Console.ReadLine());

        Console.Write("Y: ");
        rectangle.Y = int.Parse(Console.ReadLine());

        Console.Write("Width: ");
        rectangle.Width = double.Parse(Console.ReadLine());

        Console.Write("Height: ");
        rectangle.Height = double.Parse(Console.ReadLine());

        rectangle.Show();
    }

    static void Task3()
    {
        Animal animal = new Animal();

        Console.WriteLine("\nDefault Animal:");
        animal.Show();
    }

    static void Task4()
    {
        Animal[] animals =
        {
            new Animal("Tygrys", 300, 120),
            new Animal("Slon", 4500, 350),
            new Animal("Kapibara", 35, 30),
            new Animal("Kon polski", 400, 180)
        };

        Console.WriteLine("\nAnimals:");

        foreach (Animal animal in animals)
        {
            animal.Show();
        }
    }

    static void Task5()
    {
        List<Car> cars = new List<Car>
        {
            new Car("Ford", "Mustang", "1964"),
            new Car("Volvo", "P1800", "1968"),
            new Car("BMW", "M1", "1978"),
            new Car("Toyota", "Celica", "1975"),
            new Car("Porsche", "911", "1965"),
            new Car("Audi", "Quattro", "1980"),
            new Car("Mercedes", "W123", "1976")
        };

        Console.WriteLine("\nCars:");

        foreach (Car car in cars)
        {
            car.Show();
        }
    }

    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
    }
}