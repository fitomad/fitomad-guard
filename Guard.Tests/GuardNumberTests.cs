using Fitomad.Guard;

namespace Guard.Tests;

public class GuardNumberTests
{
    [Theory]
    [InlineData(5, 0, 10)]
    [InlineData(0, -5, 5)]
    [InlineData(1_001, 1_000, 1_002)]
    [InlineData(-1_001, -1_002, -1_000)]
    public void Test_InRangeInteger(int value, int lowerBound, int upperBound)
    {
        Fitomad.Guard.Guard.InRange(value: value, lowerBound: lowerBound, upperBound: upperBound);
    }

    [Theory]
    [InlineData(5.0, 0.0, 10.0)]
    [InlineData(0.0, -5.0, 5.0)]
    [InlineData(1_001.0, 1_000.0, 1_002.0)]
    [InlineData(-1_001.0, -1_002.0, -1_000.0)]
    [InlineData(0.1, 0.0, 0.2)]
    [InlineData(-0.1, -0.2, 0.0)]
    public void Test_InRangeDouble(double value, double lowerBound, double upperBound)
    {
        Fitomad.Guard.Guard.InRange(value: value, lowerBound: lowerBound, upperBound: upperBound);
    }

    [Theory]
    [InlineData(5, 0.0, 10.0)]
    [InlineData(0, -5.0, 5.0)]
    [InlineData(1_001, 1_000.0, 1_002.0)]
    [InlineData(-1_001, -1_002.0, -1_000.0)]
    [InlineData(0, 0.0, 0.2)]
    [InlineData(-1, -2.0, 0.0)]
    public void Test_InRangeIntegerDouble(int value, double lowerBound, double upperBound)
    {
        Fitomad.Guard.Guard.InRange(value: value, lowerBound: lowerBound, upperBound: upperBound);
    }



    [Theory]
    [InlineData(50, 0, 10)]
    [InlineData(10, -5, 5)]
    [InlineData(1_004, 1_000, 1_002)]
    [InlineData(-1_100, -1_002, -1_000)]
    public void Test_InRangeIntegerThrowing(int value, int lowerBound, int upperBound)
    {
        Assert.Throws<IndexOutOfRangeException>(testCode: () => 
        {
            Fitomad.Guard.Guard.InRange(value: value, lowerBound: lowerBound, upperBound: upperBound);
        });
    }

    [Theory]
    [InlineData(50.0, 0.0, 10.0)]
    [InlineData(10.0, -5.0, 5.0)]
    [InlineData(1_003.0, 1_000.0, 1_002.0)]
    [InlineData(-1_003.0, -1_002.0, -1_000.0)]
    [InlineData(0.3, 0.0, 0.2)]
    [InlineData(0.1, -0.2, 0.0)]
    public void Test_InRangeDoubleThrowing(double value, double lowerBound, double upperBound)
    {
        Assert.Throws<IndexOutOfRangeException>(testCode: () => 
        {
            Fitomad.Guard.Guard.InRange(value: value, lowerBound: lowerBound, upperBound: upperBound);
        });
    }

    [Theory]
    [InlineData(50, 0.0, 10.0)]
    [InlineData(10, -5.0, 5.0)]
    [InlineData(1_005, 1_000.0, 1_002.0)]
    [InlineData(-1_003, -1_002.0, -1_000.0)]
    [InlineData(1, 0.0, 0.2)]
    [InlineData(-3, -2.0, 0.0)]
    public void Test_InRangeIntegerDoubleThrowing(int value, double lowerBound, double upperBound)
    {
        Assert.Throws<IndexOutOfRangeException>(testCode: () => 
        {
            Fitomad.Guard.Guard.InRange(value: value, lowerBound: lowerBound, upperBound: upperBound);
        });
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, -1)]
    public void Test_GreaterInteger(int value, int otherNumber)
    {
        Fitomad.Guard.Guard.NumberIsGreater(number: value, upperBound: otherNumber);
    }

    [Theory]
    [InlineData(1.0, 0.9)]
    [InlineData(0.0, -0.1)]
    public void Test_GreaterDouble(double value, double otherNumber)
    {
        Fitomad.Guard.Guard.NumberIsGreater(number: value, upperBound: otherNumber);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(-1, 0)]
    public void Test_GreaterIntegerThrowing(int value, int otherNumber)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.NumberIsGreater(number: value, upperBound: otherNumber);
        });
    }

    [Theory]
    [InlineData(0.9, 1.0)]
    [InlineData(-0.1, 0.0)]
    public void Test_GreaterDoubleThrowing(double value, double otherNumber)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.NumberIsGreater(number: value, upperBound: otherNumber);
        });
    }


    [Theory]
    [InlineData(0, 1)]
    [InlineData(-1, 0)]
    public void Test_LowerInteger(int value, int otherNumber)
    {
        Fitomad.Guard.Guard.NumberIsLower(number: value, lowerBound: otherNumber);
    }

    [Theory]
    [InlineData(0.9, 1.0)]
    [InlineData(-0.1, 0.0)]
    public void Test_LowerDouble(double value, double otherNumber)
    {
        Fitomad.Guard.Guard.NumberIsLower(number: value, lowerBound: otherNumber);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(0, -1)]
    public void Test_LowerIntegerThrowing(int value, int otherNumber)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.NumberIsLower(number: value, lowerBound: otherNumber);
        });
    }

    [Theory]
    [InlineData(1.0, 0.9)]
    [InlineData(0.0, -0.1)]
    public void Test_LowerDoubleThrowing(double value, double otherNumber)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.NumberIsLower(number: value, lowerBound: otherNumber);
        });
    }
}