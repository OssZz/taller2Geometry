class Square : GeometricFigure
{
    private double A; // Lado

    public Square(string name, double side) : base(name)
    {
        A = side;
    }

    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }
}

