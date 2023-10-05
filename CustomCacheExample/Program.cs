//var dataDownloader = new SlowDataDownloader();
var catche = new Cache<string, string>();
var dataDownloader = new CachingDataDownloader( new SlowDataDownloader(), catche);

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
   
    public string DownloadData(string resourceId)
    {
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }

}

public class CachingDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader;
    private readonly Cache<string, string> _cache =  new();
    public CachingDataDownloader(IDataDownloader dataDownloader, Cache<string, string> cache)
    {
        _dataDownloader = dataDownloader;
        _cache = cache;
    }
    public string DownloadData(string resourceId)
    {
        return _cache.Get(resourceId, _dataDownloader.DownloadData);
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