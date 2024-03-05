using Fitomad.Guard.Resources;

namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void IsTrue(bool element) {
        GuardResourceManager resourceManager = new();
        Action isTrueAction = Guard.MakeArgumentAction(resourceManager.IsTrueMessage);

        Guard.IsTrue(element, perform: isTrueAction);
    }

    public static void IsTrue(bool element, Action perform) {
        if (element == false)
        {
            Execute(perform);
        }
    }

    public static void IsFalse(bool element) {
        GuardResourceManager resourceManager = new();
        Action isFalseAction = Guard.MakeArgumentAction(resourceManager.IsFalseMessage);

        Guard.IsFalse(element, perform: isFalseAction);
    }

    public static void IsFalse(bool element, Action perform) {
        if (element == true)
        {
            Execute(perform);
        }
    }
}