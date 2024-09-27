Abstraktion
// File: Shape.cs
public abstract class Shape
{
    public abstract double CalculateArea();
}

// File: Triangle.cs
public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}