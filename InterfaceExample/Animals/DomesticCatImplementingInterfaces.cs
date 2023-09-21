using InterfaceExample.Animals.Interfaces;

namespace InterfaceExample.Animals;

class DomesticCatImplementingInterfaces : IFeline, IHousePet
{
    public void HideInCardboardBox() =>
        Console.WriteLine("Hide in any cardboard box in sight.");

    public void MakeSound()
    {
        Console.WriteLine("Purr purr.");
    }

    public void TakeToVet() =>
        Console.WriteLine("Take to Dr. Paws using a carrier.");
}