
//By using generic types, we can define the behavior of a type(List etc.),
//once and reuse it for multiple types, reducing the amount of code we need to write

//Data structures are types meant for storing and orginizing data so that it can be accessed and modified efficiently
// arrays, stacks, queues, dictionaries..,

//Algoritm is a set of steps or instructions that are followed in ordder to solve a problem


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
TwoInts minAndMax = GetMinAndMax(numbers);
Console.WriteLine("Smallest number: " + minAndMax.Int1);
Console.WriteLine("Largest number: " + minAndMax.Int2);

Console.ReadKey();

TwoInts GetMinAndMax(IEnumerable<int> input)
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

    return new TwoInts(min, max);
}

public class TwoInts
{
    public TwoInts(int int1, int int2)
    {
        Int1 = int1;
        Int2 = int2;
    }

    public int Int1 { get; }
    public int Int2 { get; }
}

public class TwoStrings
{
    public TwoStrings(string string1, string string2)
    {
        String1 = string1;
        String2 = string2;
    }

    public string String1 { get; }
    public string String2 { get; }
}
