using System.Collections;
//By using generic types, we can define the behavior of a type(List etc.),
//once and reuse it for multiple types, reducing the amount of code we need to write

//Data structures are types meant for storing and orginizing data so that it can be accessed and modified efficiently
// arrays, stacks, queues, dictionaries..,

//Algoritm is a set of steps or instructions that are followed in ordder to solve a problem

//Tuple represent set of value


//var words = new List<string> { "ime", "prezime", "godina"};
//var dates = new List<DateTime> { new DateTime(day: 12, month: 3, year: 2023)};

//var numbers = new SimpleList<int>();
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(3);
//numbers.Add(4);
//numbers.Add(5);

//numbers.RemoveAt(2);

//var words = new SimpleList<string>();
//words.Add("aaa");
//words.Add("bbb");
//words.Add("ccc");

//var dates = new SimpleList<DateTime>();
//dates.Add(new DateTime(day: 12, month: 3, year: 2023));
//dates.Add(new DateTime(day: 21, month: 5, year: 2018));
//dates.Add(new DateTime(day: 5, month: 1, year: 1996));


var numbers = new List<int> { 1, 2, 3, 4, 5 };
var ints = new List<int> { 1, 2, 3};

ints.AddToFront(10);
ints.AddToFront<int>(11);
//ints.AddToFront<int>("string");
//Tuple<int, int> minAndMax = GetMinAndMax(numbers);

//var twoStrings = new Tuple<string, string>("ime", "prezime");
//var differentTuple = new SimpleTuple<string, int>("godina", 2);
//var threeItems = new SimpleTuple<string, int, bool>("godina", 2, false);

//Console.WriteLine("Smallest number: " + minAndMax.Item1);
//Console.WriteLine("Largest number: " + minAndMax.Item2);



ArrayList ints2 = new ArrayList { 2, 3, 4, 5, 6};
ArrayList strings = new ArrayList { "a", "b", "c", "d" };

ArrayList variousItems = new ArrayList { 1, "abc", false, new DateTime()};
object[] objects = new object[] { 1, "abc", false, new DateTime() };

int sum = 0;

foreach (var number in ints)
{
    if (number is int)
    {
        sum += (int)number;
    }
    
} 

Console.ReadKey();

Tuple<int, int> GetMinAndMax(IEnumerable<int> input)
{
    if (!input.Any())
    {
        throw new InvalidOperationException($"The input collection cannot be empty");
    }
    int min = input.First();   
    int max = input.First();   

    foreach (int number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
        if (number < min)
        {
            min = number;
        }
    }

    return new Tuple<int, int>(min, max);
}

static class ListExtensions
{
    public static void AddToFront<T>(this List<T> list, T value)
    {
        list.Insert(0, value);
    }
}
