
var twoBillion = 2_000_000_000;
var result = twoBillion + twoBillion;

Console.WriteLine(result);

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



Console.ReadKey();
