namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void Contains<Element>(Element element, ICollection<Element> collection, Action perform)
    {
        if(!collection.Contains(element))
        {
            Execute(perform);
        }
    }

    public static void DoesNotContains<Element>(Element element, ICollection<Element> collection, Action perform)
    {
        if(collection.Contains(element))
        {
            Execute(perform);
        }
    }

    public static void IsEmpty<Element>(ICollection<Element> collection, Action perform)
    {
        if(collection.Count != 0)
        {
            Execute(perform);
        }
    }

    public static void NotEmpty<Element>(ICollection<Element> collection, Action perform)
    {
        if(collection.Count == 0)
        {
            Execute(perform);
        }
    }
}