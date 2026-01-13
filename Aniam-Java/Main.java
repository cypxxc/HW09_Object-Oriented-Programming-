enum Color {
    BLACK, WHITE, BROWN, GREY
}

enum Size {
    SMALL, MEDIUM, LARGE
}

abstract class Animal {
    protected String name;
    protected Color color;
    protected Size size;

    public Animal(String name, Color color, Size size) {
        this.name = name;
        this.color = color;
        this.size = size;
    }

    public abstract void sound();
    public abstract void eat();

    public void printInfo() {
        System.out.println("Name: " + name +", Color: " + color +", Size: " + size);
    }
}

class Mammalia extends Animal {

    public Mammalia(String name, Color color, Size size) {
        super(name, color, size);
    }

    @Override
    public void sound() {
        System.out.println("Mammal makes roar sound");
    }

    @Override
    public void eat() {
        System.out.println("Mammal eats meat");
    }

    public void run() {
        System.out.println("Mammal is running");
    }
}

class Aves extends Animal {

    public Aves(String name, Color color, Size size) {
        super(name, color, size);
    }

    @Override
    public void sound() {
        System.out.println("Bird makes jib-jib sound");
    }

    @Override
    public void eat() {
        System.out.println("Bird eats seeds");
    }

    public void fly() {
        System.out.println("Bird is flying");
    }
}

class Osteichthyes extends Animal {

    public Osteichthyes(String name, Color color, Size size) {
        super(name, color, size);
    }

    @Override
    public void sound() {
        System.out.println("Fish makes no sound");
    }

    @Override
    public void eat() {
        System.out.println("Fish eats plankton");
    }

    public void swim() {
        System.out.println("Fish is swimming");
    }
}

class Dog extends Mammalia {

    public Dog(String name, Color color, Size size) {
        super(name, color, size);
    }

    @Override
    public void sound() {
        System.out.println("Dog makes barks");
    }

    @Override
    public void eat() {
        System.out.println("Dog eats meat");
    }
}

class Bird extends Aves {

    public Bird(String name, Color color, Size size) {
        super(name, color, size);
    }
}

class Fish extends Osteichthyes {

    public Fish(String name, Color color, Size size) {
        super(name, color, size);
    }
}

class ThaiRidgeBack extends Dog {

    public ThaiRidgeBack(String name, Color color, Size size) {
        super(name, color, size);
    }

    public void origin() {
        System.out.println("Origin: Thailand");
    }
}

class HummingBird extends Bird {

    public HummingBird(String name, Color color, Size size) {
        super(name, color, size);
    }

    public void flyFast() {
        System.out.println("HummingBird is flying");
    }
}

class AngelFish extends Fish {

    public AngelFish(String name, Color color, Size size) {
        super(name, color, size);
    }

    public void showPattern() {
        System.out.println("AngelFish is swimming");
    }
}

public class Main {
    public static void main(String[] args) {

        ThaiRidgeBack dog = new ThaiRidgeBack("Thai Ridgeback", Color.BROWN, Size.MEDIUM);
        dog.printInfo();
        dog.sound();
        dog.eat();
        dog.run();
        dog.origin();

        System.out.println();

        HummingBird bird = new HummingBird("Humming Bird", Color.GREY, Size.SMALL);
        bird.printInfo();
        bird.sound();
        bird.eat();
        bird.fly();
        bird.flyFast();

        System.out.println();

        AngelFish fish = new AngelFish("Angel Fish", Color.WHITE, Size.SMALL);
        fish.printInfo();
        fish.sound();
        fish.eat();
        fish.swim();
        fish.showPattern();
    }
}
