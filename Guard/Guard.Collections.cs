using Fitomad.Guard.Resources;

namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void Contains<Element>(Element element, ICollection<Element> collection)
    {
        Guard.Contains(element, collection: collection, perform: ArgumentAction);
    }

    public static void Contains<Element>(Element element, ICollection<Element> collection, Action perform)
    {
        if(!collection.Contains(element))
        {
            Execute(perform);
        }
    }

    public static void NotContains<Element>(Element element, ICollection<Element> collection)
    {
        Guard.NotContains(element, collection: collection, perform: ArgumentAction);
    }

    public static void NotContains<Element>(Element element, ICollection<Element> collection, Action perform)
    {
        if(collection.Contains(element))
        {
            Execute(perform);
        }
    }

    public static void IsEmpty<Element>(ICollection<Element> collection)
    {
        Guard.IsEmpty(collection, perform: ArgumentAction);
    }

    public static void IsEmpty<Element>(ICollection<Element> collection, Action perform)
    {
        if(collection.Count != 0)
        {
            Execute(perform);
        }
    }

    public static void NotEmpty<Element>(ICollection<Element> collection)
    {
        Guard.NotEmpty(collection, perform: ArgumentAction);
    }

    public static void NotEmpty<Element>(ICollection<Element> collection, Action perform)
    {
        if(collection.Count == 0)
        {
            Execute(perform);
        }
    }
}