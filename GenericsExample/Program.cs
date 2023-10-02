using System.Collections;
using System.Diagnostics;
using System.Numerics;
//By using generic types, we can define the behavior of a type(List etc.),
//once and reuse it for multiple types, reducing the amount of code we need to write

//Data structures are types meant for storing and orginizing data so that it can be accessed and modified efficiently
// arrays, stacks, queues, dictionaries..,

//Algoritm is a set of steps or instructions that are followed in ordder to solve a problem

//Tuple represent set of value

// Type is a class representing types. It contains props like the types name, namespace it belongs to, the base type,
// or the list of the types constructors. It is a part of reflection mechanism

// IComparable<T> it is an interface  that provides a way to compare 2 objects for sorting purposes
//Sorting -> reordering the elements of a collection in an ascending or descending order


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
numbers.Sort();
var ints3 = new List<int> { 1, 2, 3};

ints3.AddToFront(10);
ints3.AddToFront<int>(11);
//ints.AddToFront<int>("string");
//Tuple<int, int> minAndMax = GetMinAndMax(numbers);

//var twoStrings = new Tuple<string, string>("ime", "prezime");
//var differentTuple = new SimpleTuple<string, int>("godina", 2);
//var threeItems = new SimpleTuple<string, int, bool>("godina", 2, false);

//Console.WriteLine("Smallest number: " + minAndMax.Item1);
//Console.WriteLine("Largest number: " + minAndMax.Item2);



ArrayList ints2 = new ArrayList { 2, 3, 4, 5, 6};
ArrayList strings = new ArrayList { "aa", "b", "cccc", "ddd" };
strings.Sort();

ArrayList variousItems = new ArrayList { 1, "abc", false, new DateTime()};
object[] objects = new object[] { 1, "abc", false, new DateTime() };

int sum = 0;

foreach (var number in ints3)
{
    if (number is int)
    {
        sum += (int)number;
    }
    
}

var decimals = new List<decimal> { 1.1m, 2.2m, 23.20m, 12m };
var ints = decimals.ConvertTo<decimal, int>();

var floats = new List<float> { 1.2f, 3.2f, -100.02f};
List<long> longs = floats.ConvertTo<float, long>();

//var dates = new List<DateTime> { new DateTime(2023, 12, 15) }; 
//var intss = dates.ConvertTo<DateTime, int>(); ne mozemo cast DateTime to int

//var points = CreateCollectionOfRandomLength<Point>(100);
//var intsss = CreateCollectionOfRandomLength<int>(100);
Stopwatch stopwatch = Stopwatch.StartNew();
//stopwatch.Start();
var dates = CreateCollectionOfRandomLength<DateTime>(0);
stopwatch.Stop();
Console.WriteLine($"Execution took {stopwatch.ElapsedMilliseconds} ms.");

var people = new List<Person>()
{
    new Person {Name = "John", YearOfBirth = 1980},
    new Person {Name = "Anna", YearOfBirth = 1915},
    new Person {Name = "Bill", YearOfBirth = 2011},
};
people.Sort();

var employees = new List<Employee>()
{
    new Employee {Name = "John", YearOfBirth = 1980},
    new Employee {Name = "Anna", YearOfBirth = 1915},
    new Employee {Name = "Bill", YearOfBirth = 2011},
};

var validPeople = GetOnlyValid(people);
var validEmployees = GetOnlyValid(employees);

foreach (var employee in validEmployees)
{
    //((Employee)person).GoToWork();
    employee.GoToWork(); //zato sto smo koristili type constraint
}

var john = new Person { Name = "John", YearOfBirth = 1980 };
var anna = new Person { Name = "Anna", YearOfBirth = 1915 };

PrintInOrder(13, 7);
PrintInOrder("aaa", "bb");
PrintInOrder(john, anna);

Console.WriteLine("Square of 2 is: " + Calculator.Square(2));
Console.WriteLine("Square of 4m is: " + Calculator.Square(4m));
Console.WriteLine("Square of 6d is: " + Calculator.Square(6d));

Console.ReadKey();

void PrintInOrder<T>(T first, T second) where T: IComparable<T>
{
    if (first.CompareTo(second) > 0)
    {
        Console.WriteLine($"{second} {first}");
    }
    else
    {
        Console.WriteLine($"{first} {second}");
    }
}

IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons) where TPerson : Person
{
    var result = new List<TPerson>();

    foreach (var person in persons)
    {
        if (person.YearOfBirth > 1900 && person.YearOfBirth < DateTime.Now.Year)
        {
            result.Add(person);
        }
    }

    return result;
}

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

//Type constraints limit the types that can be used as the generic
//parameter to some specific group that must meet certain criteria. (where T: new())
IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T : new()
{
    var length = 100000000;//new Random().Next(maxLength + 1);
    //kad ubacimo length u prop, size ce biti odredjen u momentu kreacije objekta, no resizing needed
    var result = new List<T>(length); 

    for (int i = 0; i < length; ++i)
    {
        //da nema type constarinta ne bi mogli dodati novi T object posto ne zna se koji mu je type
        result.Add(new T());
        //result.Add(new Point()); moramo dodati params
    }

    return result;
}

public static class Calculator
{
    public static T Square<T> (T input) where T: INumber<T> => input * input;
    // nekad je moralo da se pravi vise metoda koja obradjuje svaki type posebno
    //public static int Square(int input) => input * input;
    //public static decimal Square(decimal input) => input * input;
    //public static double Square(double input) => input * input;

}
