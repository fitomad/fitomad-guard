using Fitomad.Guard;

namespace Guard.Tests;

public class GuardMatchTests
{
    [Theory]
    [InlineData("999", @"\d{3}")]
    [InlineData("Fitomad", @"[A-Z]*")]
    public void Test_Match(string content, string regex)
    {
        Fitomad.Guard.Guard.Match(content, regularExpression: regex);
    }

    [Theory]
    [InlineData("999", @"\d{4}")]
    [InlineData("Fitomad", @"\d{1,}")]
    public void Test_MatchThrowing(string content, string regex)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.Match(content, regularExpression: regex);
        });
        
    }

    [Theory]
    [InlineData("999", @"\d{4}")]
    [InlineData("Fitomad", @"\d{1,}")]
    public void Test_MatchThrowingCustomException(string content, string regex)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.Match(content, regularExpression: regex, perform: () => 
            {
                Console.WriteLine($"{content} is not in the expected format");
            });
        });
        
    }

    [Theory]
    [InlineData("999", @"\d{6}")]
    [InlineData("Fitomad", @"\d{1,}")]
    public void Test_NotMatch(string content, string regex)
    {
        Fitomad.Guard.Guard.NotMatch(content, regularExpression: regex);
    }

    [Theory]
    [InlineData("999", @"\d{3}")]
    [InlineData("Fitomad", @"[A-Z]*")]
    public void Test_NotMatchThrowing(string content, string regex)
    {
        Assert.Throws<ArgumentException>(testCode: () => {
            Fitomad.Guard.Guard.NotMatch(content, regularExpression: regex);
        });
        
    }
}
