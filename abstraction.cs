using System;

abstract class Car
{
    public abstract void honda();//abstract method
    public void shift() //non abstract method
    {
        Console.WriteLine("shift car is small in size");
    }
}
class vehicle : Car
{
    public override void honda()
    {
        Console.WriteLine("honda is no 1 car in the world");
    }

}
class Hiding
{
    public static void Main(string[] args)
    {
        vehicle car = new vehicle();
        car.honda();
        car.shift();
    }
}