namespace Fitomad.Guard;

public sealed partial class Guard
{
    public static void IsTrue(bool element) {
        Guard.IsTrue(element, perform: ArgumentAction);
    }

    public static void IsTrue(bool element, Action perform) {
        if (element == false)
        {
            Execute(perform);
        }
    }

    public static void IsFalse(bool element) {
        Guard.IsFalse(element, perform: () =>
        {
            throw new ArgumentException();
        });
    }

    public static void IsFalse(bool element, Action perform) {
        if (element == true)
        {
            Execute(perform);
        }
    }
}