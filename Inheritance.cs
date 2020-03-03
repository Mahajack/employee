using System;

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }    

}
 
class Inheritance
{
    public static void Main(string[] args)
    {

    Dog puppy = new Dog();
    puppy.Eat();
    puppy.Bark();

    }
}

}