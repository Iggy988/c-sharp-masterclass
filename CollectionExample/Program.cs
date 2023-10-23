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
        throw new NotImplementedException();
    }
}
