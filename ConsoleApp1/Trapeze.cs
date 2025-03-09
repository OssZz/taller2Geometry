class Trapeze : GeometricFigure
{
    private double A, B, C, D, H;

    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name)
    {
        A = a;
        B = b;
        C = c;
        D = d;
        H = h;
    }

    public override double GetArea()
    {
        return ((A + D) * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }
}
