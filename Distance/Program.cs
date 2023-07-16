public class Point3D
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

public static class PointOperation
{
    public static double Distance(Point3D p1, Point3D p2)
    {
        return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X)
                         + (p1.Y - p2.Y) * (p1.Y - p2.Y)
                         + (p1.Z - p2.Z) * (p1.Z - p2.Z));
    }
}

public class ConsoleReader
{
    public Point3D Read3DPoint()
    {
        Console.Write("Введите координаты x: ");
        var x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты y: ");
        var y = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координаты z: ");
        var z = Convert.ToDouble(Console.ReadLine());
        return new Point3D(x, y, z);
    }


    public void Read3DPoints()
    {
        Console.WriteLine("Введите первую точку:");
        var p1 = Read3DPoint();
        Console.WriteLine("Введите вторую точку:");
        var p2 = Read3DPoint();
        var distance = PointOperation.Distance(p1, p2);
        Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var reader = new ConsoleReader();
        reader.Read3DPoints();
    }
}