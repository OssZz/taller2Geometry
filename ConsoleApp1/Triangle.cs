class Triangle : GeometricFigure
{
    private double A, B, H, C;

    public Triangle(string name, double a, double b, double h, double c) : base(name)
    {
        A = a;
        B = b;
        H = h;
        C = c;
    }

    public override double GetArea()
    {
        return (B * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }
}
