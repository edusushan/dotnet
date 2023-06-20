using System;
using System.Linq;

// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class inheriting from Animal
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Main class
public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of Dog
        Dog dog = new Dog();
        // Call methods from the base class
        dog.Eat();
        // Call methods specific to the derived class
        dog.Bark();
    }
}
