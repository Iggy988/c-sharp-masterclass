
//Point nullPoint = null; // structs are not nullable
Person nullPerson = null;

var point = new Point(1, 3);
var point2 = new Point(); // structs has always parameterless constructor
//Person person = new Person(); // moramo unijeti parametre

var anotherPoint = point;
anotherPoint.Y = 100;

Console.WriteLine(point);
Console.WriteLine(anotherPoint);

SomeMethod(5); //value type
//SomeMethod(new Person()); // ne moze reference type


var fishyStruct1 = new FishyStruct { Numbers = new List<int> { 1,2,3} };
var fishyStruct2 = fishyStruct1;

fishyStruct2.Numbers.Clear();

Console.ReadKey();

void SomeMethod<T>(T param) where T: struct
{

}

struct FishyStruct
{
    public List<int> Numbers { get; init; }
}

struct Point : IComparable<Point> // can inherit Interface
{

    //public Point ClosestPoint { get; } //cannot have property of same type- cnnot contain a cycle in its definition -stored at stack as value data type

    // structs cant have virtual or abstract methods
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point()
    {
        X = 1;
        Y = 2;
    }

    public override string ToString()
    {
        return "X: "+ X + ", Y: " + Y;
    }

    public int CompareTo(Point other)
    {
        throw new NotImplementedException();
    }

    //~Finalizer(){ } //cannot have finalizer
}

//struct DerivedPoint : Point { } // all structs are sealed - cannot be inherited

class Person
{
    public Person ColssetsPerson { get; } //cycle in its definition -same type property

    private Point _favoritePoint; // ako nije assigned bice X: 0 Y: 0 - nije nullable
    private Person _favoritePerson; // ako nije assigned bice null
    public int Id { get; init; }
    public int Name { get; init; }

    public Person(int id, int name)
    {
        Id = id;
        Name = name;
    }



}