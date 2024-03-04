using Fitomad.Guard;

namespace Guard.Tests;

public class GuardStringTests
{
    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void Test_EmptyString(string content)
    {
        Fitomad.Guard.Guard.IsEmpty(content);
    }

    [Theory]
    [InlineData(" ")]
    [InlineData("A")]
    [InlineData(" A")]
    [InlineData("A ")]
    [InlineData(" A ")]
    [InlineData("Word")]
    [InlineData("A Word")]
    public void Test_EmptyStringThrowing(string content)
    {
        Assert.Throws<ArgumentException>(testCode: () => 
        {
            Fitomad.Guard.Guard.IsEmpty(content);
        });
    }

    [Theory]
    [InlineData(" ")]
    [InlineData("A")]
    [InlineData(" A")]
    [InlineData("A ")]
    [InlineData(" A ")]
    [InlineData("Word")]
    [InlineData("A Word")]
    public void Test_NonEmptyString(string content)
    {
        Fitomad.Guard.Guard.NotEmpty(content);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void Test_NonEmptyStringThrowing(string content)
    {
        Assert.Throws<ArgumentException>(testCode: () => 
        {
            Fitomad.Guard.Guard.NotEmpty(content);
        });
    }

    [Theory]
    [InlineData(" ", 1)]
    [InlineData("A", 1)]
    [InlineData(" A", 2)]
    [InlineData("A ", 2)]
    [InlineData(" A ", 3)]
    [InlineData("Word", 4)]
    [InlineData("A Word", 6)]
    public void Test_StringLength(string content, int expectedLength)
    {
        Fitomad.Guard.Guard.Length(content, stringLength: expectedLength);
    }

    [Theory]
    [InlineData(" ", 1)]
    [InlineData("A", 1)]
    [InlineData(" A", 2)]
    [InlineData("A ", 2)]
    [InlineData(" A ", 3)]
    [InlineData("Word", 4)]
    [InlineData("A Word", 6)]
    public void Test_StringLengthThrowing(string content, int expectedLength)
    {
        Assert.Throws<ArgumentException>(testCode: () => 
        {
            Fitomad.Guard.Guard.Length(content, stringLength: (expectedLength + 1));
        });
        
    }

}