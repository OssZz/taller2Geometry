class Circle : GeometricFigure
{
    private double R; // Radio

    public Circle(string name, double radius) : base(name)
    {
        R = radius;
    }

    public override double GetArea()
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }
}
