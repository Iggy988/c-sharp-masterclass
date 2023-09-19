






public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}