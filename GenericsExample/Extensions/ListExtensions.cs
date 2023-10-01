static class ListExtensions
{
    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> decimals)
    {
        //create new list of ints
        var result = new List<TTarget>();
        //iterate list of decimals
        foreach (var item in decimals)
        {
            TTarget itemAfterCasting = (TTarget)Convert.ChangeType(item, typeof(TTarget));
            //casting every one to int
            result.Add(itemAfterCasting);
        }
        //return collection of integers
        return result;
    }
    public static void AddToFront<T>(this List<T> list, T value)
    {
        list.Insert(0, value);
    }
}
