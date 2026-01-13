#include <iostream>
#include <string>
using namespace std;

enum Color { BLACK, WHITE, BROWN, GREY };
enum Size { SMALL, MEDIUM, LARGE };

class Animal {
protected:
  string name;
  Color color;
  Size size;

public:
  Animal(string name, Color color, Size size)
      : name(name), color(color), size(size) {}

  virtual void sound() = 0;
  virtual void eat() = 0;

  void printInfo() {
    cout << "Name: " << name << ", Color: " << color << ", Size: " << size
         << endl;
  }

  virtual ~Animal() {}
};

class Mammalia : public Animal {
public:
  Mammalia(string name, Color color, Size size) : Animal(name, color, size) {}

  void sound() override { cout << "Mammal makes roar sound" << endl; }

  void eat() override { cout << "Mammal eats meat" << endl; }

  void run() { cout << "Mammal is running" << endl; }
};

class Aves : public Animal {
public:
  Aves(string name, Color color, Size size) : Animal(name, color, size) {}

  void sound() override { cout << "Bird makes jib-jib sound" << endl; }

  void eat() override { cout << "Bird eats seeds" << endl; }

  void fly() { cout << "Bird is flying" << endl; }
};

class Osteichthyes : public Animal {
public:
  Osteichthyes(string name, Color color, Size size)
      : Animal(name, color, size) {}

  void sound() override { cout << "Fish makes no sound" << endl; }

  void eat() override { cout << "Fish eats plankton" << endl; }

  void swim() { cout << "Fish is swimming" << endl; }
};

class Dog : public Mammalia {
public:
  Dog(string name, Color color, Size size) : Mammalia(name, color, size) {}

  void sound() override { cout << "Dog makes barks" << endl; }

  void eat() override { cout << "Dog eats meat" << endl; }
};

class Bird : public Aves {
public:
  Bird(string name, Color color, Size size) : Aves(name, color, size) {}
};

class Fish : public Osteichthyes {
public:
  Fish(string name, Color color, Size size) : Osteichthyes(name, color, size) {}
};

class ThaiRidgeBack : public Dog {
public:
  ThaiRidgeBack(string name, Color color, Size size) : Dog(name, color, size) {}

  void origin() { cout << "Origin: Thailand" << endl; }
};

class HummingBird : public Bird {
public:
  HummingBird(string name, Color color, Size size) : Bird(name, color, size) {}

  void flyFast() { cout << "HummingBird is flying" << endl; }
};

class AngelFish : public Fish {
public:
  AngelFish(string name, Color color, Size size) : Fish(name, color, size) {}

  void showPattern() { cout << "AngelFish is swimming" << endl; }
};

int main() {
  ThaiRidgeBack dog("Thai Ridgeback", BROWN, MEDIUM);
  dog.printInfo();
  dog.sound();
  dog.eat();
  dog.run();
  dog.origin();

  cout << endl;

  HummingBird bird("Humming Bird", GREY, SMALL);
  bird.printInfo();
  bird.sound();
  bird.eat();
  bird.fly();
  bird.flyFast();

  cout << endl;

  AngelFish fish("Angel Fish", WHITE, SMALL);
  fish.printInfo();
  fish.sound();
  fish.eat();
  fish.swim();
  fish.showPattern();

  return 0;
}
