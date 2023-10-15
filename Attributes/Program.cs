
var validPerson = new Person("Iggy", 34);
var invalidDog = new Dog("R");
var validator = new Validator();
Console.WriteLine(validator.Validate(validPerson) ? "Person is valid" : "Person is invalid");
Console.WriteLine(validator.Validate(invalidDog) ? "Dog is valid" : "Dog is invalid");

Console.ReadKey();


public class Dog
{
    [StringLengthValidate(2,10)]
    public string Name { get; } //lenght must be between 2 and 10
    public Dog(string name) => Name = name; 
}

public class Person
{
    [StringLengthValidate(2, 25)]
    public string Name { get; } //lenght must be between 2 and 25
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public Person(string name) => Name = name;
}

//custom attribute
[AttributeUsage(AttributeTargets.Property)]
class StringLengthValidate: Attribute
{
    public int Min { get; }
    public int Max { get; }

    public StringLengthValidate(int min, int max)
    {
        Min = min;
        Max = max;
    }
}

class Validator
{
    public bool Validate(object obj)
    {
        var type = obj.GetType();
        var propertiesToValidate = type.GetProperties()
            // select those properties of this type for which is this attribute defined
            .Where(prop => Attribute.IsDefined(prop, typeof(StringLengthValidate)));

        foreach (var prop in propertiesToValidate)
        {
            object? propertyValue = prop.GetValue(obj);
            // prvo provjeravamo da li je properyValue string
            if (propertyValue is not string)
            {
                throw new InvalidOperationException($"Attribute {nameof(StringLengthValidate)} can only be applied to strings");
            }

            // validate
            var value = (string)propertyValue; // cast property to string, it is safe, we checked lines before
            var attribute = (StringLengthValidate)prop.GetCustomAttributes(typeof(StringLengthValidate), true).First();
            if (value.Length < attribute.Min || value.Length > attribute.Max)
            {
                Console.WriteLine($"Property {prop.Name} is ivalid, value is {value}");
                return false;
            }
        }

        return true;
        
    }
}