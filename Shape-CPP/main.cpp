#include <iostream>
#define M_PI 3.14
#include <iomanip>
using namespace std;

class Shape {
protected:
    string name;
public:
    Shape(string name) : name(name) {}
    virtual double area() = 0;
    virtual void printInfo() = 0;
};

class Circle : public Shape {
protected:
    double radius;
public:
    Circle(string name, double radius) : Shape(name), radius(radius) {}

    double area() override {
        return M_PI * radius * radius;
    }

    void printInfo() override {
        cout << fixed << setprecision(2) << "Circle area = " << area() << endl;
    }
};

class Rectangle : public Shape {
protected:
    double width, height;
public:
    Rectangle(string name, double width, double height) : Shape(name), width(width), height(height) {}

    double area() override {
        return width * height;
    }

    void printInfo() override {
        cout << fixed << setprecision(2) << "Rectangle area = " << area() << endl;
    }
};

class Cylinder : public Circle {
    double length;
public:
    Cylinder(string name, double radius, double length) : Circle(name, radius), length(length) {}

    double volume() {
        return area() * length;
    }

    void printInfo() override {
        cout << fixed << setprecision(2) << "Cylinder base area = " << area() << " volume = " << volume() << endl;
    }
};

class Polygon : public Rectangle {
    int n;
public:
    Polygon(string name, double width, double height, int n) : Rectangle(name, width, height), n(n) {}

    double volume() {
        return area() * n;
    }

    void printInfo() override {
        cout << fixed << setprecision(2) << "Polygon area = " << area() << " volume = " << volume() << " n = " << n << endl;
    }
};

int main() {
    Circle c("Circle1", 5);
    c.printInfo();

    Rectangle r("Rect1", 4, 7);
    r.printInfo();

    Cylinder cyl("Cylinder1", 3, 10);
    cyl.printInfo();

    Polygon p("Polygon1", 2, 3, 4);
    p.printInfo();

    return 0;
}
