using System;

abstract class Shape
{
    protected string name;

    protected Shape(string name)
    {
        this.name = name;
    }

    public abstract double Area();
    public abstract void PrintInfo();
}

class Circle : Shape
{
    protected double radius;

    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Circle area = {Area():F2}");
    }
}

class Rectangle : Shape
{
    protected double width, height;

    public Rectangle(string name, double width, double height) : base(name)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Rectangle area = {Area():F2}");
    }
}

class Cylinder : Circle
{
    private double length;

    public Cylinder(string name, double radius, double length)
        : base(name, radius)
    {
        this.length = length;
    }

    public double Volume()
    {
        return Area() * length;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Cylinder base area = {Area():F2} volume = {Volume():F2}");
    }
}

class Polygon : Rectangle
{
    private int n;

    public Polygon(string name, double width, double height, int n)
        : base(name, width, height)
    {
        this.n = n;
    }

    public double Volume()
    {
        return Area() * n;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Polygon area = {Area():F2} volume = {Volume():F2} n = {n}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle("Circle", 5);
        Rectangle rectangle = new Rectangle("Rectangle", 5, 10);
        Cylinder cylinder = new Cylinder("Cylinder", 5, 10);
        Polygon polygon = new Polygon("Polygon", 5, 10, 6);

        circle.PrintInfo();
        rectangle.PrintInfo();
        cylinder.PrintInfo();
        polygon.PrintInfo();
    }
}
