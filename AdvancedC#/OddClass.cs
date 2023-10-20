
//Null forgiving operator
public class OddClass
{
    public string? Text { get; private set; }
    private bool _isInitialized;

    public void Init(string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));
        Text = text;
        _isInitialized = true;
    }
    public void DoWork()
    {
        if (!_isInitialized)
        {
            throw new InvalidOperationException("The class is not initialized.");
        }
        Console.WriteLine("The lenght of text is: " + Text!.Length);
    }

}