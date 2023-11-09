// observarble : 
public class GoldPriceReader : IObservable<decimal>
{
    private int _courentGoldPrice;
    //adding observers to observers list owned by observable
    private readonly List<IObserver<decimal>> _observers = new();
    //private readonly EmailPriceChangeNotifier _emailPriceChangeNotifier; //observer
    //private readonly PushPriceChangeNotifier _pushPriceChangeNotifier; //observer

    //public GoldPriceReader(EmailPriceChangeNotifier emailPriceChangeNotifier, PushPriceChangeNotifier pushPriceChangeNotifier)
    //{
    //    _emailPriceChangeNotifier = emailPriceChangeNotifier;
    //    _pushPriceChangeNotifier = pushPriceChangeNotifier;
    //}


    public void ReadCurrentPrice()
    {
        _courentGoldPrice = new Random().Next(20_000, 50_000);

        //_emailPriceChangeNotifier.Update(_courentGoldPrice);
        //_pushPriceChangeNotifier.Update(_courentGoldPrice);

        NotifyObservers();
    }

    //ading to list
    //attach observer
    public void AttachObserver(IObserver<decimal> observer)
    {
        _observers.Add(observer);
    }

    //removing from list
    //detach observer
    public void DetachObserver(IObserver<decimal> observer)
    {
        _observers.Remove(observer);
    }
    //iterate list
    //notify observers
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_courentGoldPrice);
        }
    }
}
