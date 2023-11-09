
public class GoldPriceReader 
{

    //event mora biti public da bi druge class(observers) mogle da se attach metode to it
    public event PriceRead? PriceRead;

    private int _courentGoldPrice;

    public void ReadCurrentPrice()
    {
        _courentGoldPrice = new Random().Next(20_000, 50_000);


    }


}
