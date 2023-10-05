var dataDownloader = new SlowDataDownloader();

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{
    private readonly Cache<string, string> _cache = new();
    // this method use cache class
    public string DownloadData(string resourceId)
    {
        return _cache.Get(resourceId, DownloadDataWithoutCaching);
    }

    private string DownloadDataWithoutCaching(string resourceId)
    {
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }
}

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