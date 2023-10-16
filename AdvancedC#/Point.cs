







readonly struct Point : IComparable<Point> // can inherit Interface
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

    public int CompareTo(Point other)
    {
        throw new NotImplementedException();
    }

    //~Finalizer(){ } //cannot have finalizer
}
