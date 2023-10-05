
public class Cache<TKey, TData>
{
    private readonly Dictionary<TKey, TData> _cachedData = new();

    //Get method takes 2 param: key that identifies some data, and getForTheFirstTime method that can use this key to retrive data
    public TData Get(TKey key, Func<TKey, TData> getForTheFirstTime)
    {
        //if this data is not yet cached -> not yet requested in the past
        if (!_cachedData.ContainsKey(key))
        {
            //getForTheFirstTime will be executed to fetch this data for the first time - stored in dictionary
            _cachedData[key] = getForTheFirstTime(key);
        }
        // we can find data in cached dictionary
        return _cachedData[key];
    } 
}