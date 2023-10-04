
var numbers = new[] { 1, 7, 2, 19, 3 };
Func<int, bool> predicate1 = IsLargerThan10;
Console.WriteLine("IsAnyLargerThan10? " + IsAny(numbers, predicate1));
Console.WriteLine("IsAnyLargerThan10? " + IsAny(numbers, IsLargerThan10));

Func<int, bool> predicate2 = IsEven;


Console.WriteLine("IsAnyLargerThan10? " + IsAny(numbers, predicate2));
Console.WriteLine("IsAnyLargerThan10? " + IsAny(numbers, IsEven));

//Lambda expression / param => expression  () => expression - no params lambda
Console.WriteLine("IsAnyEven " + IsAny(numbers, n => n % 2 ==0));


bool IsLargerThan10(int number)
{
    return number > 10;
}

bool IsEven(int number)
{
    return number % 2 == 0;
}



//Func can assign any function that is taking number and returning bool
// last param is always returning type
bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
{
    foreach (var number in numbers)
    {
        if (predicate(number))
        {
            return true;
        }

    }
    return false;
}




Console.WriteLine("IsAnyLargerThan10? " + IsAnyLargerThan10(numbers));
//Console.WriteLine("IsAnyEven? " + IsAnyEven(numbers));

Func<int, DateTime, string, decimal> someFunc;
Action<string, string, bool> someAction;

bool IsAnyLargerThan10(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        if (number > 10)
        {
            return true;
        }
       
    }
    return false;
}

ProcessString delegate1 = TrimTo5Letters;
ProcessString delegate2 = ToUpper;

Func<string, string> processString1 = TrimTo5Letters;
Func<string, string> processString2 = ToUpper;

Console.WriteLine(delegate1("Helloooooo"));
Console.WriteLine(delegate2("Helloooooo"));

Print print1 = text => Console.WriteLine(text.ToUpper());
Print print2 = text => Console.WriteLine(text.ToLower());
Print multicast = print1 + print2;
Print print4 = text => Console.WriteLine(text.Substring(0, 4));
//A delegate variable that holds references to more than 1 function is called a multicast delegate
multicast += print4;
multicast("PeroDeformero");

Func<string, string, int> sumLengths = /*(text1, text2) => text1.Length + text2.Length;*/ SumLength;

//Dictionary is a collection of key-value pairs
var countryToCurrencyMapping = new Dictionary<string, string>
{
    { "Russia", "Ruble" },
    { "Germany", "EUR" },
};

var countryToCurrencyMapping2 = new Dictionary<string, string>
{
    ["HR"] = "HRK",
    ["SR"] = "SRD",
    ["China"] = "JEN",
};

countryToCurrencyMapping.Add("USA", "USD");
countryToCurrencyMapping.Add("India", "INR");
countryToCurrencyMapping.Add("BiH", "KM");

foreach (var country in countryToCurrencyMapping)
{
    Console.WriteLine(country.Key + " - " + country.Value);
}

Console.WriteLine("Currency in BiH is " + countryToCurrencyMapping["BiH"]);

countryToCurrencyMapping["Poland"] = "EUR";


var numberss = new List<int> { 10, 12, -100, 55, 16, 23 };
var filteringStartegySelector = new FilteringStrategySelector();

Console.WriteLine(@"Select filter:");
Console.WriteLine(string.Join(Environment.NewLine, filteringStartegySelector.FilteringStrategiesNames));


//List<int> result;
//switch (userInput)
//{
//    case "Even":
//        result = Select(numberss, number => number % 2 == 0);
//        break;
//    case "Odd":
//        result = Select(numberss, number => number % 2 == 1);
//        break;
//    case "Positive":
//        result = Select(numberss, number => number > 0);
//        break;
//    default:
//        throw new NotSupportedException("User input is not valid");      
//}

//List<int> Select(List<int> numberss, Func<int, bool> predicate)
//{
//    var result = new List<int>();
//    foreach (var number in numberss)
//    {
//        if (predicate(number))
//        {
//            result.Add(number);
//        }
//    }
//    return result;
//}

//List<int> SelectEven(List<int> numberss)
//{
//    var result =new List<int>();
//    foreach (var number in numberss)
//    {
//        if (number % 2 == 0)
//        {
//            result.Add(number);
//        }
//    }  
//    return result;
//}

//List<int> SelectOdd(List<int> numberss)
//{
//    var result = new List<int>();
//    foreach (var number in numberss)
//    {
//        if (number % 2 == 1)
//        {
//            result.Add(number);
//        }
//    }
//    return result;
//}

//List<int> SelectPositive(List<int> numberss)
//{
//    var result = new List<int>();
//    foreach (var number in numberss)
//    {
//        if (number > 0)
//        {
//            result.Add(number);
//        }
//    }
//    return result;
//}

var userInput = Console.ReadLine();


var filteringStartegy = new FilteringStrategySelector().Select(userInput);
var result = new Filter().FilterBy(filteringStartegy, numberss);

Print(result);

var wordsToBeFiltered = new[] { "zebra", "ostrich", "otter" };
var oWords = new Filter().FilterBy(
    word => word.StartsWith("o"),
    wordsToBeFiltered);

Console.WriteLine("Press any key to close.");

Console.ReadKey();

void Print(IEnumerable<int> numbers)
{
    Console.WriteLine(string.Join(", ",numbers));
}

int SumLength(string text1, string text2)
{
    return text1.Length + text2.Length; 
}


string TrimTo5Letters(string input)
{
    return input.Substring(0, 5);
}

string ToUpper(string input)
{
    return input.ToUpper();
}


// Delegate is a type whose instances hold a reference to a method/s with particular parameter list and return type
delegate string ProcessString(string input);

delegate void Print(string input);
