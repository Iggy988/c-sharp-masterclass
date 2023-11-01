namespace Utilities;

public static class EnumerableExtensions 
{
    public static string AsString<T>(this IEnumerable<T> items)
    {
        return string.Join(Environment.NewLine, items);
    }
}

public class PublicClass
{
    //public InternalClass InternalClass { get; set; } ne moze
    private InternalClass _internalClass;
    public int SomeMethod()
    {
        var someVariable =  new InternalClass();
        return 0;
    }

    protected internal  void ProtectedInternal() { }
}

internal class InternalClass
{
    public static void PublishMethod()
    {
        new PublicClass().ProtectedInternal();
    }
}
