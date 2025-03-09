class Kite : GeometricFigure
{
    private double D1, D2, A, B;

    public Kite(string name, double d1, double d2, double a, double b) : base(name)
    {
        D1 = d1;
        D2 = d2;
        A = a;
        B = b;
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }
}
