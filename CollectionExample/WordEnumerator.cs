using System.Collections;

public class WordEnumerator : IEnumerator<string>
{
    //moramo staviti pocetnu poziciju na -1 jer kad budemo pozivali bice 0 na prvoj exekuciji metode MoveNext()
    private const int InitialPosition = -1; 
    private int _currentPosition = InitialPosition;
    private readonly string[] _words;

    public WordEnumerator(string[] words)
    {
        _words = words;
    }

    object IEnumerator.Current => Current;

    public string Current
    {
        get
        {
            try
            {
                return _words[_currentPosition];
            }
            catch (IndexOutOfRangeException ex)
            {

                throw new IndexOutOfRangeException($"{nameof(CustomCollection)}'s end reached. ", ex);
            }
            
        }
    }

    public bool MoveNext()
    {
        ++_currentPosition;
        return _currentPosition < _words.Length;
    }

    public void Reset()
    {
        _currentPosition = InitialPosition;
    }

    public void Dispose()
    {

    }
}
