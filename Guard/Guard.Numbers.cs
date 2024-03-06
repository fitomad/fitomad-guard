using Fitomad.Guard.Resources;

namespace Fitomad.Guard;

using ComparableBound = (int lowerBound, int upperBound);

public sealed partial class Guard
{
    public static void InRange<Element>(Element value, Element lowerBound, Element upperBound) where Element : IComparable
    {
        GuardResourceManager resourceManager = new();
        var inRangeMessage = string.Format(resourceManager.InRangeMessage, value, lowerBound, upperBound);
        Action inRangeAction = MakeArgumentAction(errorMessage: inRangeMessage);

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
        GuardResourceManager resourceManager = new();
        var isLowerMessage = string.Format(resourceManager.IsLower, value, lowerBound);
        Action isLowerAction = MakeArgumentAction(errorMessage: isLowerMessage);

        Guard.IsLower(value, lowerBound: lowerBound, perform: isLowerAction);   
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
        GuardResourceManager resourceManager = new();
        var IsLowerOrEqualsMessage = string.Format(resourceManager.IsLowerOrEquals, value, lowerBound);
        Action IsLowerOrEqualsAction = MakeArgumentAction(errorMessage: IsLowerOrEqualsMessage);

        Guard.IsLowerOrEquals(value, lowerBound: lowerBound, perform: IsLowerOrEqualsAction);   
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
        GuardResourceManager resourceManager = new();
        var isGreaterMessage = string.Format(resourceManager.IsGreater, value, upperBound);
        Action isGreaterAction = MakeArgumentAction(errorMessage: isGreaterMessage);

        Guard.IsGreater(value, upperBound: upperBound, perform: isGreaterAction);
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
        GuardResourceManager resourceManager = new();
        var isGreaterOrEqualsMessage = string.Format(resourceManager.IsGreaterOrEquals, value, upperBound);
        Action isGreaterOrEqualsAction = MakeArgumentAction(errorMessage: isGreaterOrEqualsMessage);

        Guard.IsGreaterOrEquals(value, upperBound: upperBound, perform: isGreaterOrEqualsAction);
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