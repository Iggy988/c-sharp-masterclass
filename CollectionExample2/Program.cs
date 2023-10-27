
//readonly collection
using System.Collections.ObjectModel;
using System.Diagnostics;

var planets = ReadPlanets();
//var asList = (List<string>)planets;
var asList = (ReadOnlyCollection<string>)planets;
//planets.Clear();
//asList.Clear();
//asList[0] = "abc";

var dictionary = new Dictionary<string, int>
{
    ["aaa"] = 1
};

var readonlyDic = new ReadOnlyDictionary<string, int>(dictionary);
//readonlyDic.Clear();
//readonlyDic["bbb"] = 5;

//binary search algorithm
var sortedList = new List<int> { 1, 3, 4, 5, 6, 11, 12, 14, 16, 18 };
var indexOf1 = sortedList.FindIndexInSorted(1);
var indexof11 = sortedList.FindIndexInSorted(11);
var indexOf12 = sortedList.FindIndexInSorted(12);
var indexOf18 = sortedList.FindIndexInSorted(18);
var indexOf13 = sortedList.FindIndexInSorted(13);


var input = Enumerable.Range(0, 100_000_000).ToArray();

Stopwatch stopwatch = Stopwatch.StartNew();
// improving performance list.Lenght -kad znamo koliko elementa ima
var list = new List<int>(input.Length);
foreach (var item in input)
{
    list.Add(item);
} 

stopwatch.Stop();
Console.WriteLine($"Took: {stopwatch.ElapsedMilliseconds} ms");

list.Clear();
list.TrimExcess();

list.AddRange(input);

list.RemoveRange(5, 10);
list.RemoveAt(7); //O(N)
list.Remove(99);

//Linked List
var linkedList = new LinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddLast(2);
linkedList.AddLast(3);
linkedList.Remove(2);


//Hash Set
var hashSet = new HashSet<string>();
hashSet.Add("a");
hashSet.Add("b");
hashSet.Add("c");


//Queues
var queue = new Queue<string>();
queue.Enqueue("a");
queue.Enqueue("b");
queue.Enqueue("c");
queue.Enqueue("d");

var first = queue.Dequeue();
var second = queue.Peek();   

//smaller priority number higher priorety
var prioretyQueue = new PriorityQueue<string, int>();
prioretyQueue.Enqueue("a", 5);
prioretyQueue.Enqueue("b", 5);
prioretyQueue.Enqueue("c", 2);
prioretyQueue.Enqueue("d", 3);

var firstPriority = prioretyQueue.Dequeue();


//the Stack
var stack = new Stack<string>();
stack.Push("a");
stack.Push("b");
stack.Push("c");
stack.Push("d");

var top = stack.Pop();
var secondToTop = stack.Peek();


//params
//Console.WriteLine(Calculator.Add(new int[] { 1,2,3}));
//Console.WriteLine(Calculator.Add(new int[] { 1,2,3}));
Console.WriteLine(Calculator.Add(1,2,3));

Console.ReadKey();


//Big O Notation
bool Contains<T>(T itemToCheck, IEnumerable<T> input)
{
    foreach (var item in input)
    {
        if (item.Equals(itemToCheck))
        {
            return true;
        }
    }
    return false;
}

IEnumerable<string> ReadPlanets()
{
    var result = new List<string>
    {
        "Mars",
        "Earth",
        "Pluto"
    };    
    return new ReadOnlyCollection<string>(result) ;  
}
