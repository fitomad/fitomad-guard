using System.Text.RegularExpressions;

namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void Match(string content, string regularExpression)
    {
        Match(content, regularExpression: regularExpression, perform: ArgumentAction);
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
        NotMatch(content, regularExpression: regularExpression, perform: ArgumentAction);
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