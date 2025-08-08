using Abstraction;
using Inheritance;
using Interfaces;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Inheritance demonstration
        Console.WriteLine("== Inheritance ==");
        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        animal.MakeSound();  // Output: Some generic sound
        dog.MakeSound();     // Output: Bark
        cat.MakeSound();     // Output: Meow

        // Abstraction demonstration
        Console.WriteLine("\n== Abstraction ==");
        Shape circle = new Circle(5);
        Shape rectangle = new Abstraction.Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        // Interface demonstration
        Console.WriteLine("\n== Interfaces ==");
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();          // Output: Car is moving
        bicycle.Move();      // Output: Bicycle is moving
    }
}
