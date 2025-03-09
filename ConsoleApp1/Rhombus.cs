class Rhombus : GeometricFigure
{
    private double D1, D2; // Diagonales

    public Rhombus(string name, double d1, double d2) : base(name)
    {
        D1 = d1;
        D2 = d2;
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        double side = Math.Sqrt((D1 / 2) * (D1 / 2) + (D2 / 2) * (D2 / 2));
        return 4 * side;
    }
}
