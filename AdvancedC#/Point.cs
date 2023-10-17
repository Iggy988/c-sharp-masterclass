
using System.Diagnostics.CodeAnalysis;

readonly struct Point : IEquatable<Point>, IComparable<Point> // can inherit Interface
{

    //public Point ClosestPoint { get; } //cannot have property of same type- cnnot contain a cycle in its definition -stored at stack as value data type

    // structs cant have virtual or abstract methods
    private readonly int _z;
    public int X { get; init; }
    public int Y { get; init; } //struct should be immutable

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
        return "X: " + X + ", Y: " + Y;
    }

    public bool Equals(Point other)
    {
        return X == other.X && Y == other.Y;
    }

    public int CompareTo(Point other)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        return obj is Point point &&
               //X == point.X &&
               //Y == point.Y;
               Equals(point);
    }


    //~Finalizer(){ } //cannot have finalizer
}
