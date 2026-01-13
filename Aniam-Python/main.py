from abc import ABC, abstractmethod
from enum import Enum

class Color(Enum):
    BLACK = 1
    WHITE = 2
    BROWN = 3
    GREY = 4

class Size(Enum):
    SMALL = 1
    MEDIUM = 2
    LARGE = 3

class Animal(ABC):
    def __init__(self, name, color, size):
        self.name = name
        self.color = color
        self.size = size

    @abstractmethod
    def sound(self):
        pass

    @abstractmethod
    def eat(self):
        pass

    def print_info(self):
        print(f"Name: {self.name}, Color: {self.color.name}, Size: {self.size.name}")

class Mammalia(Animal):
    def sound(self):
        print("Mammal makes roar sound")

    def eat(self):
        print("Mammal eats meat")

    def run(self):
        print("Mammal is running")

class Aves(Animal):
    def sound(self):
        print("Bird makes jib-jib sound")

    def eat(self):
        print("Bird eats seeds")

    def fly(self):
        print("Bird is flying")

class Osteichthyes(Animal):
    def sound(self):
        print("Fish makes no sound")

    def eat(self):
        print("Fish eats plankton")

    def swim(self):
        print("Fish is swimming")

class Dog(Mammalia):
    def sound(self):
        print("Dog makes barks")

    def eat(self):
        print("Dog eats meat")

class Bird(Aves):
    pass

class Fish(Osteichthyes):
    pass

class ThaiRidgeBack(Dog):
    def origin(self):
        print("Origin: Thailand")

class HummingBird(Bird):
    def fly_fast(self):
        print("HummingBird is flying")

class AngelFish(Fish):
    def show_pattern(self):
        print("AngelFish is swimming")

dog = ThaiRidgeBack("Thai Ridgeback", Color.BROWN, Size.MEDIUM)
dog.print_info()
dog.sound()
dog.eat()
dog.run()
dog.origin()

print()

bird = HummingBird("Humming Bird", Color.GREY, Size.SMALL)
bird.print_info()
bird.sound()
bird.eat()
bird.fly()
bird.fly_fast()

print()

fish = AngelFish("Angel Fish", Color.WHITE, Size.SMALL)
fish.print_info()
fish.sound()
fish.eat()
fish.swim()
fish.show_pattern()
