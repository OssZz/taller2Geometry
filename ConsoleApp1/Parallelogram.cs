class Parallelogram : GeometricFigure
{
    private double B, H, A;

    public Parallelogram(string name, double b, double h, double a) : base(name)
    {
        A = a;
        B = b;
        H = h;

    }

    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}
