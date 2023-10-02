
//TPerson can be of any type as long is derived from Person(or it is Person itself)

public class Person : IComparable<Person>
{

    public string Name { get; init; }
    public int YearOfBirth { get; init; }

    public override string ToString() => $"{Name} is born {YearOfBirth}.";
    public int CompareTo(Person other)
    {
        if (YearOfBirth < other.YearOfBirth)
        {
            return 1;
        }
        else if (YearOfBirth > other.YearOfBirth)
        {
            return -1;
        }
        return 0;
    }
}
