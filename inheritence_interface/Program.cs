using System;

// Base class
class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

// Derived class 1 (Single Inheritance)
class Mammal : Animal
{
    public void GiveBirth()
    {
        Console.WriteLine($"{Name} is giving birth to live young.");
    }
}

// Derived class 2 (Multilevel Inheritance)
class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

// Derived class 3 (Hierarchical Inheritance)
class Bird : Animal
{
    public void LayEggs()
    {
        Console.WriteLine($"{Name} is laying eggs.");
    }
}

// Interface for Multiple Inheritance
interface IFlyable
{
    void Fly();
}

// Derived class 4 (Hybrid Inheritance)
class Eagle : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying high in the sky.");
    }
}

class Programs
{
    static void Main987()
    {
        // Single Inheritance
        Mammal dog = new Mammal();
        dog.Name = "Dog";
        dog.Eat();
        dog.GiveBirth();

        // Multilevel Inheritance
        Dog germanShepherd = new Dog();
        germanShepherd.Name = "German Shepherd";
        germanShepherd.Eat();
        germanShepherd.GiveBirth();
        germanShepherd.Bark();

        // Hierarchical Inheritance
        Bird sparrow = new Bird();
        sparrow.Name = "Sparrow";
        sparrow.Eat();
        sparrow.LayEggs();

        // Hybrid Inheritance
        Eagle baldEagle = new Eagle();
        baldEagle.Name = "Bald Eagle";
        baldEagle.Eat();
        baldEagle.LayEggs();
        baldEagle.Fly();
    }
}
