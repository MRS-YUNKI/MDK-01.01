using System.Runtime.InteropServices;

public class Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double a, double b, double c)
    {
        this.sideA = a;
        this.sideB = b;
        this.sideC = c;
    }

    public bool IsExist()
    {
        return (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideA + sideC > sideB);
    }

    public double GetP()
    {
        return sideA + sideB + sideC;
    }

    public double GetS()
    {
        double partP = GetP() / 2;
        return Math.Sqrt(partP * (partP -  sideA) * (partP - sideB) * (partP - sideC));
    }
}

public class Pyramid : Triangle
{
    private double height;

    public Pyramid(double a, double b, double c, double h) : base(a, b, c)
    {
        height = h;
    }

    public double GetS()
    {
        double baseS = base.GetS();
        double apophema = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(baseS / GetP(), 2)); // (baseS / GetP()) - нахождение радиуса основания
        return (baseS + ((GetP() / 2) * apophema));
    }
}

public class Prism : Triangle
{
    private double height;

    public Prism(double a, double b, double c, double h) : base(a, b, c)
    {
        height = h;
    }

    public double GetS()
    {
        double baseS = base.GetS();
        double P = GetP();
        double lateral_surface = GetP() * height;
        return (baseS * 2) + lateral_surface;
    }
}

class triangle
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3,4,5);
        Pyramid pyramid = new Pyramid(3, 6, 7, 3);
        Prism prism = new Prism(4, 6, 9, 4);
        if (triangle.IsExist())
        {
            Console.WriteLine($"Периметр треугольника: {triangle.GetP()}.");
            Console.WriteLine($"Площадь треугольника: {triangle.GetS()}.");
            Console.WriteLine($"Площадь пирамиды: {pyramid.GetS()}.");
            Console.WriteLine($"Площадь призмы: {prism.GetS()}.");
        }
    }
}