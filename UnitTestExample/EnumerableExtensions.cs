
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("UtilitiesTests")]
namespace UnitTestExample;
internal static class EnumerableExtensions
{
    public static int SumOfEvenNumbers(this IEnumerable<int> numbers)
    {
        return numbers.Where(IsEven).Sum();
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

    private static bool IsEven(int number) => number % 2 == 0;
}
