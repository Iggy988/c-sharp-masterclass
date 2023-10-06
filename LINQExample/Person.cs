internal class Person
{
    public string Name;
    public string Countury;

    public Person(string name, string countury)
    {
        Name = name;
        Countury = countury;
    }

    public override string ToString()
    {
        return $"{Name}, {Countury}";
    }
}