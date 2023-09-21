using InterfaceExample.Flyables.Interfaces;

namespace InterfaceExample.Flyables;

public class Plane : IFlyable, IFuelable
{
    public void Fly() =>
        Console.WriteLine("Flying using jet propulsion.");

    public void Fuel() =>
        Console.WriteLine("Filling tanks with jet fuel.");
}
