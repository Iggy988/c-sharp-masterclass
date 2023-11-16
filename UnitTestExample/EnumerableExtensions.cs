
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitTestExample;
public static class EnumerableExtensions
{
    public static int SumOfEvenNumbers(this IEnumerable<int> numbers)
    {
        return numbers.Where(number =>number % 2 == 0).Sum();
        //int sum = 0;
        //foreach (int number in numbers)
        //{
        //    if(number % 2 == 0)
        //    {
        //        sum+=number;
        //    }
        //}
        //return sum;
    }

    public static bool IsEven(int number) => true;
}
