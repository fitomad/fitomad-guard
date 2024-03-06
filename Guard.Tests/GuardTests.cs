using Fitomad.Guard;

namespace Guard.Tests;

public class GuardTests
{
    [Theory]
    [InlineData(null)]
    public void Test_Null(object parameter)
    {
        Fitomad.Guard.Guard.IsNull(parameter);
    }

    [Theory]
    [InlineData("Is not null")]
    public void Test_NullThrowing(object parameter)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.IsNull(parameter);
        });
    }

    [Theory]
    [InlineData("Is Not Null")]
    public void Test_NotNull(object parameter)
    {
        Fitomad.Guard.Guard.NotNull(parameter);
    }

    [Theory]
    [InlineData(null)]
    public void Test_NotNullThrowing(object parameter)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.NotNull(parameter);
        });
    }

    [Theory]
    [InlineData(-123, -1239)]
    [InlineData(-11, -119)]
    [InlineData(0, 9)]
    [InlineData(1, 19)]
    [InlineData(100, 1009)]
    public void Test_NonEqualIntegers(int lhs, int rhs)
    {
        Fitomad.Guard.Guard.NotEquals(lhs, rhs);
    }


    [Theory]
    [InlineData(-123, -123)]
    [InlineData(-11, -11)]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(100, 100)]
    public void Test_NonEqualIntegersThrowing(int lhs, int rhs)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.NotEquals(lhs, rhs);
        });
    }

    [Theory]
    [InlineData("abc", "abc")]
    [InlineData("098", "098")]
    [InlineData("NameWith", "NameWith")]
    [InlineData("Symbols@Included", "Symbols@Included")]
    [InlineData("", "")]
    public void Test_EqualString(string lhs, string rhs)
    {
        Fitomad.Guard.Guard.IsEquals(lhs, rhs);
    }

    [Theory]
    [InlineData("abc", "ab")]
    [InlineData("098", "09")]
    [InlineData("NameWith", "NameWit")]
    [InlineData("Symbols@Included", "Symbols@Include")]
    [InlineData("", "1")]
    public void Test_EqualStringThrowing(string lhs, string rhs)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.IsEquals(lhs, rhs);
        });
    }

    [Theory]
    [InlineData("abc", "abc")]
    public void Test_NonEqualNonThrowingAction(string lhs, string rhs)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.NotEquals(lhs, rhs, perform: () => {
                // We do some work here...
            });
        });
    }

    [Theory]
    [InlineData("abc", "abc")]
    public void Test_NonEqualThrowingActionCustomException(string lhs, string rhs)
    {
        Assert.Throws<GuardTestException>(testCode: () => {
            Fitomad.Guard.Guard.NotEquals(lhs, rhs, perform: () => {
                // We do some work here...
                throw new GuardTestException();
            });
        });
    }
}