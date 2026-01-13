abstract class Shape {
    protected String name;

    public Shape(String name) {
        this.name = name;
    }
    public abstract double area();
    public abstract void printInfo();
}

class Circle extends Shape {
    protected double radius;

    public Circle(String name, double radius) {
        super(name);
        this.radius = radius;
    }

    @Override
    public double area() {
        return Math.PI * radius * radius;
    }

    @Override
    public void printInfo() {
        System.out.println("Circle area = " + String.format("%.2f", area()));
    }
}

class Rectangle extends Shape {
    protected double width, height;

    public Rectangle(String name, double width, double height) {
        super(name);
        this.width = width;
        this.height = height;
    }

    @Override
    public double area() {
        return width * height;
    }

    @Override
    public void printInfo() {
        System.out.println("Rectangle area = " + String.format("%.2f", area()));
    }
}

class Cylinder extends Circle {
    private double length;

    public Cylinder(String name, double radius, double length) {
        super(name, radius);
        this.length = length;
    }

    public double volume() {
        return area() * length;
    }

    @Override
    public void printInfo() {
        System.out.println("Cylinder base area = " + String.format("%.2f", area()) + " volume = " + String.format("%.2f", volume()));
    }
}

class Polygon extends Rectangle {
    private int n;

    public Polygon(String name, double width, double height, int n) {
        super(name, width, height);
        this.n = n;
    }

    public double volume() {
        return area() * n;
    }

    @Override
    public void printInfo() {
        System.out.println("Polygon area = " + String.format("%.2f", area()) + " volume = " + String.format("%.2f", volume()) + " n = " + n);
    }
}

public class Main {
    public static void main(String[] args) {
        Circle circle = new Circle("Circle", 5);
        Rectangle rectangle = new Rectangle("Rectangle", 5, 10);
        Cylinder cylinder = new Cylinder("Cylinder", 5, 10);
        Polygon polygon = new Polygon("Polygon", 5, 10, 6);

        circle.printInfo();
        rectangle.printInfo();
        cylinder.printInfo();
        polygon.printInfo();
    }
}
