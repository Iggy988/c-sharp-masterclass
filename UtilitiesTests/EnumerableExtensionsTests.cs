using NUnit.Framework;
using UnitTestExample;

namespace UtilitiesTests;

// [TestFixture] mozemo dodati, ali ako imamo bar jedan metod sa [Test] svakako ce biti oznacena kao test fixture class
[TestFixture] 
public class EnumerableExtensionsTests
{
    [Test]
    public void Test1()
    {
        var input = Enumerable.Empty<int>();

        var result = input.SumOfEvenNumbers();

        Assert.AreEqual(0, result);
    }
}
