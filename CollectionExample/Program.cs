using System.Collections;
//IEnumerable
//var text = "hello there";

//foreach(char c in text)
//{
//    Console.WriteLine(c);
//}
var customCollection = new CustomCollection(new string[] { "aaa", "bbb", "ccc" });
foreach (var w in customCollection)
{
    Console.WriteLine(w);
}

//var words = new string[] { "aaa", "bbb", "ccc" };
//foreach (var word in words ) Console.WriteLine( word );

//IEnumerator wordsEnumerator = words.GetEnumerator();
//object currentWord;
//while (wordsEnumerator.MoveNext())
//{
//    currentWord = wordsEnumerator.Current;
//    Console.WriteLine( currentWord );
//}

Console.ReadKey();

public class CustomCollection : IEnumerable
{
    public string[] Words { get;  }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    public IEnumerator GetEnumerator()
    {
        return new WordEnumerator(Words);
    }
}

public class WordEnumerator : IEnumerator
{
    //moramo staviti pocetnu poziciju na -1 jer kad budemo pozivali bice 0 na prvoj exekuciji metode MoveNext()
    private const int InitialPosition = -1; 
    private int _currentPosition = InitialPosition;
    private readonly string[] _words;

    public WordEnumerator(string[] words)
    {
        _words = words;
    }

    public object Current
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
}
