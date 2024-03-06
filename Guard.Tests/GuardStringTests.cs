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

    [Theory]
    [InlineData("fitomad", "itoma")]
    [InlineData("Spain", "Spain")]
    [InlineData("Madrid", "d")]
    [InlineData("Madrid", "M")]
    [InlineData("Spain", "pai")]
    public void Test_StringContains(string content, string substring)
    {
        Fitomad.Guard.Guard.Contains(content, substring: substring);
    }

    [Theory]
    [InlineData("Microsoft", "Apple")]
    [InlineData("Spain", "USA")]
    [InlineData("Madrid", "Seattle")]
    [InlineData("Madrid", "New York")]
    [InlineData("Spain", "count")]
    public void Test_StringContainsThrowing(string content, string substring)
    {
        Assert.Throws<ArgumentException>(testCode: () => 
        {
            Fitomad.Guard.Guard.Contains(content, substring: substring);
        }); 
    }

    [Theory]
    [InlineData("fitomad", "fito")]
    [InlineData("Spain", "Spa")]
    [InlineData("Madrid", "M")]
    [InlineData("Madrid", "Madri")]
    [InlineData("Spain", "Spain")]
    public void Test_StartsWith(string content, string testString)
    {
        Fitomad.Guard.Guard.StartsWith(content, prefix: testString);
    }

    [Theory]
    [InlineData("Microsoft", "micro")]
    [InlineData("Spain", "U")]
    [InlineData("Madrid", "Seattl")]
    [InlineData("Madrid", "New ")]
    [InlineData("Spain", " ")]
    public void Test_StartsWithThrowing(string content, string substring)
    {
        Assert.Throws<ArgumentException>(testCode: () => 
        {
            Fitomad.Guard.Guard.Contains(content, substring: substring);
        }); 
    }

    [Theory]
    [InlineData("fitomad", "mad")]
    [InlineData("Spain", "in")]
    [InlineData("Madrid", "d")]
    [InlineData("Madrid", "adrid")]
    [InlineData("USA", "SA")]
    public void Test_EndsWith(string content, string testString)
    {
        Fitomad.Guard.Guard.EndsWith(content, suffix: testString);
    }

    [Theory]
    [InlineData("Microsoft", "pple")]
    [InlineData("Spain", "SA")]
    [InlineData("Madrid", "eattle")]
    [InlineData("Madrid", " York")]
    [InlineData("Spain", "spain")]
    public void Test_EndsWithThrowing(string content, string testString)
    {
        Assert.Throws<ArgumentException>(testCode: () => 
        {
            Fitomad.Guard.Guard.EndsWith(content, suffix: testString);
        }); 
    }
}