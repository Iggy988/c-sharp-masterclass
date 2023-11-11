
using EventsExamples.Classes;

public class EmailPriceChangeNotifier 
{
    private readonly decimal _notificationTreshold;

    public EmailPriceChangeNotifier(decimal notificationTreshold)
    {
        _notificationTreshold = notificationTreshold;
    }

    public void Update(object? sender, PriceReadEventArgs eventArgs)
    {
        if (eventArgs.Price > _notificationTreshold)
        {
            Console.WriteLine($"Sending an email saying that the gold price exceeded {_notificationTreshold} and is now {eventArgs.Price}\n");
        }
    }
}
