
var convert = new ObjectToTextConverter();
Console.WriteLine(convert.Convert(new House("Some address", 32.2, 2)));
Console.ReadKey();

class ObjectToTextConverter
{
    public string Convert(object obj)
    {
        Type type = obj.GetType();
        var properties = type.GetProperties().Where(p => p.Name != "EqualityContract");

        return string.Join(", ", properties.Select(p => $"{p.Name} is {p.GetValue(obj)}"));   
    }
}

public record Pet(string Name, PetType PetType, float Weight);
public record House(string Address, double Area, int Floors);
public enum PetType { Cat, Dog, Fish}