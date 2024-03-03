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

    public static void Lenght(string content, int stringLength)
    {
        Guard.Lenght(content, stringLength: stringLength, perform: ArgumentAction);
    }

    public static void Lenght(string content, int stringLength, Action perform)
    {
        if (content.Length != stringLength)
        {
            Execute(perform);
        }
    }
}