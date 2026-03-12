using System;

class Calculator
{
    // Method for Addition
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method for Subtraction
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Enter two numbers:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());

        // Creating object of Calculator class
        Calculator calc = new Calculator();

        // Calling methods
        int addition = calc.Add(a, b);
        int subtraction = calc.Subtract(a, b);

        // Display output
        Console.WriteLine("Addition = " + addition);
        Console.WriteLine("Subtraction = " + subtraction);
    }
}