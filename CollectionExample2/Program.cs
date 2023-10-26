
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

public static class ListExtension
{
    //Binary search
    public static int? FindIndexInSorted<T>(this IList<T> list, T itemToFind) where T : IComparable<T>
    {
        int leftBound = 0;
        int rightBound = list.Count -1;

        while(leftBound <= rightBound) 
        {
            int middleIndex = (leftBound + rightBound) / 2;
            if (itemToFind.Equals(list[middleIndex]))
            {
                return middleIndex;
            }
            else if (itemToFind.CompareTo(list[middleIndex]) < 0)
            {
                rightBound = middleIndex - 1;
            }
            else
            {
                leftBound = middleIndex + 1;
            }

        }
        return null;
    }
}
