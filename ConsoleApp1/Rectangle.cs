class Rectangle : GeometricFigure
{
    private double A, B;

    public Rectangle(string name, double a, double b) : base(name)
    {
        A = a;
        B = b;
    }

    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}
