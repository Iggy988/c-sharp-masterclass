


public class GoldPriceReader
{
    private int _courentGoldPrice;
    private readonly EmailPriceChangeNotifier _emailPriceChangeNotifier;
    private readonly PushPriceChangeNotifier _pushPriceChangeNotifier;

    public GoldPriceReader(EmailPriceChangeNotifier emailPriceChangeNotifier, PushPriceChangeNotifier pushPriceChangeNotifier)
    {
        _emailPriceChangeNotifier = emailPriceChangeNotifier;
        _pushPriceChangeNotifier = pushPriceChangeNotifier;
    }


    public void ReadCurrentPrice()
    {
        _courentGoldPrice = new Random().Next(20_000, 50_000);

        _emailPriceChangeNotifier.Update(_courentGoldPrice);
        _pushPriceChangeNotifier.Update(_courentGoldPrice);
    }
}
