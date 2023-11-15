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

    //[TestCase(new int[] { 3,1,4,6,9}, 10)]
    //[TestCase(new List<int> { 100, 200, 1}, 300]
    [TestCaseSource(nameof(GetSumOfEvenNumbersTestCases))]
    public void SumOfEvenNumbers_ShallReturnNonZeroResult_IfEvenNumbersArePresent(IEnumerable<int> input, int expected)
    {
        //Arrange
        //var input = new int[] { 3,1,4,6,9 };

        //Act
        var result = input.SumOfEvenNumbers();

        //Assert
        //var expected = 10;
        var inputAsString = string.Join(", ", input);

        Assert.AreEqual(expected, result, $"For input {inputAsString} the result shall be" +
            $" {expected} but it was {result}.");
    }

    private static IEnumerable<object> GetSumOfEvenNumbersTestCases()
    {
        return new[]
        {
            new object[]{ new int[] { 3,4,6,9}, 10 },
            new object[]{ new List<int> { 100, 200, 1}, 300 },
            new object[]{ new List<int> { -3, -5, 0}, 0 },
            new object[]{ new List<int> { -4, -8}, -12},
        };
    }

    [TestCase(1,2,3)]
    [TestCase(1,-1,0)]
    [TestCase(0,0,0)]
    [TestCase(100,-50,50)]
    [TestCase(11,12,23)]
    public void Sum_ShallAddNumbersCorrectly(int a, int b, int expected)
    {
        Assert.AreEqual(expected, Calculator.Sum(a, b), $"Adding {a} to {b} shall give {expected}," +
            $"but the result was {Calculator.Sum(a, b)}.");
    }

    [TestCase(8)]
    [TestCase(-8)]
    [TestCase(6)]
    [TestCase(0)]
    public void SumOfEvenNumbers_ShallReturnValueOfTheOnlyItem_IfItIsEven(int number)
    {
        //Arrange
        var input = new int[] { number };

        //Act
        var result = input.SumOfEvenNumbers();

        //Assert

        Assert.AreEqual(number, result);
    }

    //[TestCase(1)]
    //[TestCase(-3)]
    //[TestCase(7)]
    //[TestCase(33)]
    //[Test]
    //public void SumOfEvenNumbers_ShallReturnZero_IfOnlynNumberInInputIsOdd(int number)
    //{
    //    var input1 = new int[] { 1 };

    //    var result1 = input1.SumOfEvenNumbers();

    //    Assert.AreEqual(0, result1);

    //    var input2 = new int[] { -7 };

    //    var result2 = input2.SumOfEvenNumbers();

    //    Assert.AreEqual(0, result2);
    //}

    [Test]
    public void SumOfEvenNumbers_ShallThrowException_ForNullInput()
    {
        IEnumerable<int>? input = null;

        //Assert.DoesNotThrow(() => input!.SumOfEvenNumbers());

        var exception = Assert.Throws<ArgumentNullException>(() => input!.SumOfEvenNumbers());

    }

    [Test]
    public void SomeTest()
    {
        //bool someVariable = true;
        //Assert.IsTrue(someVariable);
        //Assert.True(someVariable);
        //Assert.False(someVariable);

        //Assert.AreEqual(true, someVariable);

        //Assert.Null(someVariable);
        //Assert.NotNull(someVariable);

        var collection1 = new List<int> { 1,2,3};
        var collection2 = new List<int> { 3,2,1};

        Assert.AreEqual(collection1, collection2);
        CollectionAssert.AreEqual(collection1, collection2); //fail because is not same order
        CollectionAssert.AreEquivalent(collection1, collection2); // succeed becouse order is not important

    }
}
