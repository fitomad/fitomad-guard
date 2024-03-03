using Fitomad.Guard;

namespace Guard.Tests;

public class GuardBoolTests
{
    [Theory]
    [InlineData(true)]
    public void Test_BooleanTrue(bool value)
    {
        Fitomad.Guard.Guard.IsTrue(value);
    }

    [Theory]
    [InlineData(false)]
    public void Test_BooleanTrueThrowing(bool value)
    {
        Assert.Throws<ArgumentException>(testCode: () => 
        {
            Fitomad.Guard.Guard.IsTrue(value);
        });   
    }

    [Theory]
    [InlineData(false)]
    public void Test_BooleanFalse(bool value)
    {
        Fitomad.Guard.Guard.IsFalse(value);
    }

    [Theory]
    [InlineData(true)]
    public void Test_BooleanFalseThrowing(bool value)
    {
        Assert.Throws<ArgumentException>(testCode: () => 
        {
            Fitomad.Guard.Guard.IsFalse(value);
        });   
    }
}