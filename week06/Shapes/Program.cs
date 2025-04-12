using System;

class Program
{
    static void Main(string[] args)
    {     
        Square S1 = new Square(7,"blue");
        Rectangle R1 = new Rectangle(5,4,"yellow");
        Circle C1 = new Circle(14,"Green");
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(S1);
        shapes.Add(R1);
        shapes.Add(C1);

        foreach (Shape structure in shapes)
        {
            Console.WriteLine($"The {structure.GetColor()} has an area of {structure.GetArea()}");
        }
        
    }
}