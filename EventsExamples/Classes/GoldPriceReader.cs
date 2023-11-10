
using EventsExamples.Classes;

public class GoldPriceReader 
{

    //event mora biti public da bi druge class(observers) mogle da se attach metode to it
    // public event PriceRead? PriceRead;

    public event EventHandler<PriceReadEventArgs>? PriceRead;


    public void ReadCurrentPrice()
    {
        var courentGoldPrice = new Random().Next(20_000, 50_000);

        OnPriceRead(courentGoldPrice);

    }

    private void OnPriceRead(decimal price)
    {
        //PriceRead(price);
        //PriceRead?.Invoke(price); //invoke all methods from event
        PriceRead?.Invoke(
            this,//Sender
            new PriceReadEventArgs(price)); //Event arguments
    }
}
