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

//using reflection to see what interfaces array implements
var array2 = new int[] { 1,2,3,4};
var implementedInterfaces = array2.GetType().GetInterfaces();

ICollection<int> arrayCollection = array2;
//array2.Add(3);
arrayCollection.Add(3); //collection is not fixed size

Console.ReadKey();
