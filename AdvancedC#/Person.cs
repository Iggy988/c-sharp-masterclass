







class Person
{
    public int Id { get; init; }
    public string Name { get; init; }

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        return obj is Person other &&
            Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id;
    }
}