//readonly collection
//params
public static class Calculator
{
    public static int Add(params int[] numbers) => numbers.Sum();
    //public static int Add(IEnumerable<int> numbers) => numbers.Sum();
    //public static int Add(int a, int b) => a + b;
    //public static int Add(int a, int b, int c) => a + b + c;
    //public static int Add(int a, int b, int c, int d) => a + b + c + d;
}