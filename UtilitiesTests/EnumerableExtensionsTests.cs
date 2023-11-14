﻿using NUnit.Framework;
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

    [TestCase(1)]
    [TestCase(-3)]
    [TestCase(7)]
    [TestCase(33)]
    public void SumOfEvenNumbers_ShallReturnZero_IfOnlynNumberInInputIsOdd(int number)
    {
        //Arrange
        var input = new int[] { number };

        //Act
        var result = input.SumOfEvenNumbers();

        //Assert

        Assert.AreEqual(0, result);
    }
}