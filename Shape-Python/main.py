from abc import ABC, abstractmethod
import math

class Shape(ABC):
    def __init__(self, name: str):
        self.name = name

    @abstractmethod
    def area(self):
        pass

    @abstractmethod
    def print_info(self):
        pass


class Circle(Shape):
    def __init__(self, name: str, radius: float):
        super().__init__(name)
        self.radius = radius

    def area(self):
        return math.pi * self.radius ** 2

    def print_info(self):
        print(f"Circle area = {self.area():.2f}")


class Rectangle(Shape):
    def __init__(self, name: str, width: float, height: float):
        super().__init__(name)
        self.width = width
        self.height = height

    def area(self):
        return self.width * self.height

    def print_info(self):
        print(f"Rectangle area = {self.area():.2f}")


class Cylinder(Circle):
    def __init__(self, name: str, radius: float, length: float):
        super().__init__(name, radius)
        self.length = length

    def volume(self):
        return self.area() * self.length

    def print_info(self):
        print(
            f"Cylinder base area = {self.area():.2f} "
            f"volume = {self.volume():.2f}"
        )


class Polygon(Rectangle):
    def __init__(self, name: str, width: float, height: float, n: int):
        super().__init__(name, width, height)
        self.n = n

    def volume(self):
        return self.area() * self.n

    def print_info(self):
        print(
            f"Polygon area = {self.area():.2f} "
            f"volume = {self.volume():.2f} n = {self.n}"
        )

c = Circle("Circle1", 5)
c.print_info()

r = Rectangle("Rect1", 4, 7)
r.print_info()

cyl = Cylinder("Cylinder1", 3, 10)
cyl.print_info()

p = Polygon("Polygon1", 2, 3, 4)
p.print_info()
