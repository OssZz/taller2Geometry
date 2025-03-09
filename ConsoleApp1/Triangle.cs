class Triangle : GeometricFigure
{
    private double B, H, C;

    public Triangle(string name, double b, double h, double c) : base(name)
    {
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
        return B + C + Math.Sqrt(B * B + H * H);
    }
}
