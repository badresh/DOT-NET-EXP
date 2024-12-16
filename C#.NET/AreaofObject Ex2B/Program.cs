using System;
using System.Drawing;
public interface IShape
{
    double CalculateArea();
}
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea()
    {
        return Width * Height;
    }
}
public class Circle : IShape
{
    public double Radius { get; set; }
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}
public class Square : IShape
{
    public double Side { get; set; }
    public double CalculateArea()
    {
        return Side * Side;
    }
}
public class Ellipse : IShape
{
    public double SemiMajorAxis { get; set; }
    public double SemiMinorAxis { get; set; }

    public double CalculateArea()
    {
        return Math.PI * SemiMajorAxis * SemiMinorAxis;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a shape to calculate area:");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Circle");
        Console.WriteLine("3. Triangle");
        Console.WriteLine("4. Square");
        Console.WriteLine("5. Ellipse");
        Console.Write("Enter your choice (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        IShape shape;
        switch (choice)
        {
            case 1:
                Console.Write("Enter width of the rectangle: ");
                int v = int.Parse(Console.ReadLine());
                int width = v;
                Console.Write("Enter width of the rectangle: ");
                int u = int.Parse(Console.ReadLine());
                int height = u;
                Console.Write("The area of Rectangle is - ");
                Console.Write(width * height); 
                break;
            case 2:
                Console.Write("Enter radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("The area of Circle is - ");
                Console.Write(Math.PI * radius * radius);
                break;
            case 3:
                Console.Write("Enter base length of the triangle: ");
                double @base = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter height of the triangle: ");
                double hight = Convert.ToDouble(Console.ReadLine());
                Console.Write("The area of Triangle is - ");
                Console.Write(0.5 * @base * hight);
                break;
            case 4:
                Console.Write("Enter side length of the square: ");
                double side = Convert.ToDouble(Console.ReadLine());
                Console.Write("The area of Square is - ");
                Console.Write(side * side);
                break;
            case 5:
                Console.Write("Enter semi-major axis length of the ellipse: ");
                double semiMajorAxis = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter semi-minor axis length of the ellipse: ");
                double semiMinorAxis = Convert.ToDouble(Console.ReadLine());
                Console.Write("The area of Ellipse is - ");
                Console.Write(Math.PI * semiMajorAxis * semiMinorAxis);
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
        }
    }
}