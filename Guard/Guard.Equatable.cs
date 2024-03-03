namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void IsNull(object element)
    {
        Guard.IsNull(element, perform: ArgumentAction);
    }

    public static void IsNull(object element, Action perform)
    {
        if (element is not null)
        {
            Execute(perform);
        }
    }

    public static void IsNotNull(object element) {
        Guard.IsNotNull(element, perform: ArgumentAction);
    }

    public static void IsNotNull(object element, Action perform) {
        if (element is null) 
        {
            Execute(perform);
        }
    }

    public static void Equals<Element>(Element lhs, Element rhs) where Element : IEquatable<Element>
    {
        Guard.Equals(lhs, rhs, perform: ArgumentAction);
    }

    public static void Equals<Element>(Element lhs, Element rhs, Action perform) where Element : IEquatable<Element>
    {
        if(!lhs.Equals(rhs))
        {
            Execute(perform);
        }
    }

    public static void NonEquals<Element>(Element lhs, Element rhs) where Element : IEquatable<Element>
    {
        Guard.NonEquals(lhs, rhs, perform: ArgumentAction);
    }

    public static void NonEquals<Element>(Element lhs, Element rhs, Action perform) where Element : IEquatable<Element>
    {
        if(lhs.Equals(rhs))
        {
            Execute(perform);
        }
    }

}