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

// Derived class inheriting from Animal
public class Cat : Animal
{
    public void Look()
    {
        Console.WriteLine("Cat is Looking to the dog...");
    }
}

// Main class
public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of Dog
        Dog dog = new Dog();

        // Create an instance of Cat
        Cat cat = new Cat();

        // Call methods from the base class
        dog.Eat(); 
        cat.Eat(); 

        // Call methods specific to the derived classes
        dog.Bark();  
        cat.Look();  

    }
}
