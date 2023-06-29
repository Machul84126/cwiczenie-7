using System;

public class LineLengthCalculator
{
    public static double CalculateLineLength(double x1, double y1, double x2, double y2)
    {
        double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return length;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj współrzędne punktu początkowego (x1, y1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współrzędne punktu końcowego (x2, y2):");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        double lineLength = CalculateLineLength(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + lineLength);
    }
}