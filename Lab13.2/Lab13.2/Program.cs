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

// Derived class inheriting from Dog
public class GermanShepherd : Dog
{
    public void Run()
    {
        Console.WriteLine("German Shepherd is Running....");
    }
}

// Main class
public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of GermanShepherd
        GermanShepherd germanShepherd = new GermanShepherd();

        // Call methods from the base classes
        germanShepherd.Eat();   
        germanShepherd.Bark();
        germanShepherd.Run();
    }
}
