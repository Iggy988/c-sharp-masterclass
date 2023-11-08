
var twoBillion = 2_000_000_000;
//var result = twoBillion + twoBillion;

//Console.WriteLine(result);

int sumSoFar = 1_900_000_000;
int nextTransaction = 1_000_000_000;
long sumAfterTransaction = (long)sumSoFar + (long)nextTransaction;

if (sumAfterTransaction > twoBillion) //numeric overflow -> it will go negative
{
    Console.WriteLine("Transaction blocked.");
}
else
{
    Console.WriteLine("Transaction executed.");
}

//checked
//{
//    //will be checked
//    unchecked
//    {
//        //will not be checked
//    }
//}

SomeMethodWithCheckedContext(twoBillion, twoBillion);

Console.WriteLine(0.3d == (0.2d + 0.1d));
Console.WriteLine(0.3m == (0.2m + 0.1m));
Console.WriteLine(AreEquals(0.3d,0.2d+ 0.1d, 0.000001d));

var result = 10d / 0d;

Console.ReadKey();

bool AreEquals(double a, double b, double tolerance)
{
    return Math.Abs(a - b)> tolerance;
}

void SomeMethodWithCheckedContext(int a, int b)
{
        var result = Add(a,b); 
}

int Add(int a, int b)
{
    checked
    {
        return a + b;
    }
}