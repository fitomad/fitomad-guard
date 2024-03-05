namespace Fitomad.Guard;

using ComparableBound = (int lowerBound, int upperBound);

public sealed partial class Guard
{
    public static void InRange<Element>(Element value, Element lowerBound, Element upperBound) where Element : IComparable
    {
        Guard.InRange(value, lowerBound: lowerBound, upperBound: upperBound, perform: RangeAction);
    }

    public static void InRange<Element>(Element value, Element lowerBound, Element upperBound, Action perform) where Element : IComparable
    {
        bool rangeStartCheck = value.CompareTo(lowerBound) >= 0;
        bool rangeEndCheck = value.CompareTo(upperBound) <= 0;

        if(!(rangeStartCheck && rangeEndCheck))
        {
            Execute(perform);
        }
    }

    public static void IsLower<Element>(Element value, Element lowerBound)  where Element : IComparable
    {
        Guard.IsLower(value, lowerBound: lowerBound, perform: ArgumentAction);   
    }

    public static void IsLower<Element>(Element value, Element lowerBound, Action perform)  where Element : IComparable
    {
        bool rangeStartCheck = value.CompareTo(lowerBound) >= 0;

        if (rangeStartCheck)
        {
            Execute(perform);
        }
    }

    public static void IsLowerOrEquals<Element>(Element value, Element lowerBound)  where Element : IComparable
    {
        Guard.IsLowerOrEquals(value, lowerBound: lowerBound, perform: ArgumentAction);   
    }

    public static void IsLowerOrEquals<Element>(Element value, Element lowerBound, Action perform)  where Element : IComparable
    {
        bool rangeStartCheck = value.CompareTo(lowerBound) >= 0;

        if (rangeStartCheck)
        {
            Execute(perform);
        }
    }

    public static void IsGreater<Element>(Element value, Element upperBound)  where Element : IComparable
    {
        Guard.IsGreater(value, upperBound: upperBound, perform: ArgumentAction);
    }

    public static void IsGreater<Element>(Element value, Element upperBound, Action perform)  where Element : IComparable
    {
        bool rangeEndCheck = value.CompareTo(upperBound) <= 0;

        if (rangeEndCheck)
        {
            Execute(perform);
        }
    }

    public static void IsGreaterOrEquals<Element>(Element value, Element upperBound)  where Element : IComparable
    {
        Guard.IsGreaterOrEquals(value, upperBound: upperBound, perform: ArgumentAction);
    }

    public static void IsGreaterOrEquals<Element>(Element value, Element upperBound, Action perform)  where Element : IComparable
    {
        bool rangeEndCheck = value.CompareTo(upperBound) < 0;

        if (rangeEndCheck)
        {
            Execute(perform);
        }
    }
}