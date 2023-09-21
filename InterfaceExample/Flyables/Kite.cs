using InterfaceExample.Flyables.Interfaces;

namespace InterfaceExample.Flyables;

public class Kite : IFlyable
{
    public void Fly() =>
        Console.WriteLine("Flying carried by the wind.");
}
