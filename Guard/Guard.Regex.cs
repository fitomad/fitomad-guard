using System.Text.RegularExpressions;
using Fitomad.Guard.Resources;

namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void Match(string content, string regularExpression)
    {
        GuardResourceManager resourceManager = new();
        var matchMessage = string.Format(resourceManager.Match, content, regularExpression);
        Action matchAction = MakeArgumentAction(errorMessage: matchMessage);

        Match(content, regularExpression: regularExpression, perform: matchAction);
    }

    public static void Match(string content, string regularExpression, Action perform)
    {
        bool isMatch = Regex.IsMatch(content, regularExpression, RegexOptions.IgnoreCase);

        if (!isMatch)
        {
            Execute(perform);
        }
    }

    public static void NotMatch(string content, string regularExpression)
    {
        GuardResourceManager resourceManager = new();
        var notMatchMessage = string.Format(resourceManager.NotMatch, content, regularExpression);
        Action notMatchAction = MakeArgumentAction(errorMessage: notMatchMessage);

        NotMatch(content, regularExpression: regularExpression, perform: notMatchAction);
    }

    public static void NotMatch(string content, string regularExpression, Action perform)
    {
        bool isMatch = Regex.IsMatch(content, regularExpression, RegexOptions.IgnoreCase);

        if (isMatch)
        {
            throw new ArgumentException();
        }
    }
}