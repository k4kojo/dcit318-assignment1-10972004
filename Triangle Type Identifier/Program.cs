using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        // Prompt the user to enter the lengths of the three sides
        Console.Write("Enter the length of side 1: ");
        double side1 = ReadSide();
        
        Console.Write("Enter the length of side 2: ");
        double side2 = ReadSide();
        
        Console.Write("Enter the length of side 3: ");
        double side3 = ReadSide();

        // Determine the type of triangle
        if (IsValidTriangle(side1, side2, side3))
        {
            string triangleType = GetTriangleType(side1, side2, side3);
            Console.WriteLine("The triangle is: " + triangleType);
        }
        else
        {
            Console.WriteLine("The given sides do not form a valid triangle.");
        }
    }

    static double ReadSide()
    {
        double side;
        while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            Console.Write("Enter the length again: ");
        }
        return side;
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        // Check the triangle inequality theorem
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Equilateral";
        }
        else if (a == b || a == c || b == c)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}
