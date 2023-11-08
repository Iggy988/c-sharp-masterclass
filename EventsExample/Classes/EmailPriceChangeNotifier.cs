



public class EmailPriceChangeNotifier
{
    private readonly decimal _notificationTreshold;

    public EmailPriceChangeNotifier(decimal notificationTreshold)
    {
        _notificationTreshold = notificationTreshold;
    }

    public void Update(decimal price)
    {
        if (price > _notificationTreshold)
        {
            Console.WriteLine($"Sending an email saying that the gold price exceeded {_notificationTreshold} and is now {price}");
        }
    }
}
