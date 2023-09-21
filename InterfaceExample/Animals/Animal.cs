namespace InterfaceExample.Animals;

class Animal
{
    public virtual void MakeSound() =>
        Console.WriteLine(
            "Make a generic animal sound.");
}
