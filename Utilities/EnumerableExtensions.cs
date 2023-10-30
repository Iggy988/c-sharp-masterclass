namespace Utilities;

public static class EnumerableExtensions 
{
    public static string AsString<T>(this IEnumerable<T> items)
    {
        return string.Join(Environment.NewLine, items);
    }
}
