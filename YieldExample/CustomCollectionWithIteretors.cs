using System.Collections;

public class CustomCollectionWithIteretors : IEnumerable<string>
{
    public string[] Words { get; }

    public CustomCollectionWithIteretors(string[] words)
    {
        Words = words;
    }

    public CustomCollectionWithIteretors()
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
        //return new WordEnumerator2(Words);
        //foreach (string word in Words) 
        //{
        //    yield return word;
        //}

        IEnumerable<string> words = Words;
        return words.GetEnumerator();

    }
}
