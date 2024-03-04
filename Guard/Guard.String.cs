namespace Fitomad.Guard;

public sealed partial class Guard 
{
    public static void IsEmpty(string content)
    {
        Guard.IsEmpty(content, perform: ArgumentAction);
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
        Guard.NotEmpty(content, perform: ArgumentAction);
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
        Guard.Length(content, stringLength: stringLength, perform: ArgumentAction);
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
        Guard.Contains(content, substring: substring, perform: ArgumentAction);
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
        Guard.NotContains(content, substring: substring, perform: ArgumentAction);
    }

    public static void NotContains(string content, string substring, Action perform)
    {
        if (content.Contains(substring))
        {
            Execute(perform);
        }
    }

    public static void StarsWith(string content, string prefix)
    {
        Guard.StartsWith(content, prefix: prefix, perform: ArgumentAction);
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
        Guard.NotStartsWith(content, prefix: prefix, perform: ArgumentAction);
    }

    public static void NotStartsWith(string content, string prefix, Action perform)
    {
        if (content.StartsWith(prefix))
        {
            Execute(perform);
        }
    }

    public static void EndsWith(string content, string prefix)
    {
        Guard.EndsWith(content, prefix: prefix, perform: ArgumentAction);
    }

    public static void EndsWith(string content, string prefix, Action perform)
    {
        if (!content.EndsWith(prefix))
        {
            Execute(perform);
        }
    }

    public static void NotEndsWith(string content, string prefix)
    {
        Guard.NotEndsWith(content, prefix: prefix, perform: ArgumentAction);
    }

    public static void NotEndsWith(string content, string prefix, Action perform)
    {
        if (content.EndsWith(prefix))
        {
            Execute(perform);
        }
    }
}