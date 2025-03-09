class Parallelogram : GeometricFigure
{
    private double B, H, A;

    public Parallelogram(string name, double b, double h, double a) : base(name)
    {
        B = b;
        H = h;
        A = a;
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
