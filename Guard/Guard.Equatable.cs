using Fitomad.Guard.Resources;

namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void IsNull(object element)
    {
        GuardResourceManager resourceManager = new();
        Action isNullAction = MakeArgumentAction(errorMessage: resourceManager.IsNull);

        Guard.IsNull(element, perform: isNullAction);
    }

    public static void IsNull(object element, Action perform)
    {
        if (element is not null)
        {
            Execute(perform);
        }
    }

    public static void NotNull(object element) 
    {
        GuardResourceManager resourceManager = new();
        Action notNullAction = MakeArgumentAction(errorMessage: resourceManager.NotNull);

        Guard.NotNull(element, perform: notNullAction);
    }

    public static void NotNull(object element, Action perform) {
        if (element is null) 
        {
            Execute(perform);
        }
    }

    public static void IsEquals<Element>(Element lhs, Element rhs) where Element : IEquatable<Element>
    {
        GuardResourceManager resourceManager = new();
        var isEqualsMessage = string.Format(resourceManager.IsEquals, lhs, rhs);
        Action isEqualsAction = MakeArgumentAction(errorMessage: isEqualsMessage);
        
        Guard.IsEquals(lhs, rhs, perform: isEqualsAction);
    }

    public static void IsEquals<Element>(Element lhs, Element rhs, Action perform) where Element : IEquatable<Element>
    {
        if(!lhs.Equals(rhs))
        {
            Execute(perform);
        }
    }

    public static void NotEquals<Element>(Element lhs, Element rhs) where Element : IEquatable<Element>
    {
        GuardResourceManager resourceManager = new();
        var notEqualsMessage = string.Format(resourceManager.NotEquals, lhs, rhs);
        Action notEqualsAction = MakeArgumentAction(errorMessage: notEqualsMessage);
        
        Guard.NotEquals(lhs, rhs, perform: notEqualsAction);
    }

    public static void NotEquals<Element>(Element lhs, Element rhs, Action perform) where Element : IEquatable<Element>
    {
        if(lhs.Equals(rhs))
        {
            Execute(perform);
        }
    }

}