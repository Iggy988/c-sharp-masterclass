using System.Collections;

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
