
using HandlingExceptions;
using HandlingExceptions.CustomException;

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

try
{
    int number = ParsingToString(input);
    var result = 10 / number;
    //Console.WriteLine("String successfully parsed, the result is " + number);
    Console.WriteLine($"10 / {number} " + result);
}
catch (FormatException ex)
{
    Console.WriteLine("Wrong format. Input string is not parsable to int. Exception message: " + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Division by zero is an invalid operation. Exception message: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Unexpected error occured. Exception message: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally bloc is being executed.");
}

var invalidPersonObject = new Person("", -1954);
var emptyCollection = new List<int>();
var firstElement = GetFirstElement(emptyCollection);
var firstUsingLinq = emptyCollection.First();
var numbers = new int[] { 1, 2, 3 };
var forth = numbers[3];

var has7 = CheckIfContains(7, numbers);

RecursiveMethod(3);

throw new Exception()

Console.ReadKey();

void RecursiveMethod(int counter)
{
    Console.WriteLine("Calling myself. Counter is: " + counter);
    if (counter < 10)
    {
        RecursiveMethod(counter + 1);
    }
}

int ParsingToString(string input)
{

    //try
    //{
    return int.Parse(input);
    //}
    //catch(Exception ex)
    //{

    //Console.WriteLine($"Parsing error in the {nameof(ParsingToString)} method. " + ex.Message);
    //return 0;
    //}
}

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        return number;
    }

    throw new InvalidOperationException("The collection cannot be empty.");
}


bool CheckIfContains(int value, int[] numbers)
{
    throw new NotImplementedException();
}


bool IsFirstElementPositive(IEnumerable<int> numbers)
{
    try
    {
        var firstElement = GetFirstElement(numbers);
        return firstElement > 0;
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine("The collection is empty!");
        return true;
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Sorry! The application experienced " +
            "an unexpected error.");
        //alternatively, we can just rethrow the original exception:
        //throw;
        throw new ArgumentNullException("The collection is null.", ex);
    }
}

//Exception filters
try
{
    var dataFromWeb = SendHttpRequest("www.someAddress.com/get/someResource");
}
catch (HttpRequestException ex) when (ex.Message == "403")
{
    Console.WriteLine("It was forbidden to access the resource.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "404")
{
    Console.WriteLine("The resource was not found.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message.StartsWith("4"))
{
    Console.WriteLine("Some kind of client error.");
    throw;
}
catch (HttpRequestException ex) when (ex.Message == "500")
{
    Console.WriteLine("The server has experienced an internal error.");
    throw;
}

object SendHttpRequest(string url)
{
    //send the request
    return null;
}










