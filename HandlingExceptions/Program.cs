


using HandlingExceptions;


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

var invalidPersonObject = new Person("", -1954);
var emptyCollection = new List<int>();
var firstElement = GetFirstElement(emptyCollection);
var firstUsingLinq = emptyCollection.First();
var numbers = new int[] { 1, 2, 3 };
var forth = numbers[3];

var has7 = CheckIfContains(7, numbers);

RecursiveMethod(3);

//throw new CustomException();

try
{
    Run();
}
catch (Exception ex)
{
    Console.WriteLine(
        "Sorry. The application has experienced " +
        "an error. The error message: " + ex.Message);

    //logger.Log(ex);
}

GotoShowcase();
Console.WriteLine("Press any key to close.");
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



object SendHttpRequest(string url)
{
    //send the request
    return null;
}
void Run()
{
    try
    {
        Console.WriteLine("Enter a word");
        var word = Console.ReadLine();
        Console.WriteLine("Count of characters is " + word.Length);
    }
    catch (NullReferenceException ex)
    {
        var logger = new Logger();
        Console.WriteLine(
            "The input is null, and its length cannot be calculated. " +
            "Did you press CTRL+Z in the console?");
        logger.Log(ex);
        throw;
    }
}

void GotoShowcase()
{
    //goto
    int someNumber = 0;
    if (someNumber < 0)
    {
        goto NegativeNumber;
    }

    Console.WriteLine("The number is positive or zero.");
    return;

NegativeNumber:
    Console.WriteLine("The number is negative.");
}


public class Logger
{
    public void Log(Exception ex)
    {
        Console.WriteLine("Writing the exception to a file with a message: " + ex.Message);
    }
}










