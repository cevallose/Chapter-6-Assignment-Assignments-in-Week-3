public abstract class Shape
{
    public double Height { get; protected set; }
    public double Width { get; protected set; }

    public abstract double Area { get; }
}
