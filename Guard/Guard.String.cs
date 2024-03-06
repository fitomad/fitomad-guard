using Fitomad.Guard.Resources;

namespace Fitomad.Guard;

public sealed partial class Guard 
{
    public static void IsEmpty(string content)
    {
        GuardResourceManager resourceManager = new();
        var isEmptyStringMessage = string.Format(resourceManager.IsEmptyString, content);
        Action isEmptyStringAction = MakeArgumentAction(errorMessage: isEmptyStringMessage);

        Guard.IsEmpty(content, perform: isEmptyStringAction);
    }

    public static void IsEmpty(string content, Action perform)
    {
        if(!string.IsNullOrEmpty(content))
        {
            Execute(perform);
        }
    }

    public static void NotEmpty(string content)
    {
        GuardResourceManager resourceManager = new();
        Action notEmptyStringAction = MakeArgumentAction(errorMessage: resourceManager.NotEmptyString);

        Guard.NotEmpty(content, perform: notEmptyStringAction);
    }

    public static void NotEmpty(string content, Action perform)
    {
        if(string.IsNullOrEmpty(content))
        {
            Execute(perform);
        }
    }

    public static void Length(string content, int stringLength)
    {
        GuardResourceManager resourceManager = new();
        var lengthMessage = string.Format(resourceManager.Length, content, stringLength);
        Action lengthAction = MakeArgumentAction(errorMessage: lengthMessage);

        Guard.Length(content, stringLength: stringLength, perform: lengthAction);
    }

    public static void Length(string content, int stringLength, Action perform)
    {
        if (content.Length != stringLength)
        {
            Execute(perform);
        }
    }

    public static void Contains(string content, string substring)
    {
        GuardResourceManager resourceManager = new();
        var containsMessage = string.Format(resourceManager.ContainsString, content, substring);
        Action containsAction = MakeArgumentAction(errorMessage: containsMessage);

        Guard.Contains(content, substring: substring, perform: containsAction);
    }

    public static void Contains(string content, string substring, Action perform)
    {
        if (!content.Contains(substring))
        {
            Execute(perform);
        }
    }

    public static void NotContains(string content, string substring)
    {
        GuardResourceManager resourceManager = new();
        var notContainsMessage = string.Format(resourceManager.NotContainsString, content, substring);
        Action notContainsAction = MakeArgumentAction(errorMessage: notContainsMessage);

        Guard.NotContains(content, substring: substring, perform: ArgumentAction);
    }

    public static void NotContains(string content, string substring, Action perform)
    {
        if (content.Contains(substring))
        {
            Execute(perform);
        }
    }

    public static void StartsWith(string content, string prefix)
    {
        GuardResourceManager resourceManager = new();
        var startsWithMessage = string.Format(resourceManager.StartsWith, content, prefix);
        Action startsWithAction = MakeArgumentAction(errorMessage: startsWithMessage);

        Guard.StartsWith(content, prefix: prefix, perform: startsWithAction);
    }

    public static void StartsWith(string content, string prefix, Action perform)
    {
        if (!content.StartsWith(prefix))
        {
            Execute(perform);
        }
    }

    public static void NotStartsWith(string content, string prefix)
    {
        GuardResourceManager resourceManager = new();
        var notStartsWithMessage = string.Format(resourceManager.NotStartsWith, content, prefix);
        Action notStartsWithAction = MakeArgumentAction(errorMessage: notStartsWithMessage);

        Guard.NotStartsWith(content, prefix: prefix, perform: notStartsWithAction);
    }

    public static void NotStartsWith(string content, string prefix, Action perform)
    {
        if (content.StartsWith(prefix))
        {
            Execute(perform);
        }
    }

    public static void EndsWith(string content, string suffix)
    {
        GuardResourceManager resourceManager = new();
        var endsWithMessage = string.Format(resourceManager.EndsWith, content, suffix);
        Action endsWithAction = MakeArgumentAction(errorMessage: endsWithMessage);

        Guard.EndsWith(content, suffix: suffix, perform: endsWithAction);
    }

    public static void EndsWith(string content, string suffix, Action perform)
    {
        if (!content.EndsWith(suffix))
        {
            Execute(perform);
        }
    }

    public static void NotEndsWith(string content, string suffix)
    {
        GuardResourceManager resourceManager = new();
        var notEndsMessage = string.Format(resourceManager.NotEndsWith, content, suffix);
        Action notEndsAction = MakeArgumentAction(errorMessage: notEndsMessage);

        Guard.NotEndsWith(content, suffix: suffix, perform: notEndsAction);
    }

    public static void NotEndsWith(string content, string suffix, Action perform)
    {
        if (content.EndsWith(suffix))
        {
            Execute(perform);
        }
    }
}