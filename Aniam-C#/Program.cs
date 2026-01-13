enum Color {
    BLACK, WHITE, BROWN, GREY
}

enum Size {
    SMALL, MEDIUM, LARGE
}

abstract class Animal {
    protected string name;
    protected Color color;
    protected Size size;

    protected Animal(string name, Color color, Size size) {
        this.name = name;
        this.color = color;
        this.size = size;
    }

    public abstract void Sound();
    public abstract void Eat();

    public void PrintInfo() {
        Console.WriteLine($"Name: {name}, Color: {color}, Size: {size}");
    }
}

class Mammalia : Animal {
    public Mammalia(string name, Color color, Size size)
        : base(name, color, size) {}

    public override void Sound() {
        Console.WriteLine("Mammal makes roar sound");
    }

    public override void Eat() {
        Console.WriteLine("Mammal eats meat");
    }

    public void Run() {
        Console.WriteLine("Mammal is running");
    }
}

class Aves : Animal {
    public Aves(string name, Color color, Size size)
        : base(name, color, size) {}

    public override void Sound() {
        Console.WriteLine("Bird makes jib-jib sound");
    }

    public override void Eat() {
        Console.WriteLine("Bird eats seeds");
    }

    public void Fly() {
        Console.WriteLine("Bird is flying");
    }
}

class Osteichthyes : Animal {
    public Osteichthyes(string name, Color color, Size size)
        : base(name, color, size) {}

    public override void Sound() {
        Console.WriteLine("Fish makes no sound");
    }

    public override void Eat() {
        Console.WriteLine("Fish eats plankton");
    }

    public void Swim() {
        Console.WriteLine("Fish is swimming");
    }
}

class Dog : Mammalia {
    public Dog(string name, Color color, Size size)
        : base(name, color, size) {}

    public override void Sound() {
        Console.WriteLine("Dog makes barks");
    }

    public override void Eat() {
        Console.WriteLine("Dog eats meat");
    }
}

class Bird : Aves {
    public Bird(string name, Color color, Size size)
        : base(name, color, size) {}
}

class Fish : Osteichthyes {
    public Fish(string name, Color color, Size size)
        : base(name, color, size) {}
}

class ThaiRidgeBack : Dog {
    public ThaiRidgeBack(string name, Color color, Size size)
        : base(name, color, size) {}

    public void Origin() {
        Console.WriteLine("Origin: Thailand");
    }
}

class HummingBird : Bird {
    public HummingBird(string name, Color color, Size size)
        : base(name, color, size) {}

    public void FlyFast() {
        Console.WriteLine("HummingBird is flying");
    }
}

class AngelFish : Fish {
    public AngelFish(string name, Color color, Size size)
        : base(name, color, size) {}

    public void ShowPattern() {
        Console.WriteLine("AngelFish is swimming");
    }
}

class Program {
    static void Main() {
        ThaiRidgeBack dog = new ThaiRidgeBack("Thai Ridgeback", Color.BROWN, Size.MEDIUM);
        dog.PrintInfo();
        dog.Sound();
        dog.Eat();
        dog.Run();
        dog.Origin();

        Console.WriteLine();

        HummingBird bird = new HummingBird("Humming Bird", Color.GREY, Size.SMALL);
        bird.PrintInfo();
        bird.Sound();
        bird.Eat();
        bird.Fly();
        bird.FlyFast();

        Console.WriteLine();

        AngelFish fish = new AngelFish("Angel Fish", Color.WHITE, Size.SMALL);
        fish.PrintInfo();
        fish.Sound();
        fish.Eat();
        fish.Swim();
        fish.ShowPattern();
    }
}
