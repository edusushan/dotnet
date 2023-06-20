using System;

// Interface for their behavior
public interface Eats
{
    void Eat();
}
public interface Barks
{
    void Bark();
}
public interface Runs
{
    void Run();
}


public class Dog : Eats, Barks
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating.");
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

public class Cat : Eats, Runs
{
    public void Eat()
    {
        Console.WriteLine("Cat is eating.");
    }

    public void Run()
    {
        Console.WriteLine("Cat is Running.");
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
        // Call methods from the interfaces
        dog.Eat();  
        cat.Eat();   
       
        dog.Bark();  
        cat.Run(); 
    }
}
