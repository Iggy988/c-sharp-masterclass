



public class PushPriceChangeNotifier : IObserver<decimal>
{
    private readonly decimal _notificationTreshold;

    public PushPriceChangeNotifier(decimal notificationTreshold)
    {
        _notificationTreshold = notificationTreshold;
    }
    public void Update(decimal price)
    {
        if (price > _notificationTreshold)
        {
            Console.WriteLine($"Sending a push notification saying that the gold price exceeded {_notificationTreshold} and is now {price}");
        }
    }
}
