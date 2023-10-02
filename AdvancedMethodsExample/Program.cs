

var numbers = new[] { 1, 7, 2, 19, 3 };
Func<int, bool> predicate1 = IsLargerThan10;
Console.WriteLine("IsAnyLargerThan10? " + IsAny(numbers, predicate1));
Console.WriteLine("IsAnyLargerThan10? " + IsAny(numbers, IsLargerThan10));

Func<int, bool> predicate2 = IsEven;


Console.WriteLine("IsAnyLargerThan10? " + IsAny(numbers, predicate2));
Console.WriteLine("IsAnyLargerThan10? " + IsAny(numbers, IsEven));


bool IsLargerThan10(int number)
{
    return number > 10;
}



Console.WriteLine("IsAnyLargerThan10? " + IsAnyLargerThan10(numbers));
Console.WriteLine("IsAnyEven? " + IsAnyEven(numbers));

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

Console.ReadKey();