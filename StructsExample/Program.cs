
var point = new Point(1, 3);

var anotherPoint = point;
anotherPoint.Y = 100;

Console.WriteLine(point);
Console.WriteLine(anotherPoint);

SomeMethod(5); //value type
//SomeMethod(new Person()); // ne moze reference type

Console.ReadKey();

void SomeMethod<T>(T param) where T: struct
{

}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return "X: "+ X + ", Y: " + Y;
    }
}

class Person
{
    public int Id { get; init; }
    public string Name { get; init; }    
}