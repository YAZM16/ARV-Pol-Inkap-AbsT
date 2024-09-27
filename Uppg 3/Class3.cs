Polymorfism
// File: Shape.cs
public abstract class Shape
{
    public abstract double CalculateArea();
}

// File: Circle.cs
public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// File: Square.cs
public class Square : Shape
{
    public double SideLength { get; set; }

    public override double CalculateArea()
    {
        return SideLength * SideLength;
    }
}
