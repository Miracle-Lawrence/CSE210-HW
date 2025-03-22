using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine($"{f.GetFractionString()}");
        Console.WriteLine($"{f.GetDecimalValue()}");

        Fraction g = new Fraction(5);
        Console.WriteLine($"{g.GetFractionString()}");
        Console.WriteLine($"{g.GetDecimalValue()}");

        Fraction m = new Fraction(3,4);
        Console.WriteLine($"{m.GetFractionString()}");
        Console.WriteLine($"{m.GetDecimalValue()}");

        Fraction k = new Fraction(1,3);
        Console.WriteLine($"{k.GetFractionString()}");
        Console.WriteLine($"{k.GetDecimalValue()}");
    }
}