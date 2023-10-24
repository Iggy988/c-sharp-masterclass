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
var enumerator = customCollection.GetEnumerator();

//var words = new string[] { "aaa", "bbb", "ccc" };
//foreach (var word in words ) Console.WriteLine( word );

//IEnumerator wordsEnumerator = words.GetEnumerator();
//object currentWord;
//while (wordsEnumerator.MoveNext())
//{
//    currentWord = wordsEnumerator.Current;
//    Console.WriteLine( currentWord );
//}

//Indexer
customCollection[1] = "abc";

// da bi radilo moramo dodati parameterless constructor and Add method
var newCollection = new CustomCollection
{
    "one", "two", "three"
};

var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
var array = new int[10];
numbers.CopyTo(array, 2);

var numbers2 = new List<int>(new int[] { 1, 2, 3, });

Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    public CustomCollection()
    {
        Words = new string[10];
    }

    private int _currentIndex = 0;
    public void Add(string word)
    {
        Words[_currentIndex] = word;  
        ++_currentIndex;
    }

    //indexer
    public string this[int index]
    {
        get => Words[index];
        set => Words[index] = value;
    }

    //this method returns Generic IEnumerator<T>
    IEnumerator IEnumerable.GetEnumerator() //explicit
    {
        return GetEnumerator();
    }

    public IEnumerator<string> GetEnumerator()// Implicit
    {
        return new WordEnumerator(Words);
    }
}

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
