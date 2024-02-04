using System;

class Program
{
    static void Main()
    {
        float a, b;
        Console.Write("Number a: ");
        while (!float.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid input");
        }
        Console.Write("Number b: ");
        while (!float.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input");
        }
        Console.WriteLine($"Result: {a + b}");
    }
}
