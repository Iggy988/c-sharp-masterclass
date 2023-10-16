
class Person
{
    public Person ColssetsPerson { get; } //cycle in its definition -same type property

    private Point _favoritePoint; // ako nije assigned bice X: 0 Y: 0 - nije nullable
    private Person _favoritePerson; // ako nije assigned bice null
    public int Id { get; init; }
    public string Name { get; init; }

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }



}