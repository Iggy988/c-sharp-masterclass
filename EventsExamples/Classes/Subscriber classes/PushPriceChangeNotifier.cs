
using EventsExamples.Classes;

public class PushPriceChangeNotifier 
{
    private readonly decimal _notificationTreshold;

    public PushPriceChangeNotifier(decimal notificationTreshold)
    {
        _notificationTreshold = notificationTreshold;
    }
    public void Update(object? sender, PriceReadEventArgs eventArgs)
    {
        if (eventArgs.Price > _notificationTreshold)
        {
            Console.WriteLine($"Sending a push notification saying that the gold price exceeded {_notificationTreshold} and is now {eventArgs.Price}\n");
        }
    }
}
