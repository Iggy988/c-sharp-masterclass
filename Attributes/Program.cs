
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

[SomeAttribute(new int[] { 1,2,3})] // ne moze class
public class SomeClass
{

}

public class SomeAttribute : Attribute
{
    public int[] Numbers { get; }

    public SomeAttribute(int[] numbers)
    {
        Numbers = numbers;
    }
}