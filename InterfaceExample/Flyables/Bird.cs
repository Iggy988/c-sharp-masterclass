using InterfaceExample.Flyables.Interfaces;

namespace InterfaceExample.Flyables;

public class Bird : IFlyable
{
    public void Tweet() =>
        Console.WriteLine("Tweet, tweet!");

    public void Fly() =>
        Console.WriteLine("Flying using its wings.");
}
