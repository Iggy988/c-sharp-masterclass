const int treshold = 30_000;

var emailPriceChangeNotifier = new EmailPriceChangeNotifier(treshold);
var pushPriceChangeNotifier = new PushPriceChangeNotifier(treshold);

var goldPriceReader = new GoldPriceReader(emailPriceChangeNotifier, pushPriceChangeNotifier);

for (int i = 0; i < 3; ++i)
{
    goldPriceReader.ReadCurrentPrice();
}


Console.WriteLine("Press enter to close.");
Console.ReadKey();
