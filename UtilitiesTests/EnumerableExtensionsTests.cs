using NUnit.Framework;
using UnitTestExample;

namespace UtilitiesTests;

// [TestFixture] mozemo dodati, ali ako imamo bar jedan metod sa [Test] svakako ce biti oznacena kao test fixture class
[TestFixture] 
public class EnumerableExtensionsTests
{
    [Test]
    public void SumOfEvenNumbers_ShallReturnZero_ForEmptyCollection()
    {
        var input = Enumerable.Empty<int>();

        var result = input.SumOfEvenNumbers();

        Assert.AreEqual(0, result);
    }

    [Test]
    public void SumOfEvenNumbers_ShallReturnNonZeroResult_IfEvenNumbersArePresent()
    {
        //Arrange
        var input = new int[] { 3,1,4,6,9 };

        //Act
        var result = input.SumOfEvenNumbers();

        //Assert
        var expected = 10;
        var inputAsString = string.Join(", ", input);

        Assert.AreEqual(10, result, $"For input {inputAsString} the result shall be" +
            $" {expected} but it was {result}.");
    }

    [Test]
    public void Sum_ShallGive3_WhenAdding_2_And_1()
    {
        Assert.AreEqual(3, Calculator.Sum(1, 2));
    }
}
