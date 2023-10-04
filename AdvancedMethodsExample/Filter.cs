

public class Filter
{
    public IEnumerable<T> FilterBy<T>(
        Func<T, bool> predicate,
        IEnumerable<T> numbers)
    {
        var result = new List<T>();

        foreach (var number in numbers)
        {
            if (predicate(number))
            {
                result.Add(number);
            }
        }

        return result;
    }
}