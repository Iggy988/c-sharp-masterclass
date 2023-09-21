
namespace InterfaceExample.Animals;

class HousePet : Animal
{
    public override void MakeSound() =>
            Console.WriteLine(
                "<noises of happines when human comes home>");
}
