using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter the length of side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter the length of side C: ");
        double sideC = double.Parse(Console.ReadLine());

        if (sideA == sideB && sideB == sideC)
            Console.WriteLine("The triangle is Equilateral.");
        else if (sideA == sideB || sideB == sideC || sideA == sideC)
            Console.WriteLine("The triangle is Isosceles.");
        else
            Console.WriteLine("The triangle is Scalene.");
    }
}
